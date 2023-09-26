namespace Project_Plateformer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.END = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Plateform = new System.Windows.Forms.PictureBox();
            this.mob1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.removable = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.END)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plateform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(933, 19);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(135, 33);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            this.txtScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 15;
            this.gameTime.Tick += new System.EventHandler(this.MainGameTimeEvent);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(24, 60);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(176, 30);
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "Plateform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::Project_Plateformer.Properties.Resources.vlc;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Player.Location = new System.Drawing.Point(55, 332);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(34, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 30);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Plateform";
            // 
            // END
            // 
            this.END.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.END.BackgroundImage = global::Project_Plateformer.Properties.Resources.Plateform__Personnalisé_;
            this.END.Location = new System.Drawing.Point(29, 945);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(47, 33);
            this.END.TabIndex = 10;
            this.END.TabStop = false;
            this.END.Tag = "Plateform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(763, 188);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 242);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Mur";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(623, 104);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Coin";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(689, 104);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Coin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(556, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(409, 30);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Plateform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(556, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(152, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Plateform";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Plateform
            // 
            this.Plateform.BackColor = System.Drawing.Color.Transparent;
            this.Plateform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Plateform.BackgroundImage")));
            this.Plateform.Location = new System.Drawing.Point(29, 398);
            this.Plateform.Name = "Plateform";
            this.Plateform.Size = new System.Drawing.Size(734, 32);
            this.Plateform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plateform.TabIndex = 1;
            this.Plateform.TabStop = false;
            this.Plateform.Tag = "Plateform";
            this.Plateform.WaitOnLoad = true;
            this.Plateform.Click += new System.EventHandler(this.Plateform_Click);
            // 
            // mob1
            // 
            this.mob1.BackColor = System.Drawing.Color.Transparent;
            this.mob1.Image = ((System.Drawing.Image)(resources.GetObject("mob1.Image")));
            this.mob1.Location = new System.Drawing.Point(464, 213);
            this.mob1.Name = "mob1";
            this.mob1.Size = new System.Drawing.Size(36, 36);
            this.mob1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mob1.TabIndex = 8;
            this.mob1.TabStop = false;
            this.mob1.Tag = "mob";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Project_Plateformer.Properties.Resources.end1;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(3, 675);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(113, 303);
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // removable
            // 
            this.removable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.removable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removable.BackgroundImage")));
            this.removable.Location = new System.Drawing.Point(962, 160);
            this.removable.Name = "removable";
            this.removable.Size = new System.Drawing.Size(127, 30);
            this.removable.TabIndex = 14;
            this.removable.TabStop = false;
            this.removable.Tag = "Plateform";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.Location = new System.Drawing.Point(-8, -14);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 992);
            this.pictureBox11.TabIndex = 15;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "Mur";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(1087, -2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(36, 980);
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "Mur";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(74, 945);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1016, 33);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "Plateform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Project_Plateformer.Properties.Resources.cave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.removable);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.END);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Plateform);
            this.Controls.Add(this.mob1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.txtScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.END)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plateform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Plateform;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox mob1;
        private System.Windows.Forms.PictureBox END;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox removable;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

