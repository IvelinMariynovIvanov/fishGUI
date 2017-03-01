namespace FishGUI
{
    partial class AquariumForm
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
            this.gb1Controlls = new System.Windows.Forms.GroupBox();
            this.button1Stop = new System.Windows.Forms.Button();
            this.label2MolluskNumber = new System.Windows.Forms.Label();
            this.label1FishNumber = new System.Windows.Forms.Label();
            this.textBox2MolluskNumber = new System.Windows.Forms.TextBox();
            this.textBox1FishNumber = new System.Windows.Forms.TextBox();
            this.button1Swim = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1SelectOperaion = new System.Windows.Forms.GroupBox();
            this.btAddFish = new System.Windows.Forms.Button();
            this.button2AddMullusk = new System.Windows.Forms.Button();
            this.gb1Controlls.SuspendLayout();
            this.groupBox1SelectOperaion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1Controlls
            // 
            this.gb1Controlls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1Controlls.Controls.Add(this.button1Stop);
            this.gb1Controlls.Controls.Add(this.label2MolluskNumber);
            this.gb1Controlls.Controls.Add(this.label1FishNumber);
            this.gb1Controlls.Controls.Add(this.textBox2MolluskNumber);
            this.gb1Controlls.Controls.Add(this.textBox1FishNumber);
            this.gb1Controlls.Controls.Add(this.button1Swim);
            this.gb1Controlls.Location = new System.Drawing.Point(12, 12);
            this.gb1Controlls.Name = "gb1Controlls";
            this.gb1Controlls.Size = new System.Drawing.Size(173, 182);
            this.gb1Controlls.TabIndex = 0;
            this.gb1Controlls.TabStop = false;
            this.gb1Controlls.Text = "Controlls";
            // 
            // button1Stop
            // 
            this.button1Stop.Location = new System.Drawing.Point(6, 144);
            this.button1Stop.Name = "button1Stop";
            this.button1Stop.Size = new System.Drawing.Size(161, 23);
            this.button1Stop.TabIndex = 5;
            this.button1Stop.Text = "Stop";
            this.button1Stop.UseVisualStyleBackColor = true;
            this.button1Stop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2MolluskNumber
            // 
            this.label2MolluskNumber.AutoSize = true;
            this.label2MolluskNumber.Location = new System.Drawing.Point(7, 61);
            this.label2MolluskNumber.Name = "label2MolluskNumber";
            this.label2MolluskNumber.Size = new System.Drawing.Size(94, 13);
            this.label2MolluskNumber.TabIndex = 4;
            this.label2MolluskNumber.Text = "Number of mollusk";
            // 
            // label1FishNumber
            // 
            this.label1FishNumber.AutoSize = true;
            this.label1FishNumber.Location = new System.Drawing.Point(7, 34);
            this.label1FishNumber.Name = "label1FishNumber";
            this.label1FishNumber.Size = new System.Drawing.Size(75, 13);
            this.label1FishNumber.TabIndex = 3;
            this.label1FishNumber.Text = "Number of fish";
            // 
            // textBox2MolluskNumber
            // 
            this.textBox2MolluskNumber.Location = new System.Drawing.Point(111, 55);
            this.textBox2MolluskNumber.Name = "textBox2MolluskNumber";
            this.textBox2MolluskNumber.ReadOnly = true;
            this.textBox2MolluskNumber.Size = new System.Drawing.Size(57, 20);
            this.textBox2MolluskNumber.TabIndex = 2;
            // 
            // textBox1FishNumber
            // 
            this.textBox1FishNumber.Location = new System.Drawing.Point(111, 28);
            this.textBox1FishNumber.Name = "textBox1FishNumber";
            this.textBox1FishNumber.ReadOnly = true;
            this.textBox1FishNumber.Size = new System.Drawing.Size(57, 20);
            this.textBox1FishNumber.TabIndex = 1;
            this.textBox1FishNumber.TextChanged += new System.EventHandler(this.textBox1FishNumber_TextChanged);
            // 
            // button1Swim
            // 
            this.button1Swim.Location = new System.Drawing.Point(6, 96);
            this.button1Swim.Name = "button1Swim";
            this.button1Swim.Size = new System.Drawing.Size(162, 23);
            this.button1Swim.TabIndex = 0;
            this.button1Swim.Text = "Swim";
            this.button1Swim.UseVisualStyleBackColor = true;
            this.button1Swim.Click += new System.EventHandler(this.button1Swim_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1SelectOperaion
            // 
            this.groupBox1SelectOperaion.Controls.Add(this.btAddFish);
            this.groupBox1SelectOperaion.Controls.Add(this.button2AddMullusk);
            this.groupBox1SelectOperaion.Location = new System.Drawing.Point(12, 225);
            this.groupBox1SelectOperaion.Name = "groupBox1SelectOperaion";
            this.groupBox1SelectOperaion.Size = new System.Drawing.Size(173, 119);
            this.groupBox1SelectOperaion.TabIndex = 3;
            this.groupBox1SelectOperaion.TabStop = false;
            this.groupBox1SelectOperaion.Text = "Select a operation";
            // 
            // btAddFish
            // 
            this.btAddFish.Location = new System.Drawing.Point(6, 30);
            this.btAddFish.Name = "btAddFish";
            this.btAddFish.Size = new System.Drawing.Size(161, 23);
            this.btAddFish.TabIndex = 0;
            this.btAddFish.Text = "Add Fish";
            this.btAddFish.UseVisualStyleBackColor = true;
            this.btAddFish.Click += new System.EventHandler(this.btAddFish_Click);
            // 
            // button2AddMullusk
            // 
            this.button2AddMullusk.Location = new System.Drawing.Point(6, 71);
            this.button2AddMullusk.Name = "button2AddMullusk";
            this.button2AddMullusk.Size = new System.Drawing.Size(161, 23);
            this.button2AddMullusk.TabIndex = 1;
            this.button2AddMullusk.Text = "Add Mullusk";
            this.button2AddMullusk.UseVisualStyleBackColor = true;
            this.button2AddMullusk.Click += new System.EventHandler(this.button2AddMullusk_Click);
            // 
            // AquariumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox1SelectOperaion);
            this.Controls.Add(this.gb1Controlls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AquariumForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquariumForm";
            this.gb1Controlls.ResumeLayout(false);
            this.gb1Controlls.PerformLayout();
            this.groupBox1SelectOperaion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1Controlls;
        private System.Windows.Forms.Label label2MolluskNumber;
        private System.Windows.Forms.Label label1FishNumber;
        private System.Windows.Forms.TextBox textBox2MolluskNumber;
        private System.Windows.Forms.TextBox textBox1FishNumber;
        private System.Windows.Forms.Button button1Swim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1SelectOperaion;
        private System.Windows.Forms.Button btAddFish;
        private System.Windows.Forms.Button button2AddMullusk;
        private System.Windows.Forms.Button button1Stop;
    }
}