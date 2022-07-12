namespace ProjetISTA
{
    partial class LDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDS));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.loadingtimer = new System.Windows.Forms.Timer(this.components);
            this.loading1 = new System.Windows.Forms.Panel();
            this.loading2 = new System.Windows.Forms.Panel();
            this.ElipseLDS = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.loading1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::ProjetISTA.Properties.Resources.LoadingImage;
            this.gunaPictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1105, 567);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // loadingtimer
            // 
            this.loadingtimer.Enabled = true;
            this.loadingtimer.Interval = 15;
            this.loadingtimer.Tick += new System.EventHandler(this.loadingtimer_Tick);
            // 
            // loading1
            // 
            this.loading1.Controls.Add(this.loading2);
            this.loading1.Location = new System.Drawing.Point(-1, 533);
            this.loading1.Margin = new System.Windows.Forms.Padding(4);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(1157, 38);
            this.loading1.TabIndex = 5;
            // 
            // loading2
            // 
            this.loading2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(137)))));
            this.loading2.Location = new System.Drawing.Point(0, 0);
            this.loading2.Margin = new System.Windows.Forms.Padding(4);
            this.loading2.Name = "loading2";
            this.loading2.Size = new System.Drawing.Size(73, 38);
            this.loading2.TabIndex = 1;
            // 
            // ElipseLDS
            // 
            this.ElipseLDS.BorderRadius = 15;
            this.ElipseLDS.TargetControl = this;
            // 
            // LDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 568);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDS";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.loading1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Timer loadingtimer;
        private System.Windows.Forms.Panel loading1;
        private System.Windows.Forms.Panel loading2;
        private Guna.UI2.WinForms.Guna2Elipse ElipseLDS;
    }
}