namespace Res_1.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            panel1 = new Panel();
            lblName = new Label();
            txtImage = new PictureBox();
            guna2ShadowPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2Separator1);
            guna2ShadowPanel1.Controls.Add(panel1);
            guna2ShadowPanel1.Controls.Add(txtImage);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(193, 198);
            guna2ShadowPanel1.TabIndex = 0;
            guna2ShadowPanel1.Paint += guna2ShadowPanel1_Paint;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(8, 148);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(221, 10);
            guna2Separator1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 52);
            panel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(8, 2);
            lblName.Name = "lblName";
            lblName.Size = new Size(180, 34);
            lblName.TabIndex = 0;
            lblName.Text = "Product Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            txtImage.Image = Properties.Resources.Xôi_chim;
            txtImage.Location = new Point(19, 6);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(155, 139);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.Click += txtImage_Click;
            // 
            // ucProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(guna2ShadowPanel1);
            Name = "ucProduct";
            Size = new Size(200, 201);
            guna2ShadowPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private PictureBox txtImage;
        private Panel panel1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
