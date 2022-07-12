namespace ProjetISTA
{
    partial class Image_Produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image_Produit));
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.imgProduit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.guna2Button9);
            this.gunaPanel2.Controls.Add(this.Minimize);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(321, 37);
            this.gunaPanel2.TabIndex = 42;
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
            this.guna2Button9.Location = new System.Drawing.Point(281, 3);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.ShadowDecoration.Parent = this.guna2Button9;
            this.guna2Button9.Size = new System.Drawing.Size(42, 31);
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
            this.Minimize.Location = new System.Drawing.Point(232, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(42, 31);
            this.Minimize.TabIndex = 7;
            this.Minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // imgProduit
            // 
            this.imgProduit.BaseColor = System.Drawing.Color.White;
            this.imgProduit.Location = new System.Drawing.Point(7, 63);
            this.imgProduit.Name = "imgProduit";
            this.imgProduit.Size = new System.Drawing.Size(302, 322);
            this.imgProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduit.TabIndex = 43;
            this.imgProduit.TabStop = false;
            // 
            // Image_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 427);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.imgProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Image_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image_Produit";
            this.Load += new System.EventHandler(this.Image_Produit_Load);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI.WinForms.GunaPictureBox imgProduit;
    }
}