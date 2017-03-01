namespace FishGUI
{
    partial class FishForm
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
            this.gBoxFishProp = new System.Windows.Forms.GroupBox();
            this.groupBox1FishType = new System.Windows.Forms.GroupBox();
            this.radioButton4GoldFish = new System.Windows.Forms.RadioButton();
            this.radioButton3Shark = new System.Windows.Forms.RadioButton();
            this.groupBoxFisheGender = new System.Windows.Forms.GroupBox();
            this.radioButton2Female = new System.Windows.Forms.RadioButton();
            this.radioButton1Male = new System.Windows.Forms.RadioButton();
            this.label6Needlitters = new System.Windows.Forms.Label();
            this.textBox6NeedLitters = new System.Windows.Forms.TextBox();
            this.label5MaxTemp = new System.Windows.Forms.Label();
            this.label4MinTemp = new System.Windows.Forms.Label();
            this.label3SizeInCm = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.textBox5MaxTemperature = new System.Windows.Forms.TextBox();
            this.textBox4MinTemperature = new System.Windows.Forms.TextBox();
            this.textBox3Size = new System.Windows.Forms.TextBox();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1AddFish = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxFishProp.SuspendLayout();
            this.groupBox1FishType.SuspendLayout();
            this.groupBoxFisheGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFishProp
            // 
            this.gBoxFishProp.Controls.Add(this.groupBox1FishType);
            this.gBoxFishProp.Controls.Add(this.groupBoxFisheGender);
            this.gBoxFishProp.Controls.Add(this.label6Needlitters);
            this.gBoxFishProp.Controls.Add(this.textBox6NeedLitters);
            this.gBoxFishProp.Controls.Add(this.label5MaxTemp);
            this.gBoxFishProp.Controls.Add(this.label4MinTemp);
            this.gBoxFishProp.Controls.Add(this.label3SizeInCm);
            this.gBoxFishProp.Controls.Add(this.label2Name);
            this.gBoxFishProp.Controls.Add(this.textBox5MaxTemperature);
            this.gBoxFishProp.Controls.Add(this.textBox4MinTemperature);
            this.gBoxFishProp.Controls.Add(this.textBox3Size);
            this.gBoxFishProp.Controls.Add(this.textBox2Name);
            this.gBoxFishProp.Location = new System.Drawing.Point(12, 12);
            this.gBoxFishProp.Name = "gBoxFishProp";
            this.gBoxFishProp.Size = new System.Drawing.Size(349, 445);
            this.gBoxFishProp.TabIndex = 0;
            this.gBoxFishProp.TabStop = false;
            this.gBoxFishProp.Text = "Enter fish properties";
            // 
            // groupBox1FishType
            // 
            this.groupBox1FishType.Controls.Add(this.radioButton4GoldFish);
            this.groupBox1FishType.Controls.Add(this.radioButton3Shark);
            this.groupBox1FishType.Location = new System.Drawing.Point(20, 33);
            this.groupBox1FishType.Name = "groupBox1FishType";
            this.groupBox1FishType.Size = new System.Drawing.Size(283, 86);
            this.groupBox1FishType.TabIndex = 2;
            this.groupBox1FishType.TabStop = false;
            this.groupBox1FishType.Text = "Choose fish type";
            // 
            // radioButton4GoldFish
            // 
            this.radioButton4GoldFish.AutoSize = true;
            this.radioButton4GoldFish.Location = new System.Drawing.Point(6, 52);
            this.radioButton4GoldFish.Name = "radioButton4GoldFish";
            this.radioButton4GoldFish.Size = new System.Drawing.Size(78, 17);
            this.radioButton4GoldFish.TabIndex = 1;
            this.radioButton4GoldFish.TabStop = true;
            this.radioButton4GoldFish.Text = "Golden fish";
            this.radioButton4GoldFish.UseVisualStyleBackColor = true;
            // 
            // radioButton3Shark
            // 
            this.radioButton3Shark.AutoSize = true;
            this.radioButton3Shark.Location = new System.Drawing.Point(6, 28);
            this.radioButton3Shark.Name = "radioButton3Shark";
            this.radioButton3Shark.Size = new System.Drawing.Size(53, 17);
            this.radioButton3Shark.TabIndex = 0;
            this.radioButton3Shark.TabStop = true;
            this.radioButton3Shark.Text = "Shark";
            this.radioButton3Shark.UseVisualStyleBackColor = true;
            // 
            // groupBoxFisheGender
            // 
            this.groupBoxFisheGender.Controls.Add(this.radioButton2Female);
            this.groupBoxFisheGender.Controls.Add(this.radioButton1Male);
            this.groupBoxFisheGender.Location = new System.Drawing.Point(20, 149);
            this.groupBoxFisheGender.Name = "groupBoxFisheGender";
            this.groupBoxFisheGender.Size = new System.Drawing.Size(283, 100);
            this.groupBoxFisheGender.TabIndex = 12;
            this.groupBoxFisheGender.TabStop = false;
            this.groupBoxFisheGender.Text = "Choose fish gender";
            // 
            // radioButton2Female
            // 
            this.radioButton2Female.AutoSize = true;
            this.radioButton2Female.Location = new System.Drawing.Point(7, 54);
            this.radioButton2Female.Name = "radioButton2Female";
            this.radioButton2Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton2Female.TabIndex = 1;
            this.radioButton2Female.TabStop = true;
            this.radioButton2Female.Text = "Female";
            this.radioButton2Female.UseVisualStyleBackColor = true;
            // 
            // radioButton1Male
            // 
            this.radioButton1Male.AutoSize = true;
            this.radioButton1Male.Location = new System.Drawing.Point(7, 30);
            this.radioButton1Male.Name = "radioButton1Male";
            this.radioButton1Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton1Male.TabIndex = 0;
            this.radioButton1Male.TabStop = true;
            this.radioButton1Male.Text = "Male";
            this.radioButton1Male.UseVisualStyleBackColor = true;
            // 
            // label6Needlitters
            // 
            this.label6Needlitters.AutoSize = true;
            this.label6Needlitters.Location = new System.Drawing.Point(17, 406);
            this.label6Needlitters.Name = "label6Needlitters";
            this.label6Needlitters.Size = new System.Drawing.Size(104, 13);
            this.label6Needlitters.TabIndex = 11;
            this.label6Needlitters.Text = "Enter needded litters";
            // 
            // textBox6NeedLitters
            // 
            this.textBox6NeedLitters.Location = new System.Drawing.Point(203, 399);
            this.textBox6NeedLitters.Name = "textBox6NeedLitters";
            this.textBox6NeedLitters.Size = new System.Drawing.Size(100, 20);
            this.textBox6NeedLitters.TabIndex = 10;
            this.textBox6NeedLitters.TextChanged += new System.EventHandler(this.textBox6NeedLitters_TextChanged_1);
            // 
            // label5MaxTemp
            // 
            this.label5MaxTemp.AutoSize = true;
            this.label5MaxTemp.Location = new System.Drawing.Point(17, 380);
            this.label5MaxTemp.Name = "label5MaxTemp";
            this.label5MaxTemp.Size = new System.Drawing.Size(162, 13);
            this.label5MaxTemp.TabIndex = 9;
            this.label5MaxTemp.Text = "Enter max temperature in celsius ";
            // 
            // label4MinTemp
            // 
            this.label4MinTemp.AutoSize = true;
            this.label4MinTemp.Location = new System.Drawing.Point(17, 354);
            this.label4MinTemp.Name = "label4MinTemp";
            this.label4MinTemp.Size = new System.Drawing.Size(159, 13);
            this.label4MinTemp.TabIndex = 8;
            this.label4MinTemp.Text = "Enter min temperature in celsius ";
            // 
            // label3SizeInCm
            // 
            this.label3SizeInCm.AutoSize = true;
            this.label3SizeInCm.Location = new System.Drawing.Point(17, 328);
            this.label3SizeInCm.Name = "label3SizeInCm";
            this.label3SizeInCm.Size = new System.Drawing.Size(100, 13);
            this.label3SizeInCm.TabIndex = 7;
            this.label3SizeInCm.Text = "Enter fish size in cm";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Location = new System.Drawing.Point(17, 302);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(80, 13);
            this.label2Name.TabIndex = 6;
            this.label2Name.Text = "Enter fish name";
            // 
            // textBox5MaxTemperature
            // 
            this.textBox5MaxTemperature.Location = new System.Drawing.Point(203, 373);
            this.textBox5MaxTemperature.Name = "textBox5MaxTemperature";
            this.textBox5MaxTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBox5MaxTemperature.TabIndex = 4;
            this.textBox5MaxTemperature.TextChanged += new System.EventHandler(this.textBox5MaxTemperature_TextChanged_1);
            // 
            // textBox4MinTemperature
            // 
            this.textBox4MinTemperature.Location = new System.Drawing.Point(203, 347);
            this.textBox4MinTemperature.Name = "textBox4MinTemperature";
            this.textBox4MinTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBox4MinTemperature.TabIndex = 3;
            this.textBox4MinTemperature.TextChanged += new System.EventHandler(this.textBox4MinTemperature_TextChanged_1);
            // 
            // textBox3Size
            // 
            this.textBox3Size.Location = new System.Drawing.Point(203, 321);
            this.textBox3Size.Name = "textBox3Size";
            this.textBox3Size.Size = new System.Drawing.Size(100, 20);
            this.textBox3Size.TabIndex = 2;
            this.textBox3Size.TextChanged += new System.EventHandler(this.textBox3Size_TextChanged_1);
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(203, 295);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(100, 20);
            this.textBox2Name.TabIndex = 1;
            this.textBox2Name.TextChanged += new System.EventHandler(this.textBox2Name_TextChanged_1);
            // 
            // button1AddFish
            // 
            this.button1AddFish.Location = new System.Drawing.Point(216, 472);
            this.button1AddFish.Name = "button1AddFish";
            this.button1AddFish.Size = new System.Drawing.Size(99, 23);
            this.button1AddFish.TabIndex = 1;
            this.button1AddFish.Text = "Add fish";
            this.button1AddFish.UseVisualStyleBackColor = true;
            this.button1AddFish.Click += new System.EventHandler(this.button1AddFish_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 544);
            this.Controls.Add(this.button1AddFish);
            this.Controls.Add(this.gBoxFishProp);
            this.Name = "FishForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fish";
            this.gBoxFishProp.ResumeLayout(false);
            this.gBoxFishProp.PerformLayout();
            this.groupBox1FishType.ResumeLayout(false);
            this.groupBox1FishType.PerformLayout();
            this.groupBoxFisheGender.ResumeLayout(false);
            this.groupBoxFisheGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFishProp;
        private System.Windows.Forms.GroupBox groupBoxFisheGender;
        private System.Windows.Forms.RadioButton radioButton2Female;
        private System.Windows.Forms.RadioButton radioButton1Male;
        private System.Windows.Forms.Label label6Needlitters;
        private System.Windows.Forms.TextBox textBox6NeedLitters;
        private System.Windows.Forms.Label label5MaxTemp;
        private System.Windows.Forms.Label label4MinTemp;
        private System.Windows.Forms.Label label3SizeInCm;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.TextBox textBox5MaxTemperature;
        private System.Windows.Forms.TextBox textBox4MinTemperature;
        private System.Windows.Forms.TextBox textBox3Size;
        private System.Windows.Forms.TextBox textBox2Name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1AddFish;
        private System.Windows.Forms.GroupBox groupBox1FishType;
        private System.Windows.Forms.RadioButton radioButton4GoldFish;
        private System.Windows.Forms.RadioButton radioButton3Shark;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}