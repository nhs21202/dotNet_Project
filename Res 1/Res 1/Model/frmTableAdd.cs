using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Res_1.View
{
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public void btnSaveClick(object sender, EventArgs e)
        {
            string qry = "";


            if (id == 0) //Insert
            {
                qry = "Insert into tables Values(@Name)";

            }
            else // Update
            {
                qry = "Update tables Set tName = @Name where tid = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                id = 0;
                txtName.Text = "";
                txtName.Focus();


            }
        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
