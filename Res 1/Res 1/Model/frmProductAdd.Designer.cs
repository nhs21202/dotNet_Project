namespace Res_1.Model
{
    partial class frmProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cbCat = new Guna.UI2.WinForms.Guna2ComboBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            lblName = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            lblPhone = new Label();
            lblRole = new Label();
            txtImage = new PictureBox();
            btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Size = new Size(140, 25);
            lblHeader.Text = "Product Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.product;
            pictureBox1.Size = new Size(77, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Click += btnSave_Click_1;
            // 
            // pnlBottom
            // 
            pnlBottom.Paint += pnlBottom_Paint;
            // 
            // pnlTop
            // 
            pnlTop.Paint += pnlTop_Paint;
            // 
            // cbCat
            // 
            cbCat.BackColor = Color.Transparent;
            cbCat.CustomizableEdges = customizableEdges3;
            cbCat.DrawMode = DrawMode.OwnerDrawFixed;
            cbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCat.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCat.ForeColor = Color.FromArgb(68, 88, 112);
            cbCat.ItemHeight = 30;
            cbCat.Location = new Point(33, 216);
            cbCat.Name = "cbCat";
            cbCat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbCat.Size = new Size(233, 36);
            cbCat.TabIndex = 15;
            cbCat.SelectedIndexChanged += cbbRole_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges5;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(33, 126);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtName.Size = new Size(233, 36);
            txtName.TabIndex = 13;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(33, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 14;
            lblName.Text = "Name";
            lblName.Click += lblName_Click;
            // 
            // txtPrice
            // 
            txtPrice.CustomizableEdges = customizableEdges7;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(33, 300);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPrice.Size = new Size(233, 36);
            txtPrice.TabIndex = 11;
            txtPrice.TextChanged += txtPhone_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(33, 282);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(33, 15);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "Price";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(33, 184);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 15);
            lblRole.TabIndex = 10;
            lblRole.Text = "Category";
            lblRole.Click += lblRole_Click;
            // 
            // txtImage
            // 
            txtImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtImage.Image = Properties.Resources.productPic;
            txtImage.Location = new Point(511, 108);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(192, 177);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 16;
            txtImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.AutoRoundedCorners = true;
            btnBrowse.BorderRadius = 21;
            btnBrowse.CustomizableEdges = customizableEdges9;
            btnBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(521, 300);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBrowse.Size = new Size(180, 45);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "Browse";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // frmProductAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(txtImage);
            Controls.Add(cbCat);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtPrice);
            Controls.Add(lblPhone);
            Controls.Add(lblRole);
            Name = "frmProductAdd";
            Text = "frmProductAdd";
            Load += frmProductAdd_Load;
            Controls.SetChildIndex(pnlTop, 0);
            Controls.SetChildIndex(pnlBottom, 0);
            Controls.SetChildIndex(lblRole, 0);
            Controls.SetChildIndex(lblPhone, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(cbCat, 0);
            Controls.SetChildIndex(txtImage, 0);
            Controls.SetChildIndex(btnBrowse, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbCat;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Label lblName;
        public Guna.UI2.WinForms.Guna2TextBox txtPrice;
        public Label lblPhone;
        public Label lblRole;
        private PictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
    }
}