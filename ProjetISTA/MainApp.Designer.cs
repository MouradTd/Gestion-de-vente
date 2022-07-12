namespace ProjetISTA
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNP = new Guna.UI.WinForms.GunaButton();
            this.btnNV = new Guna.UI.WinForms.GunaButton();
            this.btnGC = new Guna.UI.WinForms.GunaButton();
            this.btnGP = new Guna.UI.WinForms.GunaButton();
            this.btnGV = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnNC = new Guna.UI.WinForms.GunaButton();
            this.btnDiscon = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseAPP = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDiscon);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 527);
            this.panel2.TabIndex = 2;
            // 
            // btnNP
            // 
            this.btnNP.AnimationHoverSpeed = 0.07F;
            this.btnNP.AnimationSpeed = 0.03F;
            this.btnNP.BackColor = System.Drawing.Color.Transparent;
            this.btnNP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNP.BorderColor = System.Drawing.Color.Black;
            this.btnNP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNP.FocusedColor = System.Drawing.Color.Empty;
            this.btnNP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNP.ForeColor = System.Drawing.Color.White;
            this.btnNP.Image = null;
            this.btnNP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNP.Location = new System.Drawing.Point(365, 277);
            this.btnNP.Margin = new System.Windows.Forms.Padding(4);
            this.btnNP.Name = "btnNP";
            this.btnNP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNP.OnHoverImage = null;
            this.btnNP.OnPressedColor = System.Drawing.Color.Black;
            this.btnNP.Radius = 8;
            this.btnNP.Size = new System.Drawing.Size(287, 62);
            this.btnNP.TabIndex = 4;
            this.btnNP.Text = "Ajouter Un Nouveau Produit";
            this.btnNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNP.Click += new System.EventHandler(this.btnNP_Click);
            // 
            // btnNV
            // 
            this.btnNV.AnimationHoverSpeed = 0.07F;
            this.btnNV.AnimationSpeed = 0.03F;
            this.btnNV.BackColor = System.Drawing.Color.Transparent;
            this.btnNV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNV.BorderColor = System.Drawing.Color.Black;
            this.btnNV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNV.FocusedColor = System.Drawing.Color.Empty;
            this.btnNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNV.ForeColor = System.Drawing.Color.White;
            this.btnNV.Image = null;
            this.btnNV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNV.Location = new System.Drawing.Point(365, 383);
            this.btnNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnNV.Name = "btnNV";
            this.btnNV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNV.OnHoverImage = null;
            this.btnNV.OnPressedColor = System.Drawing.Color.Black;
            this.btnNV.Radius = 8;
            this.btnNV.Size = new System.Drawing.Size(287, 62);
            this.btnNV.TabIndex = 5;
            this.btnNV.Text = "Ajouter Une Nouvelle Vente";
            this.btnNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnGC
            // 
            this.btnGC.AnimationHoverSpeed = 0.07F;
            this.btnGC.AnimationSpeed = 0.03F;
            this.btnGC.BackColor = System.Drawing.Color.Transparent;
            this.btnGC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGC.BorderColor = System.Drawing.Color.Black;
            this.btnGC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGC.FocusedColor = System.Drawing.Color.Empty;
            this.btnGC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGC.ForeColor = System.Drawing.Color.White;
            this.btnGC.Image = null;
            this.btnGC.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGC.Location = new System.Drawing.Point(729, 169);
            this.btnGC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGC.Name = "btnGC";
            this.btnGC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnGC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGC.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGC.OnHoverImage = null;
            this.btnGC.OnPressedColor = System.Drawing.Color.Black;
            this.btnGC.Radius = 8;
            this.btnGC.Size = new System.Drawing.Size(287, 62);
            this.btnGC.TabIndex = 7;
            this.btnGC.Text = "Gestion Des Clients";
            this.btnGC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnGP
            // 
            this.btnGP.AnimationHoverSpeed = 0.07F;
            this.btnGP.AnimationSpeed = 0.03F;
            this.btnGP.BackColor = System.Drawing.Color.Transparent;
            this.btnGP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGP.BorderColor = System.Drawing.Color.Black;
            this.btnGP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGP.FocusedColor = System.Drawing.Color.Empty;
            this.btnGP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGP.ForeColor = System.Drawing.Color.White;
            this.btnGP.Image = null;
            this.btnGP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGP.Location = new System.Drawing.Point(729, 277);
            this.btnGP.Margin = new System.Windows.Forms.Padding(4);
            this.btnGP.Name = "btnGP";
            this.btnGP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnGP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGP.OnHoverImage = null;
            this.btnGP.OnPressedColor = System.Drawing.Color.Black;
            this.btnGP.Radius = 8;
            this.btnGP.Size = new System.Drawing.Size(287, 62);
            this.btnGP.TabIndex = 8;
            this.btnGP.Text = "Gestions Des Produits";
            this.btnGP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGP.Click += new System.EventHandler(this.btnGP_Click);
            // 
            // btnGV
            // 
            this.btnGV.AnimationHoverSpeed = 0.07F;
            this.btnGV.AnimationSpeed = 0.03F;
            this.btnGV.BackColor = System.Drawing.Color.Transparent;
            this.btnGV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGV.BorderColor = System.Drawing.Color.Black;
            this.btnGV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGV.FocusedColor = System.Drawing.Color.Empty;
            this.btnGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGV.ForeColor = System.Drawing.Color.White;
            this.btnGV.Image = null;
            this.btnGV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGV.Location = new System.Drawing.Point(729, 383);
            this.btnGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnGV.Name = "btnGV";
            this.btnGV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnGV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGV.OnHoverImage = null;
            this.btnGV.OnPressedColor = System.Drawing.Color.Black;
            this.btnGV.Radius = 8;
            this.btnGV.Size = new System.Drawing.Size(287, 62);
            this.btnGV.TabIndex = 9;
            this.btnGV.Text = "Gestions Des Ventes";
            this.btnGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnCloseAPP);
            this.gunaPanel1.Controls.Add(this.Minimize);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1105, 46);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btnNC
            // 
            this.btnNC.AnimationHoverSpeed = 0.07F;
            this.btnNC.AnimationSpeed = 0.03F;
            this.btnNC.BackColor = System.Drawing.Color.Transparent;
            this.btnNC.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNC.BorderColor = System.Drawing.Color.Black;
            this.btnNC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNC.FocusedColor = System.Drawing.Color.Empty;
            this.btnNC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNC.ForeColor = System.Drawing.Color.White;
            this.btnNC.Image = null;
            this.btnNC.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNC.Location = new System.Drawing.Point(365, 169);
            this.btnNC.Margin = new System.Windows.Forms.Padding(4);
            this.btnNC.Name = "btnNC";
            this.btnNC.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNC.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNC.OnHoverImage = null;
            this.btnNC.OnPressedColor = System.Drawing.Color.Black;
            this.btnNC.Radius = 8;
            this.btnNC.Size = new System.Drawing.Size(287, 62);
            this.btnNC.TabIndex = 3;
            this.btnNC.Text = "Ajouter Un Nouveau Client";
            this.btnNC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNC.Click += new System.EventHandler(this.btnNC_Click);
            // 
            // btnDiscon
            // 
            this.btnDiscon.Animated = true;
            this.btnDiscon.BorderRadius = 10;
            this.btnDiscon.CheckedState.Parent = this.btnDiscon;
            this.btnDiscon.CustomImages.Parent = this.btnDiscon;
            this.btnDiscon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDiscon.FillColor = System.Drawing.Color.White;
            this.btnDiscon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscon.ForeColor = System.Drawing.Color.Black;
            this.btnDiscon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.btnDiscon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDiscon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDiscon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscon.HoverState.Image")));
            this.btnDiscon.HoverState.Parent = this.btnDiscon;
            this.btnDiscon.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscon.Image")));
            this.btnDiscon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiscon.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDiscon.Location = new System.Drawing.Point(0, 464);
            this.btnDiscon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.ShadowDecoration.Parent = this.btnDiscon;
            this.btnDiscon.Size = new System.Drawing.Size(311, 63);
            this.btnDiscon.TabIndex = 8;
            this.btnDiscon.Text = "Se Deconnecter";
            this.btnDiscon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiscon.TextOffset = new System.Drawing.Point(25, 0);
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FillColor = System.Drawing.Color.White;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSettings.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.HoverState.Image")));
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSettings.Location = new System.Drawing.Point(0, 71);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(311, 66);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Parametres Profile";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.TextOffset = new System.Drawing.Point(25, 0);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BorderRadius = 10;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.HoverState.Image")));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(311, 71);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Acceuil";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // btnCloseAPP
            // 
            this.btnCloseAPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAPP.CheckedState.Parent = this.btnCloseAPP;
            this.btnCloseAPP.CustomImages.Parent = this.btnCloseAPP;
            this.btnCloseAPP.FillColor = System.Drawing.Color.White;
            this.btnCloseAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAPP.ForeColor = System.Drawing.Color.Gray;
            this.btnCloseAPP.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnCloseAPP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCloseAPP.HoverState.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAPP.Image")));
            this.btnCloseAPP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseAPP.Location = new System.Drawing.Point(1048, 0);
            this.btnCloseAPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAPP.Name = "btnCloseAPP";
            this.btnCloseAPP.ShadowDecoration.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Size = new System.Drawing.Size(56, 46);
            this.btnCloseAPP.TabIndex = 8;
            this.btnCloseAPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseAPP.Click += new System.EventHandler(this.btnCloseAPP_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.White;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.FillColor = System.Drawing.Color.Silver;
            this.Minimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(986, 4);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(56, 38);
            this.Minimize.TabIndex = 7;
            this.Minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Minimize.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(72)))), ((int)(((byte)(74)))));
            this.gunaLabel1.Location = new System.Drawing.Point(989, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "Username";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(934, 53);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(48, 57);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 14;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel4.Location = new System.Drawing.Point(990, 83);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(38, 20);
            this.gunaLabel4.TabIndex = 15;
            this.gunaLabel4.Text = "User";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 573);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.btnGP);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnNP);
            this.Controls.Add(this.btnNC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainApp";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.panel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI.WinForms.GunaButton btnNP;
        private Guna.UI.WinForms.GunaButton btnNV;
        private Guna.UI.WinForms.GunaButton btnGC;
        private Guna.UI.WinForms.GunaButton btnGP;
        private Guna.UI.WinForms.GunaButton btnGV;
        private Guna.UI2.WinForms.Guna2Button btnDiscon;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI2.WinForms.Guna2Button btnCloseAPP;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnNC;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}