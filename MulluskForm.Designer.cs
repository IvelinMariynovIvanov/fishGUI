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
            this.components = new System.ComponentModel.Container();
            this.groupBox1MulluskProp = new System.Windows.Forms.GroupBox();
            this.groupBox1MulluskType = new System.Windows.Forms.GroupBox();
            this.radioButton3Starfish = new System.Windows.Forms.RadioButton();
            this.radioButton2Snail = new System.Windows.Forms.RadioButton();
            this.radioButton1Octopus = new System.Windows.Forms.RadioButton();
            this.label5Color = new System.Windows.Forms.Label();
            this.label4MaxTemperature = new System.Windows.Forms.Label();
            this.label3MinTemperature = new System.Windows.Forms.Label();
            this.label2SizeInCm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5Color = new System.Windows.Forms.TextBox();
            this.textBox4MaxTemp = new System.Windows.Forms.TextBox();
            this.textBox3MinTemp = new System.Windows.Forms.TextBox();
            this.textBox2Size = new System.Windows.Forms.TextBox();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.button1AddMullusk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1MulluskProp.SuspendLayout();
            this.groupBox1MulluskType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupBox1MulluskProp.Controls.Add(this.textBox5Color);
            this.groupBox1MulluskProp.Controls.Add(this.textBox4MaxTemp);
            this.groupBox1MulluskProp.Controls.Add(this.textBox3MinTemp);
            this.groupBox1MulluskProp.Controls.Add(this.textBox2Size);
            this.groupBox1MulluskProp.Controls.Add(this.textBox1Name);
            this.groupBox1MulluskProp.Location = new System.Drawing.Point(12, 12);
            this.groupBox1MulluskProp.Name = "groupBox1MulluskProp";
            this.groupBox1MulluskProp.Size = new System.Drawing.Size(367, 288);
            this.groupBox1MulluskProp.TabIndex = 0;
            this.groupBox1MulluskProp.TabStop = false;
            this.groupBox1MulluskProp.Text = "Enter mullusk properties";
            // 
            // groupBox1MulluskType
            // 
            this.groupBox1MulluskType.Controls.Add(this.radioButton3Starfish);
            this.groupBox1MulluskType.Controls.Add(this.radioButton2Snail);
            this.groupBox1MulluskType.Controls.Add(this.radioButton1Octopus);
            this.groupBox1MulluskType.Location = new System.Drawing.Point(22, 27);
            this.groupBox1MulluskType.Name = "groupBox1MulluskType";
            this.groupBox1MulluskType.Size = new System.Drawing.Size(297, 100);
            this.groupBox1MulluskType.TabIndex = 10;
            this.groupBox1MulluskType.TabStop = false;
            this.groupBox1MulluskType.Text = "Select mullusk type";
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
            // radioButton1Octopus
            // 
            this.radioButton1Octopus.AutoSize = true;
            this.radioButton1Octopus.Location = new System.Drawing.Point(7, 20);
            this.radioButton1Octopus.Name = "radioButton1Octopus";
            this.radioButton1Octopus.Size = new System.Drawing.Size(65, 17);
            this.radioButton1Octopus.TabIndex = 0;
            this.radioButton1Octopus.TabStop = true;
            this.radioButton1Octopus.Text = "Octopus";
            this.radioButton1Octopus.UseVisualStyleBackColor = true;
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
            // label4MaxTemperature
            // 
            this.label4MaxTemperature.AutoSize = true;
            this.label4MaxTemperature.Location = new System.Drawing.Point(19, 218);
            this.label4MaxTemperature.Name = "label4MaxTemperature";
            this.label4MaxTemperature.Size = new System.Drawing.Size(113, 13);
            this.label4MaxTemperature.TabIndex = 8;
            this.label4MaxTemperature.Text = "Enter max temperature";
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
            // label2SizeInCm
            // 
            this.label2SizeInCm.AutoSize = true;
            this.label2SizeInCm.Location = new System.Drawing.Point(19, 166);
            this.label2SizeInCm.Name = "label2SizeInCm";
            this.label2SizeInCm.Size = new System.Drawing.Size(81, 13);
            this.label2SizeInCm.TabIndex = 6;
            this.label2SizeInCm.Text = "Enter size in cm";
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
            // textBox5Color
            // 
            this.textBox5Color.Location = new System.Drawing.Point(219, 237);
            this.textBox5Color.Name = "textBox5Color";
            this.textBox5Color.Size = new System.Drawing.Size(100, 20);
            this.textBox5Color.TabIndex = 4;
            this.textBox5Color.TextChanged += new System.EventHandler(this.textBox5Color_TextChanged);
            // 
            // textBox4MaxTemp
            // 
            this.textBox4MaxTemp.Location = new System.Drawing.Point(219, 211);
            this.textBox4MaxTemp.Name = "textBox4MaxTemp";
            this.textBox4MaxTemp.Size = new System.Drawing.Size(100, 20);
            this.textBox4MaxTemp.TabIndex = 3;
            this.textBox4MaxTemp.TextChanged += new System.EventHandler(this.textBox4MaxTemp_TextChanged);
            // 
            // textBox3MinTemp
            // 
            this.textBox3MinTemp.Location = new System.Drawing.Point(219, 185);
            this.textBox3MinTemp.Name = "textBox3MinTemp";
            this.textBox3MinTemp.Size = new System.Drawing.Size(100, 20);
            this.textBox3MinTemp.TabIndex = 2;
            this.textBox3MinTemp.TextChanged += new System.EventHandler(this.textBox3MinTemp_TextChanged);
            // 
            // textBox2Size
            // 
            this.textBox2Size.Location = new System.Drawing.Point(219, 159);
            this.textBox2Size.Name = "textBox2Size";
            this.textBox2Size.Size = new System.Drawing.Size(100, 20);
            this.textBox2Size.TabIndex = 1;
            this.textBox2Size.TextChanged += new System.EventHandler(this.textBox2Size_TextChanged);
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(219, 133);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(100, 20);
            this.textBox1Name.TabIndex = 0;
            this.textBox1Name.TextChanged += new System.EventHandler(this.textBox1Name_TextChanged);
            // 
            // button1AddMullusk
            // 
            this.button1AddMullusk.Location = new System.Drawing.Point(231, 317);
            this.button1AddMullusk.Name = "button1AddMullusk";
            this.button1AddMullusk.Size = new System.Drawing.Size(100, 23);
            this.button1AddMullusk.TabIndex = 1;
            this.button1AddMullusk.Text = "Add mullusk";
            this.button1AddMullusk.UseVisualStyleBackColor = true;
            this.button1AddMullusk.Click += new System.EventHandler(this.button1AddMullusk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1MulluskProp;
        private System.Windows.Forms.Label label5Color;
        private System.Windows.Forms.Label label4MaxTemperature;
        private System.Windows.Forms.Label label3MinTemperature;
        private System.Windows.Forms.Label label2SizeInCm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5Color;
        private System.Windows.Forms.TextBox textBox4MaxTemp;
        private System.Windows.Forms.TextBox textBox3MinTemp;
        private System.Windows.Forms.TextBox textBox2Size;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.GroupBox groupBox1MulluskType;
        private System.Windows.Forms.RadioButton radioButton3Starfish;
        private System.Windows.Forms.RadioButton radioButton2Snail;
        private System.Windows.Forms.RadioButton radioButton1Octopus;
        private System.Windows.Forms.Button button1AddMullusk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}