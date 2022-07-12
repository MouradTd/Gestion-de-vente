namespace ProjetISTA
{
    partial class Modifié_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifié_Client));
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelMail = new Guna.UI.WinForms.GunaLabel();
            this.importimg = new Guna.UI2.WinForms.Guna2Button();
            this.CameraList = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.BackMenu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjout = new Guna.UI2.WinForms.Guna2Button();
            this.combosVilleCli = new Guna.UI.WinForms.GunaComboBox();
            this.lblVille = new Guna.UI.WinForms.GunaLabel();
            this.txtNumCli = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNum = new Guna.UI.WinForms.GunaLabel();
            this.txtPrenCli = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPren = new Guna.UI.WinForms.GunaLabel();
            this.txtNomCli = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNom = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.imguser = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtMail.BorderRadius = 10;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "Mail Client";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.Parent = this.txtMail;
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedState.Parent = this.txtMail;
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.HoverState.Parent = this.txtMail;
            this.txtMail.Location = new System.Drawing.Point(688, 276);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionStart = 11;
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(267, 44);
            this.txtMail.TabIndex = 59;
            // 
            // LabelMail
            // 
            this.LabelMail.AutoSize = true;
            this.LabelMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelMail.Location = new System.Drawing.Point(589, 279);
            this.LabelMail.Name = "LabelMail";
            this.LabelMail.Size = new System.Drawing.Size(45, 20);
            this.LabelMail.TabIndex = 58;
            this.LabelMail.Text = "Mail :";
            // 
            // importimg
            // 
            this.importimg.BorderRadius = 10;
            this.importimg.CheckedState.Parent = this.importimg;
            this.importimg.CustomImages.Parent = this.importimg;
            this.importimg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.importimg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.importimg.ForeColor = System.Drawing.Color.White;
            this.importimg.HoverState.Parent = this.importimg;
            this.importimg.Location = new System.Drawing.Point(147, 455);
            this.importimg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importimg.Name = "importimg";
            this.importimg.ShadowDecoration.Parent = this.importimg;
            this.importimg.Size = new System.Drawing.Size(235, 62);
            this.importimg.TabIndex = 57;
            this.importimg.Text = "Télécharger Une Image";
            this.importimg.Click += new System.EventHandler(this.importimg_Click);
            // 
            // CameraList
            // 
            this.CameraList.BackColor = System.Drawing.Color.Transparent;
            this.CameraList.BaseColor = System.Drawing.Color.White;
            this.CameraList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CameraList.BorderSize = 1;
            this.CameraList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraList.FocusedColor = System.Drawing.Color.Empty;
            this.CameraList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CameraList.ForeColor = System.Drawing.Color.Black;
            this.CameraList.FormattingEnabled = true;
            this.CameraList.Location = new System.Drawing.Point(154, 78);
            this.CameraList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraList.Name = "CameraList";
            this.CameraList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CameraList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CameraList.Radius = 8;
            this.CameraList.Size = new System.Drawing.Size(267, 31);
            this.CameraList.TabIndex = 55;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(42, 84);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(100, 20);
            this.gunaLabel5.TabIndex = 54;
            this.gunaLabel5.Text = "Image Client :";
            // 
            // BackMenu
            // 
            this.BackMenu.BorderRadius = 10;
            this.BackMenu.CheckedState.Parent = this.BackMenu;
            this.BackMenu.CustomImages.Parent = this.BackMenu;
            this.BackMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackMenu.ForeColor = System.Drawing.Color.White;
            this.BackMenu.HoverState.Parent = this.BackMenu;
            this.BackMenu.Location = new System.Drawing.Point(689, 455);
            this.BackMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.ShadowDecoration.Parent = this.BackMenu;
            this.BackMenu.Size = new System.Drawing.Size(235, 62);
            this.BackMenu.TabIndex = 53;
            this.BackMenu.Text = "Annuler";
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // BtnAjout
            // 
            this.BtnAjout.BorderRadius = 10;
            this.BtnAjout.CheckedState.Parent = this.BtnAjout;
            this.BtnAjout.CustomImages.Parent = this.BtnAjout;
            this.BtnAjout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAjout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjout.ForeColor = System.Drawing.Color.White;
            this.BtnAjout.HoverState.Parent = this.BtnAjout;
            this.BtnAjout.Location = new System.Drawing.Point(418, 455);
            this.BtnAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.ShadowDecoration.Parent = this.BtnAjout;
            this.BtnAjout.Size = new System.Drawing.Size(235, 62);
            this.BtnAjout.TabIndex = 52;
            this.BtnAjout.Text = "Modifié Client";
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // combosVilleCli
            // 
            this.combosVilleCli.BackColor = System.Drawing.Color.Transparent;
            this.combosVilleCli.BaseColor = System.Drawing.Color.White;
            this.combosVilleCli.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.combosVilleCli.BorderSize = 1;
            this.combosVilleCli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combosVilleCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosVilleCli.FocusedColor = System.Drawing.Color.Empty;
            this.combosVilleCli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combosVilleCli.ForeColor = System.Drawing.Color.Black;
            this.combosVilleCli.FormattingEnabled = true;
            this.combosVilleCli.Location = new System.Drawing.Point(685, 340);
            this.combosVilleCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combosVilleCli.Name = "combosVilleCli";
            this.combosVilleCli.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combosVilleCli.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combosVilleCli.Radius = 8;
            this.combosVilleCli.Size = new System.Drawing.Size(267, 31);
            this.combosVilleCli.TabIndex = 51;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVille.Location = new System.Drawing.Point(586, 342);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(45, 20);
            this.lblVille.TabIndex = 50;
            this.lblVille.Text = "Ville :";
            // 
            // txtNumCli
            // 
            this.txtNumCli.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNumCli.BorderRadius = 10;
            this.txtNumCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumCli.DefaultText = "Num Client";
            this.txtNumCli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumCli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumCli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumCli.DisabledState.Parent = this.txtNumCli;
            this.txtNumCli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumCli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumCli.FocusedState.Parent = this.txtNumCli;
            this.txtNumCli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumCli.HoverState.Parent = this.txtNumCli;
            this.txtNumCli.Location = new System.Drawing.Point(685, 212);
            this.txtNumCli.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumCli.Name = "txtNumCli";
            this.txtNumCli.PasswordChar = '\0';
            this.txtNumCli.PlaceholderText = "";
            this.txtNumCli.SelectedText = "";
            this.txtNumCli.SelectionStart = 10;
            this.txtNumCli.ShadowDecoration.Parent = this.txtNumCli;
            this.txtNumCli.Size = new System.Drawing.Size(267, 44);
            this.txtNumCli.TabIndex = 49;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNum.Location = new System.Drawing.Point(586, 221);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(85, 20);
            this.lblNum.TabIndex = 48;
            this.lblNum.Text = "Telephone :";
            // 
            // txtPrenCli
            // 
            this.txtPrenCli.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPrenCli.BorderRadius = 10;
            this.txtPrenCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenCli.DefaultText = "Prenom Client";
            this.txtPrenCli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrenCli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrenCli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenCli.DisabledState.Parent = this.txtPrenCli;
            this.txtPrenCli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrenCli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenCli.FocusedState.Parent = this.txtPrenCli;
            this.txtPrenCli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrenCli.HoverState.Parent = this.txtPrenCli;
            this.txtPrenCli.Location = new System.Drawing.Point(685, 148);
            this.txtPrenCli.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrenCli.Name = "txtPrenCli";
            this.txtPrenCli.PasswordChar = '\0';
            this.txtPrenCli.PlaceholderText = "";
            this.txtPrenCli.SelectedText = "";
            this.txtPrenCli.SelectionStart = 13;
            this.txtPrenCli.ShadowDecoration.Parent = this.txtPrenCli;
            this.txtPrenCli.Size = new System.Drawing.Size(267, 44);
            this.txtPrenCli.TabIndex = 47;
            // 
            // lblPren
            // 
            this.lblPren.AutoSize = true;
            this.lblPren.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPren.Location = new System.Drawing.Point(586, 158);
            this.lblPren.Name = "lblPren";
            this.lblPren.Size = new System.Drawing.Size(67, 20);
            this.lblPren.TabIndex = 46;
            this.lblPren.Text = "Prenom :";
            // 
            // txtNomCli
            // 
            this.txtNomCli.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNomCli.BorderRadius = 10;
            this.txtNomCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomCli.DefaultText = "Nom Client";
            this.txtNomCli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomCli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomCli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomCli.DisabledState.Parent = this.txtNomCli;
            this.txtNomCli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomCli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomCli.FocusedState.Parent = this.txtNomCli;
            this.txtNomCli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomCli.HoverState.Parent = this.txtNomCli;
            this.txtNomCli.Location = new System.Drawing.Point(688, 84);
            this.txtNomCli.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.PasswordChar = '\0';
            this.txtNomCli.PlaceholderText = "";
            this.txtNomCli.SelectedText = "";
            this.txtNomCli.SelectionStart = 10;
            this.txtNomCli.ShadowDecoration.Parent = this.txtNomCli;
            this.txtNomCli.Size = new System.Drawing.Size(267, 44);
            this.txtNomCli.TabIndex = 45;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNom.Location = new System.Drawing.Point(587, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 20);
            this.lblNom.TabIndex = 44;
            this.lblNom.Text = "Nom :";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.guna2Button9);
            this.gunaPanel2.Controls.Add(this.Minimize);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1062, 46);
            this.gunaPanel2.TabIndex = 60;
            // 
            // guna2Button9
            // 
            this.guna2Button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button9.CheckedState.Parent = this.guna2Button9;
            this.guna2Button9.CustomImages.Parent = this.guna2Button9;
            this.guna2Button9.FillColor = System.Drawing.Color.White;
            this.guna2Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button9.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button9.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.Parent = this.guna2Button9;
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.Location = new System.Drawing.Point(1009, 4);
            this.guna2Button9.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.ShadowDecoration.Parent = this.guna2Button9;
            this.guna2Button9.Size = new System.Drawing.Size(56, 38);
            this.guna2Button9.TabIndex = 8;
            this.guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.White;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(944, 4);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(56, 38);
            this.Minimize.TabIndex = 7;
            this.Minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // imguser
            // 
            this.imguser.BaseColor = System.Drawing.Color.White;
            this.imguser.Location = new System.Drawing.Point(46, 116);
            this.imguser.Margin = new System.Windows.Forms.Padding(4);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(376, 300);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imguser.TabIndex = 56;
            this.imguser.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // Modifié_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 551);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.LabelMail);
            this.Controls.Add(this.importimg);
            this.Controls.Add(this.imguser);
            this.Controls.Add(this.CameraList);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.combosVilleCli);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtNumCli);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtPrenCli);
            this.Controls.Add(this.lblPren);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modifié_Client";
            this.Text = "Modifié_Client";
            this.Load += new System.EventHandler(this.Modifié_Client_Load);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI.WinForms.GunaLabel LabelMail;
        private Guna.UI2.WinForms.Guna2Button importimg;
        private Guna.UI.WinForms.GunaPictureBox imguser;
        private Guna.UI.WinForms.GunaComboBox CameraList;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2Button BackMenu;
        private Guna.UI2.WinForms.Guna2Button BtnAjout;
        private Guna.UI.WinForms.GunaComboBox combosVilleCli;
        private Guna.UI.WinForms.GunaLabel lblVille;
        private Guna.UI2.WinForms.Guna2TextBox txtNumCli;
        private Guna.UI.WinForms.GunaLabel lblNum;
        private Guna.UI2.WinForms.Guna2TextBox txtPrenCli;
        private Guna.UI.WinForms.GunaLabel lblPren;
        private Guna.UI2.WinForms.Guna2TextBox txtNomCli;
        private Guna.UI.WinForms.GunaLabel lblNom;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}