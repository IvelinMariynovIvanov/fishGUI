namespace FishGUI
{
    partial class MulluskForm
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
            this.groupBox1MulluskProp = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2SizeInCm = new System.Windows.Forms.Label();
            this.label3MinTemperature = new System.Windows.Forms.Label();
            this.label4MaxTemperature = new System.Windows.Forms.Label();
            this.label5Color = new System.Windows.Forms.Label();
            this.groupBox1MulluskType = new System.Windows.Forms.GroupBox();
            this.rb1Octopus = new System.Windows.Forms.RadioButton();
            this.radioButton2Snail = new System.Windows.Forms.RadioButton();
            this.radioButton3Starfish = new System.Windows.Forms.RadioButton();
            this.button1AddMullusk = new System.Windows.Forms.Button();
            this.groupBox1MulluskProp.SuspendLayout();
            this.groupBox1MulluskType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1MulluskProp
            // 
            this.groupBox1MulluskProp.Controls.Add(this.groupBox1MulluskType);
            this.groupBox1MulluskProp.Controls.Add(this.label5Color);
            this.groupBox1MulluskProp.Controls.Add(this.label4MaxTemperature);
            this.groupBox1MulluskProp.Controls.Add(this.label3MinTemperature);
            this.groupBox1MulluskProp.Controls.Add(this.label2SizeInCm);
            this.groupBox1MulluskProp.Controls.Add(this.label1);
            this.groupBox1MulluskProp.Controls.Add(this.textBox5);
            this.groupBox1MulluskProp.Controls.Add(this.textBox4);
            this.groupBox1MulluskProp.Controls.Add(this.textBox3);
            this.groupBox1MulluskProp.Controls.Add(this.textBox2);
            this.groupBox1MulluskProp.Controls.Add(this.textBox1);
            this.groupBox1MulluskProp.Location = new System.Drawing.Point(12, 12);
            this.groupBox1MulluskProp.Name = "groupBox1MulluskProp";
            this.groupBox1MulluskProp.Size = new System.Drawing.Size(367, 288);
            this.groupBox1MulluskProp.TabIndex = 0;
            this.groupBox1MulluskProp.TabStop = false;
            this.groupBox1MulluskProp.Text = "Enter mullusk properties";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(219, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(219, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(219, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter name";
            // 
            // label2SizeInCm
            // 
            this.label2SizeInCm.AutoSize = true;
            this.label2SizeInCm.Location = new System.Drawing.Point(19, 166);
            this.label2SizeInCm.Name = "label2SizeInCm";
            this.label2SizeInCm.Size = new System.Drawing.Size(81, 13);
            this.label2SizeInCm.TabIndex = 6;
            this.label2SizeInCm.Text = "Enter size in cm";
            // 
            // label3MinTemperature
            // 
            this.label3MinTemperature.AutoSize = true;
            this.label3MinTemperature.Location = new System.Drawing.Point(19, 192);
            this.label3MinTemperature.Name = "label3MinTemperature";
            this.label3MinTemperature.Size = new System.Drawing.Size(159, 13);
            this.label3MinTemperature.TabIndex = 7;
            this.label3MinTemperature.Text = "Enter min temperature in celsius ";
            // 
            // label4MaxTemperature
            // 
            this.label4MaxTemperature.AutoSize = true;
            this.label4MaxTemperature.Location = new System.Drawing.Point(19, 218);
            this.label4MaxTemperature.Name = "label4MaxTemperature";
            this.label4MaxTemperature.Size = new System.Drawing.Size(113, 13);
            this.label4MaxTemperature.TabIndex = 8;
            this.label4MaxTemperature.Text = "Enter max temperature";
            // 
            // label5Color
            // 
            this.label5Color.AutoSize = true;
            this.label5Color.Location = new System.Drawing.Point(19, 244);
            this.label5Color.Name = "label5Color";
            this.label5Color.Size = new System.Drawing.Size(58, 13);
            this.label5Color.TabIndex = 9;
            this.label5Color.Text = "Enter color";
            // 
            // groupBox1MulluskType
            // 
            this.groupBox1MulluskType.Controls.Add(this.radioButton3Starfish);
            this.groupBox1MulluskType.Controls.Add(this.radioButton2Snail);
            this.groupBox1MulluskType.Controls.Add(this.rb1Octopus);
            this.groupBox1MulluskType.Location = new System.Drawing.Point(22, 27);
            this.groupBox1MulluskType.Name = "groupBox1MulluskType";
            this.groupBox1MulluskType.Size = new System.Drawing.Size(297, 100);
            this.groupBox1MulluskType.TabIndex = 10;
            this.groupBox1MulluskType.TabStop = false;
            this.groupBox1MulluskType.Text = "Select mullusk type";
            // 
            // rb1Octopus
            // 
            this.rb1Octopus.AutoSize = true;
            this.rb1Octopus.Location = new System.Drawing.Point(7, 20);
            this.rb1Octopus.Name = "rb1Octopus";
            this.rb1Octopus.Size = new System.Drawing.Size(65, 17);
            this.rb1Octopus.TabIndex = 0;
            this.rb1Octopus.TabStop = true;
            this.rb1Octopus.Text = "Octopus";
            this.rb1Octopus.UseVisualStyleBackColor = true;
            // 
            // radioButton2Snail
            // 
            this.radioButton2Snail.AutoSize = true;
            this.radioButton2Snail.Location = new System.Drawing.Point(7, 43);
            this.radioButton2Snail.Name = "radioButton2Snail";
            this.radioButton2Snail.Size = new System.Drawing.Size(48, 17);
            this.radioButton2Snail.TabIndex = 1;
            this.radioButton2Snail.TabStop = true;
            this.radioButton2Snail.Text = "Snail";
            this.radioButton2Snail.UseVisualStyleBackColor = true;
            // 
            // radioButton3Starfish
            // 
            this.radioButton3Starfish.AutoSize = true;
            this.radioButton3Starfish.Location = new System.Drawing.Point(7, 66);
            this.radioButton3Starfish.Name = "radioButton3Starfish";
            this.radioButton3Starfish.Size = new System.Drawing.Size(60, 17);
            this.radioButton3Starfish.TabIndex = 2;
            this.radioButton3Starfish.TabStop = true;
            this.radioButton3Starfish.Text = "Starfish";
            this.radioButton3Starfish.UseVisualStyleBackColor = true;
            // 
            // button1AddMullusk
            // 
            this.button1AddMullusk.Location = new System.Drawing.Point(231, 317);
            this.button1AddMullusk.Name = "button1AddMullusk";
            this.button1AddMullusk.Size = new System.Drawing.Size(100, 23);
            this.button1AddMullusk.TabIndex = 1;
            this.button1AddMullusk.Text = "Add mullusk";
            this.button1AddMullusk.UseVisualStyleBackColor = true;
            // 
            // MulluskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 392);
            this.Controls.Add(this.button1AddMullusk);
            this.Controls.Add(this.groupBox1MulluskProp);
            this.Name = "MulluskForm";
            this.Text = "MulluskForm";
            this.groupBox1MulluskProp.ResumeLayout(false);
            this.groupBox1MulluskProp.PerformLayout();
            this.groupBox1MulluskType.ResumeLayout(false);
            this.groupBox1MulluskType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1MulluskProp;
        private System.Windows.Forms.Label label5Color;
        private System.Windows.Forms.Label label4MaxTemperature;
        private System.Windows.Forms.Label label3MinTemperature;
        private System.Windows.Forms.Label label2SizeInCm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1MulluskType;
        private System.Windows.Forms.RadioButton radioButton3Starfish;
        private System.Windows.Forms.RadioButton radioButton2Snail;
        private System.Windows.Forms.RadioButton rb1Octopus;
        private System.Windows.Forms.Button button1AddMullusk;
    }
}