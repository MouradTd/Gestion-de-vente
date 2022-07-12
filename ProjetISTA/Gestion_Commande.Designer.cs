namespace ProjetISTA
{
    partial class Gestion_Commande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Commande));
            this.UserTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnAjoutCmd = new Guna.UI2.WinForms.Guna2Button();
            this.SupCmd = new Guna.UI2.WinForms.Guna2Button();
            this.ImprC = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseAPP = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.UserTxt.Location = new System.Drawing.Point(491, 14);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(5);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.PasswordChar = '\0';
            this.UserTxt.PlaceholderText = "";
            this.UserTxt.SelectedText = "";
            this.UserTxt.ShadowDecoration.Parent = this.UserTxt;
            this.UserTxt.Size = new System.Drawing.Size(267, 44);
            this.UserTxt.TabIndex = 41;
            this.UserTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTxt_KeyPress);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(269, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 20);
            this.gunaLabel1.TabIndex = 40;
            this.gunaLabel1.Text = "Recherche :";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(1, 144);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1255, 385);
            this.gunaDataGridView1.TabIndex = 57;
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
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // BtnAjoutCmd
            // 
            this.BtnAjoutCmd.BorderRadius = 10;
            this.BtnAjoutCmd.CheckedState.Parent = this.BtnAjoutCmd;
            this.BtnAjoutCmd.CustomImages.Parent = this.BtnAjoutCmd;
            this.BtnAjoutCmd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAjoutCmd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAjoutCmd.ForeColor = System.Drawing.Color.White;
            this.BtnAjoutCmd.HoverState.Parent = this.BtnAjoutCmd;
            this.BtnAjoutCmd.Location = new System.Drawing.Point(22, 593);
            this.BtnAjoutCmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAjoutCmd.Name = "BtnAjoutCmd";
            this.BtnAjoutCmd.ShadowDecoration.Parent = this.BtnAjoutCmd;
            this.BtnAjoutCmd.Size = new System.Drawing.Size(195, 65);
            this.BtnAjoutCmd.TabIndex = 58;
            this.BtnAjoutCmd.Text = "Ajouter une nouvelle Vente";
            this.BtnAjoutCmd.Click += new System.EventHandler(this.BtnAjoutCmd_Click);
            // 
            // SupCmd
            // 
            this.SupCmd.BorderRadius = 10;
            this.SupCmd.CheckedState.Parent = this.SupCmd;
            this.SupCmd.CustomImages.Parent = this.SupCmd;
            this.SupCmd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SupCmd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupCmd.ForeColor = System.Drawing.Color.White;
            this.SupCmd.HoverState.Parent = this.SupCmd;
            this.SupCmd.Location = new System.Drawing.Point(276, 593);
            this.SupCmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SupCmd.Name = "SupCmd";
            this.SupCmd.ShadowDecoration.Parent = this.SupCmd;
            this.SupCmd.Size = new System.Drawing.Size(195, 65);
            this.SupCmd.TabIndex = 59;
            this.SupCmd.Text = "Supprimer une Vente";
            this.SupCmd.Click += new System.EventHandler(this.SupCmd_Click);
            // 
            // ImprC
            // 
            this.ImprC.BorderRadius = 10;
            this.ImprC.CheckedState.Parent = this.ImprC;
            this.ImprC.CustomImages.Parent = this.ImprC;
            this.ImprC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ImprC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ImprC.ForeColor = System.Drawing.Color.White;
            this.ImprC.HoverState.Parent = this.ImprC;
            this.ImprC.Location = new System.Drawing.Point(530, 593);
            this.ImprC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImprC.Name = "ImprC";
            this.ImprC.ShadowDecoration.Parent = this.ImprC;
            this.ImprC.Size = new System.Drawing.Size(195, 65);
            this.ImprC.TabIndex = 60;
            this.ImprC.Text = "Imprimer une Vente";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(530, 665);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(195, 65);
            this.guna2Button1.TabIndex = 65;
            this.guna2Button1.Text = "Annuler";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnCloseAPP.Location = new System.Drawing.Point(1200, -1);
            this.btnCloseAPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAPP.Name = "btnCloseAPP";
            this.btnCloseAPP.ShadowDecoration.Parent = this.btnCloseAPP;
            this.btnCloseAPP.Size = new System.Drawing.Size(56, 46);
            this.btnCloseAPP.TabIndex = 67;
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
            this.Minimize.Location = new System.Drawing.Point(1135, 3);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(56, 38);
            this.Minimize.TabIndex = 66;
            this.Minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(1038, 593);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(195, 65);
            this.guna2Button2.TabIndex = 68;
            this.guna2Button2.Text = "Afficher tous les informations";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel2.Location = new System.Drawing.Point(12, 99);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(383, 15);
            this.gunaLabel2.TabIndex = 69;
            this.gunaLabel2.Text = "Clicker sur la colone dans le tableau pour effectuer une des opperations";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(779, 593);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(195, 65);
            this.guna2Button3.TabIndex = 70;
            this.guna2Button3.Text = "imprimer facture";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // Gestion_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 736);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnCloseAPP);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ImprC);
            this.Controls.Add(this.SupCmd);
            this.Controls.Add(this.BtnAjoutCmd);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_Commande";
            this.Load += new System.EventHandler(this.Gestion_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox UserTxt;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI2.WinForms.Guna2Button BtnAjoutCmd;
        private Guna.UI2.WinForms.Guna2Button SupCmd;
        private Guna.UI2.WinForms.Guna2Button ImprC;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnCloseAPP;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}