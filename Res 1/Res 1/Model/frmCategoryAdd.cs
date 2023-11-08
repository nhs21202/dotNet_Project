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

namespace Res_1.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public void btnSaveClick(object sender, EventArgs e)
        {
            string qry = "";


            if (id == 0) //Insert
            {
                this.lblHeader.Text = "Add Category";
                qry = "Insert into category Values(@Name)";

            }
            else // Update
            {
                qry = "Update category Set catName = @Name where catID = @id";
                this.lblHeader.Text = "Edit Category";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoryAdd_Load(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
