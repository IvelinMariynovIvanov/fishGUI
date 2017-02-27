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
            this.gb1Controlls = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1FishNumber = new System.Windows.Forms.TextBox();
            this.textBox2MolluskNumber = new System.Windows.Forms.TextBox();
            this.label1FishNumber = new System.Windows.Forms.Label();
            this.label2MolluskNumber = new System.Windows.Forms.Label();
            this.gb1Controlls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1Controlls
            // 
            this.gb1Controlls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1Controlls.Controls.Add(this.label2MolluskNumber);
            this.gb1Controlls.Controls.Add(this.label1FishNumber);
            this.gb1Controlls.Controls.Add(this.textBox2MolluskNumber);
            this.gb1Controlls.Controls.Add(this.textBox1FishNumber);
            this.gb1Controlls.Controls.Add(this.button1);
            this.gb1Controlls.Location = new System.Drawing.Point(12, 13);
            this.gb1Controlls.Name = "gb1Controlls";
            this.gb1Controlls.Size = new System.Drawing.Size(190, 170);
            this.gb1Controlls.TabIndex = 0;
            this.gb1Controlls.TabStop = false;
            this.gb1Controlls.Text = "Controlls";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Swim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1FishNumber
            // 
            this.textBox1FishNumber.Location = new System.Drawing.Point(111, 28);
            this.textBox1FishNumber.Name = "textBox1FishNumber";
            this.textBox1FishNumber.Size = new System.Drawing.Size(57, 20);
            this.textBox1FishNumber.TabIndex = 1;
            this.textBox1FishNumber.TextChanged += new System.EventHandler(this.textBox1FishNumber_TextChanged);
            // 
            // textBox2MolluskNumber
            // 
            this.textBox2MolluskNumber.Location = new System.Drawing.Point(111, 55);
            this.textBox2MolluskNumber.Name = "textBox2MolluskNumber";
            this.textBox2MolluskNumber.Size = new System.Drawing.Size(57, 20);
            this.textBox2MolluskNumber.TabIndex = 2;
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
            // label2MolluskNumber
            // 
            this.label2MolluskNumber.AutoSize = true;
            this.label2MolluskNumber.Location = new System.Drawing.Point(7, 61);
            this.label2MolluskNumber.Name = "label2MolluskNumber";
            this.label2MolluskNumber.Size = new System.Drawing.Size(94, 13);
            this.label2MolluskNumber.TabIndex = 4;
            this.label2MolluskNumber.Text = "Number of mollusk";
            // 
            // AquariumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.gb1Controlls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AquariumForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AquariumForm";
            this.gb1Controlls.ResumeLayout(false);
            this.gb1Controlls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1Controlls;
        private System.Windows.Forms.Label label2MolluskNumber;
        private System.Windows.Forms.Label label1FishNumber;
        private System.Windows.Forms.TextBox textBox2MolluskNumber;
        private System.Windows.Forms.TextBox textBox1FishNumber;
        private System.Windows.Forms.Button button1;
    }
}