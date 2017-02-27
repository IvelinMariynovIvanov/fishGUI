namespace FishGUI
{
    partial class MainForm
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
            this.btAddFish = new System.Windows.Forms.Button();
            this.button2AddMullusk = new System.Windows.Forms.Button();
            this.groupBox1SelectOperaion = new System.Windows.Forms.GroupBox();
            this.button1CreateAquarium = new System.Windows.Forms.Button();
            this.groupBox1SelectOperaion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddFish
            // 
            this.btAddFish.Location = new System.Drawing.Point(18, 30);
            this.btAddFish.Name = "btAddFish";
            this.btAddFish.Size = new System.Drawing.Size(108, 23);
            this.btAddFish.TabIndex = 0;
            this.btAddFish.Text = "Add Fish";
            this.btAddFish.UseVisualStyleBackColor = true;
            this.btAddFish.Click += new System.EventHandler(this.btAddFish_Click);
            // 
            // button2AddMullusk
            // 
            this.button2AddMullusk.Location = new System.Drawing.Point(17, 59);
            this.button2AddMullusk.Name = "button2AddMullusk";
            this.button2AddMullusk.Size = new System.Drawing.Size(109, 23);
            this.button2AddMullusk.TabIndex = 1;
            this.button2AddMullusk.Text = "Add Mullusk";
            this.button2AddMullusk.UseVisualStyleBackColor = true;
            this.button2AddMullusk.Click += new System.EventHandler(this.button2AddMullusk_Click);
            // 
            // groupBox1SelectOperaion
            // 
            this.groupBox1SelectOperaion.Controls.Add(this.button1CreateAquarium);
            this.groupBox1SelectOperaion.Controls.Add(this.btAddFish);
            this.groupBox1SelectOperaion.Controls.Add(this.button2AddMullusk);
            this.groupBox1SelectOperaion.Location = new System.Drawing.Point(12, 12);
            this.groupBox1SelectOperaion.Name = "groupBox1SelectOperaion";
            this.groupBox1SelectOperaion.Size = new System.Drawing.Size(163, 281);
            this.groupBox1SelectOperaion.TabIndex = 2;
            this.groupBox1SelectOperaion.TabStop = false;
            this.groupBox1SelectOperaion.Text = "Select a operation";
            // 
            // button1CreateAquarium
            // 
            this.button1CreateAquarium.Location = new System.Drawing.Point(18, 89);
            this.button1CreateAquarium.Name = "button1CreateAquarium";
            this.button1CreateAquarium.Size = new System.Drawing.Size(108, 23);
            this.button1CreateAquarium.TabIndex = 2;
            this.button1CreateAquarium.Text = "Create aquarium";
            this.button1CreateAquarium.UseVisualStyleBackColor = true;
            this.button1CreateAquarium.Click += new System.EventHandler(this.button1CreateAquarium_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 352);
            this.Controls.Add(this.groupBox1SelectOperaion);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1SelectOperaion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddFish;
        private System.Windows.Forms.Button button2AddMullusk;
        private System.Windows.Forms.GroupBox groupBox1SelectOperaion;
        private System.Windows.Forms.Button button1CreateAquarium;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

