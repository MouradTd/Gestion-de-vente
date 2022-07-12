namespace ProjetISTA
{
    partial class Gestion_Produit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Produit));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Id_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img_pr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnAjout = new Guna.UI2.WinForms.Guna2Button();
            this.brnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditPr = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnGetImg = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseAPP = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(35, 142);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(135, 20);
            this.gunaLabel2.TabIndex = 43;
            this.gunaLabel2.Text = "Liste des Produits  :";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 20;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Pr,
            this.Id_Cat,
            this.Nom_Pr,
            this.Nom_Cat,
            this.Quantite_Pr,
            this.Description_Pr,
            this.Prix_Pr,
            this.Img_pr});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(15, 194);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1423, 415);
            this.gunaDataGridView1.TabIndex = 42;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            // 
            // Id_Pr
            // 
            this.Id_Pr.HeaderText = "Id_Pr";
            this.Id_Pr.Name = "Id_Pr";
            this.Id_Pr.ReadOnly = true;
            this.Id_Pr.Visible = false;
            // 
            // Id_Cat
            // 
            this.Id_Cat.HeaderText = "Id_Cat";
            this.Id_Cat.Name = "Id_Cat";
            this.Id_Cat.ReadOnly = true;
            this.Id_Cat.Visible = false;
            // 
            // Nom_Pr
            // 
            this.Nom_Pr.HeaderText = "Produit";
            this.Nom_Pr.Name = "Nom_Pr";
            this.Nom_Pr.ReadOnly = true;
            // 
            // Nom_Cat
            // 
            this.Nom_Cat.HeaderText = "Categotie";
            this.Nom_Cat.Name = "Nom_Cat";
            this.Nom_Cat.ReadOnly = true;
            // 
            // Quantite_Pr
            // 
            this.Quantite_Pr.HeaderText = "Quantite";
            this.Quantite_Pr.Name = "Quantite_Pr";
            this.Quantite_Pr.ReadOnly = true;
            // 
            // Description_Pr
            // 
            this.Description_Pr.HeaderText = "Description";
            this.Description_Pr.Name = "Description_Pr";
            this.Description_Pr.ReadOnly = true;
            // 
            // Prix_Pr
            // 
            this.Prix_Pr.HeaderText = "Prix";
            this.Prix_Pr.Name = "Prix_Pr";
            this.Prix_Pr.ReadOnly = true;
            // 
            // Img_pr
            // 
            this.Img_pr.HeaderText = "Img_Pr";
            this.Img_pr.Name = "Img_pr";
            this.Img_pr.ReadOnly = true;
            this.Img_pr.Visible = false;
            // 
            // UserTxt
            // 
            this.UserTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UserTxt.BorderRadius = 10;
            this.UserTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTxt.DefaultText = "";
            this.UserTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTxt.DisabledState.Parent = this.UserTxt;
            this.UserTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTxt.FocusedState.Parent = this.UserTxt;
            this.UserTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTxt.HoverState.Parent = this.UserTxt;
            this.UserTxt.Location = new System.Drawing.Point(748, 25);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(5);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.PasswordChar = '\0';
            this.UserTxt.PlaceholderText = "";
            this.UserTxt.SelectedText = "";
            this.UserTxt.ShadowDecoration.Parent = this.UserTxt;
            this.UserTxt.Size = new System.Drawing.Size(267, 44);
            this.UserTxt.TabIndex = 41;
            this.UserTxt.TextChanged += new System.EventHandler(this.UserTxt_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(525, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 20);
            this.gunaLabel1.TabIndex = 40;
            this.gunaLabel1.Text = "Recherche :";
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
            this.BtnAjout.Location = new System.Drawing.Point(47, 650);
            this.BtnAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.ShadowDecoration.Parent = this.BtnAjout;
            this.BtnAjout.Size = new System.Drawing.Size(215, 69);
            this.BtnAjout.TabIndex = 48;
            this.BtnAjout.Text = "Ajouter un nouveau produit";
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // brnDelete
            // 
            this.brnDelete.BorderRadius = 10;
            this.brnDelete.CheckedState.Parent = this.brnDelete;
            this.brnDelete.CustomImages.Parent = this.brnDelete;
            this.brnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.brnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brnDelete.ForeColor = System.Drawing.Color.White;
            this.brnDelete.HoverState.Parent = this.brnDelete;
            this.brnDelete.Location = new System.Drawing.Point(341, 650);
            this.brnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brnDelete.Name = "brnDelete";
            this.brnDelete.ShadowDecoration.Parent = this.brnDelete;
            this.brnDelete.Size = new System.Drawing.Size(215, 69);
            this.brnDelete.TabIndex = 49;
            this.brnDelete.Text = "Supprimer produit";
            this.brnDelete.Click += new System.EventHandler(this.brnDelete_Click);
            // 
            // btnEditPr
            // 
            this.btnEditPr.BorderRadius = 10;
            this.btnEditPr.CheckedState.Parent = this.btnEditPr;
            this.btnEditPr.CustomImages.Parent = this.btnEditPr;
            this.btnEditPr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditPr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPr.ForeColor = System.Drawing.Color.White;
            this.btnEditPr.HoverState.Parent = this.btnEditPr;
            this.btnEditPr.Location = new System.Drawing.Point(636, 650);
            this.btnEditPr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPr.Name = "btnEditPr";
            this.btnEditPr.ShadowDecoration.Parent = this.btnEditPr;
            this.btnEditPr.Size = new System.Drawing.Size(215, 69);
            this.btnEditPr.TabIndex = 51;
            this.btnEditPr.Text = "Modifié données du produit";
            this.btnEditPr.Click += new System.EventHandler(this.btnEditPr_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(932, 650);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(215, 69);
            this.guna2Button4.TabIndex = 52;
            this.guna2Button4.Text = "Imprimer produits excel";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnGetImg
            // 
            this.btnGetImg.BorderRadius = 10;
            this.btnGetImg.CheckedState.Parent = this.btnGetImg;
            this.btnGetImg.CustomImages.Parent = this.btnGetImg;
            this.btnGetImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGetImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetImg.ForeColor = System.Drawing.Color.White;
            this.btnGetImg.HoverState.Parent = this.btnGetImg;
            this.btnGetImg.Location = new System.Drawing.Point(1227, 650);
            this.btnGetImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetImg.Name = "btnGetImg";
            this.btnGetImg.ShadowDecoration.Parent = this.btnGetImg;
            this.btnGetImg.Size = new System.Drawing.Size(215, 69);
            this.btnGetImg.TabIndex = 54;
            this.btnGetImg.Text = "image du produit produit";
            this.btnGetImg.Click += new System.EventHandler(this.btnGetImg_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(636, 737);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(215, 69);
            this.guna2Button7.TabIndex = 55;
            this.guna2Button7.Text = "Annuler";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnCloseAPP
            // 
            this.btnCloseAPP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAPP.CheckedState.Parent = this.btnCloseAPP;
            this.btnCloseAPP.CustomImages.Parent = this.btnCloseAPP;
            this.btnCloseAPP.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAPP.ForeColor = System.Drawing.Color.Gray;
            this.btnCloseAPP.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnCloseAPP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCloseAPP.HoverState.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAPP.Image")));
            this.btnCloseAPP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseAPP.Location = new System.Drawing.Point(1557, -5);
            this.btnCloseAPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAPP.Name = "btnCloseAPP";
            this.btnCloseAPP.ShadowDecoration.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Size = new System.Drawing.Size(56, 46);
            this.btnCloseAPP.TabIndex = 69;
            this.btnCloseAPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCloseAPP.Click += new System.EventHandler(this.btnCloseAPP_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.FillColor = System.Drawing.Color.Silver;
            this.Minimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoverState.Parent = this.Minimize;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(1493, 2);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(56, 38);
            this.Minimize.TabIndex = 68;
            this.Minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel3.Location = new System.Drawing.Point(838, 146);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(383, 15);
            this.gunaLabel3.TabIndex = 70;
            this.gunaLabel3.Text = "Clicker sur la colone dans le tableau pour effectuer une des opperations";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // Gestion_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 817);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btnCloseAPP);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.btnGetImg);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.btnEditPr);
            this.Controls.Add(this.brnDelete);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gestion_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_Produit";
            this.Load += new System.EventHandler(this.Gestion_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox UserTxt;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button BtnAjout;
        private Guna.UI2.WinForms.Guna2Button brnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEditPr;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnGetImg;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button btnCloseAPP;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite_Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Pr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Img_pr;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}