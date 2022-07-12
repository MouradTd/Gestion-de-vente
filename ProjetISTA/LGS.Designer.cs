namespace ProjetISTA
{
    partial class LGS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LGS));
            this.ElipseLGS = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ConnectBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseBtn1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UserTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SeePass = new System.Windows.Forms.Button();
            this.HidePass = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ElipseBtn2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AttentionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseAPP = new Guna.UI2.WinForms.Guna2Button();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseLGS
            // 
            this.ElipseLGS.BorderRadius = 15;
            this.ElipseLGS.TargetControl = this;
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.CheckedState.Parent = this.ConnectBTN;
            this.ConnectBTN.CustomImages.Parent = this.ConnectBTN;
            this.ConnectBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConnectBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectBTN.ForeColor = System.Drawing.Color.White;
            this.ConnectBTN.HoverState.Parent = this.ConnectBTN;
            this.ConnectBTN.Location = new System.Drawing.Point(583, 327);
            this.ConnectBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.ShadowDecoration.Parent = this.ConnectBTN;
            this.ConnectBTN.Size = new System.Drawing.Size(235, 62);
            this.ConnectBTN.TabIndex = 1;
            this.ConnectBTN.Text = "Connectez-Vous";
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // ElipseBtn1
            // 
            this.ElipseBtn1.BorderRadius = 25;
            this.ElipseBtn1.TargetControl = this.ConnectBTN;
            // 
            // UserTxt
            // 
            this.UserTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.UserTxt.BorderRadius = 10;
            this.UserTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTxt.DefaultText = "Nom Utilisateur";
            this.UserTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTxt.DisabledState.Parent = this.UserTxt;
            this.UserTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTxt.FocusedState.Parent = this.UserTxt;
            this.UserTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTxt.HoverState.Parent = this.UserTxt;
            this.UserTxt.Location = new System.Drawing.Point(567, 150);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(5);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.PasswordChar = '\0';
            this.UserTxt.PlaceholderText = "";
            this.UserTxt.SelectedText = "";
            this.UserTxt.SelectionStart = 15;
            this.UserTxt.ShadowDecoration.Parent = this.UserTxt;
            this.UserTxt.Size = new System.Drawing.Size(267, 44);
            this.UserTxt.TabIndex = 2;
            this.UserTxt.Enter += new System.EventHandler(this.UserText_Enter);
            // 
            // PassTxt
            // 
            this.PassTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.PassTxt.BorderRadius = 10;
            this.PassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTxt.DefaultText = "Mot De Passe";
            this.PassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassTxt.DisabledState.Parent = this.PassTxt;
            this.PassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PassTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassTxt.FocusedState.Parent = this.PassTxt;
            this.PassTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassTxt.HoverState.Parent = this.PassTxt;
            this.PassTxt.Location = new System.Drawing.Point(567, 228);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(5);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.PlaceholderText = "";
            this.PassTxt.SelectedText = "";
            this.PassTxt.SelectionStart = 12;
            this.PassTxt.ShadowDecoration.Parent = this.PassTxt;
            this.PassTxt.Size = new System.Drawing.Size(267, 44);
            this.PassTxt.TabIndex = 3;
            this.PassTxt.Enter += new System.EventHandler(this.PassText_Enter);
            // 
            // SeePass
            // 
            this.SeePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SeePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SeePass.BackgroundImage")));
            this.SeePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeePass.FlatAppearance.BorderSize = 0;
            this.SeePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeePass.Location = new System.Drawing.Point(789, 238);
            this.SeePass.Margin = new System.Windows.Forms.Padding(4);
            this.SeePass.Name = "SeePass";
            this.SeePass.Size = new System.Drawing.Size(28, 23);
            this.SeePass.TabIndex = 28;
            this.SeePass.UseVisualStyleBackColor = false;
            this.SeePass.Click += new System.EventHandler(this.SeePass_Click);
            // 
            // HidePass
            // 
            this.HidePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.HidePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HidePass.BackgroundImage")));
            this.HidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HidePass.FlatAppearance.BorderSize = 0;
            this.HidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePass.Location = new System.Drawing.Point(789, 238);
            this.HidePass.Margin = new System.Windows.Forms.Padding(4);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(28, 23);
            this.HidePass.TabIndex = 27;
            this.HidePass.UseVisualStyleBackColor = false;
            this.HidePass.Click += new System.EventHandler(this.HidePass_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ProjetISTA.Properties.Resources.UserL;
            this.pictureBox2.Location = new System.Drawing.Point(789, 160);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ElipseBtn2
            // 
            this.ElipseBtn2.BorderRadius = 20;
            // 
            // AttentionLabel
            // 
            this.AttentionLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttentionLabel.Location = new System.Drawing.Point(583, 290);
            this.AttentionLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttentionLabel.Name = "AttentionLabel";
            this.AttentionLabel.Size = new System.Drawing.Size(3, 2);
            this.AttentionLabel.TabIndex = 30;
            this.AttentionLabel.Text = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseAPP);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 49);
            this.panel1.TabIndex = 31;
            // 
            // btnCloseAPP
            // 
            this.btnCloseAPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAPP.CheckedState.Parent = this.btnCloseAPP;
            this.btnCloseAPP.CustomImages.Parent = this.btnCloseAPP;
            this.btnCloseAPP.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAPP.ForeColor = System.Drawing.Color.Gray;
            this.btnCloseAPP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCloseAPP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCloseAPP.HoverState.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAPP.Image")));
            this.btnCloseAPP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseAPP.Location = new System.Drawing.Point(826, 2);
            this.btnCloseAPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAPP.Name = "btnCloseAPP";
            this.btnCloseAPP.ShadowDecoration.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Size = new System.Drawing.Size(56, 46);
            this.btnCloseAPP.TabIndex = 9;
            this.btnCloseAPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseAPP.Click += new System.EventHandler(this.btnCloseAPP_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // LGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(895, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AttentionLabel);
            this.Controls.Add(this.SeePass);
            this.Controls.Add(this.HidePass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.ConnectBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LGS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseLGS;
        private Guna.UI2.WinForms.Guna2Button ConnectBTN;
        private Guna.UI2.WinForms.Guna2Elipse ElipseBtn1;
        private Guna.UI2.WinForms.Guna2TextBox UserTxt;
        private Guna.UI2.WinForms.Guna2TextBox PassTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SeePass;
        private System.Windows.Forms.Button HidePass;
        private Guna.UI2.WinForms.Guna2Elipse ElipseBtn2;
        private Guna.UI2.WinForms.Guna2HtmlLabel AttentionLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCloseAPP;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}