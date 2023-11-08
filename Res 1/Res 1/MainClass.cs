using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res_1
{
    public class MainClass
    {

        //public static readonly string con_string = (@"Data Source = DATTRAN\SQLEXPRESS; Initial Catalog = RM; User ID = sa; Password = dev");
        public static readonly string con_string = (@"SON-THINKPAD\SQLEXPRESS; Initial Catalog = WINFORM_PROJECT; User ID = sa; Password = 123456");

        public static SqlConnection conn = new SqlConnection(con_string);

        //Check user validation

        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"Select * from users where username = '" + user + "' and upass = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["username"].ToString();
            }

            return isValid;
        }

        //Create property for username

        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }


        //Method for crud operation
        public static int SQl(string qry1, Hashtable ht)
        {

            int res = 0; //count how many times the commands has been executed
            try
            {
                SqlCommand cmd = new SqlCommand(qry1, conn); //setup sql command
                cmd.CommandType = CommandType.Text; // setup sql command
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value); // assign item.Value to item.Key, for example AddWithValue(@param1, 213) => replace @param1 with 123

                }
                if (conn.State == ConnectionState.Closed) conn.Open(); // open the conenction when it's closed
                res = cmd.ExecuteNonQuery(); // execute the 
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                conn.Close();
            }
            return res;

        }
        // For Loading Data from database

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {
                gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
                
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                //colNam là tên tất cả cột trong listbox, duyệt qua tên các cột của listbox rồi hiển thị thông tin tương ứng 
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    // cột colNam1 trong gv sẽ hiển thị các thông tin của cột i trong dt
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        //This method is used to show ordinal number
        public static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int ordinalNum = 1;
            foreach (DataGridViewRow row in gv.Rows)
            {
                row.Cells[0].Value = ordinalNum;
                ordinalNum++;
            }
        }
        public static void DarkBlurBackGround(Form Sample)
        {
            Form Background = new Form();
            using (Sample)
            {
                Background.StartPosition   = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Sample.Owner = Background;
                Sample.ShowDialog(Background);
                Background.Dispose();

            }
        }

        //For CB Fill

        public static void CBFill (string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }

    }
}
