namespace Project_Plateformer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Plateform = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Plateform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Plateform
            // 
            this.Plateform.BackColor = System.Drawing.Color.Transparent;
            this.Plateform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Plateform.BackgroundImage")));
            this.Plateform.Location = new System.Drawing.Point(3, 417);
            this.Plateform.Name = "Plateform";
            this.Plateform.Size = new System.Drawing.Size(798, 32);
            this.Plateform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plateform.TabIndex = 2;
            this.Plateform.TabStop = false;
            this.Plateform.Tag = "Plateform";
            this.Plateform.WaitOnLoad = true;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::Project_Plateformer.Properties.Resources.vlc;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Location = new System.Drawing.Point(23, 351);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(34, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 15;
            this.gameTime.Tick += new System.EventHandler(this.MainGameTimeEvent);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Plateform);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Plateform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Plateform;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gameTime;
    }
}