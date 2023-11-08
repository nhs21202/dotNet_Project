namespace Res_1.Model
{
    partial class frmStaffAdd
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
            lblRole = new Label();
            txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            lblPhone = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            lblName = new Label();
            cbbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBottom.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Size = new Size(111, 25);
            lblHeader.Text = "Staff Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pink_staffinfo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.Location = new Point(449, 21);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Location = new Point(307, 21);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Click += btnSave_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.Size = new Size(599, 78);
            // 
            // pnlTop
            // 
            pnlTop.Size = new Size(599, 90);
            pnlTop.Paint += pnlTop_Paint;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(26, 210);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // txtPhone
            // 
            txtPhone.CustomizableEdges = customizableEdges3;
            txtPhone.DefaultText = "";
            txtPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhone.Location = new Point(319, 127);
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PlaceholderText = "";
            txtPhone.SelectedText = "";
            txtPhone.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPhone.Size = new Size(226, 36);
            txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(319, 109);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
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
            txtName.Location = new Point(26, 127);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtName.Size = new Size(233, 36);
            txtName.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // cbbRole
            // 
            cbbRole.BackColor = Color.Transparent;
            cbbRole.CustomizableEdges = customizableEdges7;
            cbbRole.DrawMode = DrawMode.OwnerDrawFixed;
            cbbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRole.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbRole.ForeColor = Color.FromArgb(68, 88, 112);
            cbbRole.ItemHeight = 30;
            cbbRole.Items.AddRange(new object[] { "Manager", "Waiter/Waitress", "Chef", "Cashier", "Cleaner" });
            cbbRole.Location = new Point(26, 242);
            cbbRole.Name = "cbbRole";
            cbbRole.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbbRole.Size = new Size(233, 36);
            cbbRole.TabIndex = 9;
            // 
            // frmStaffAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(cbbRole);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblRole);
            Name = "frmStaffAdd";
            Text = "frmStaffAdd";
            Controls.SetChildIndex(pnlTop, 0);
            Controls.SetChildIndex(pnlBottom, 0);
            Controls.SetChildIndex(lblRole, 0);
            Controls.SetChildIndex(lblPhone, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(cbbRole, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox txtPhone;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Label lblRole;
        public Label lblPhone;
        public Label lblName;
        public Guna.UI2.WinForms.Guna2ComboBox cbbRole;
    }
}