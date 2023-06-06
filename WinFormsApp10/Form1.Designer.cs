
namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.spelaigen = new System.Windows.Forms.Button();
            this.spelet = new System.Windows.Forms.GroupBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.datortal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaxNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spelet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(306, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "starta spel";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // spelaigen
            // 
            this.spelaigen.Location = new System.Drawing.Point(306, 145);
            this.spelaigen.Name = "spelaigen";
            this.spelaigen.Size = new System.Drawing.Size(75, 22);
            this.spelaigen.TabIndex = 1;
            this.spelaigen.Text = "spela igen";
            this.spelaigen.UseVisualStyleBackColor = true;
            this.spelaigen.Click += new System.EventHandler(this.button2_Click);
            // 
            // spelet
            // 
            this.spelet.Controls.Add(this.btnGuess);
            this.spelet.Controls.Add(this.label4);
            this.spelet.Controls.Add(this.label3);
            this.spelet.Controls.Add(this.lblResult);
            this.spelet.Controls.Add(this.txtGuess);
            this.spelet.Controls.Add(this.datortal);
            this.spelet.Location = new System.Drawing.Point(69, 244);
            this.spelet.Name = "spelet";
            this.spelet.Size = new System.Drawing.Size(616, 165);
            this.spelet.TabIndex = 3;
            this.spelet.TabStop = false;
            this.spelet.Text = "spelet";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(237, 50);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "gissa";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gissa ett tal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "datortal:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(108, 117);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(38, 15);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "label1";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(122, 51);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 23);
            this.txtGuess.TabIndex = 4;
            // 
            // datortal
            // 
            this.datortal.Location = new System.Drawing.Point(122, 22);
            this.datortal.Name = "datortal";
            this.datortal.Size = new System.Drawing.Size(100, 23);
            this.datortal.TabIndex = 5;
            this.datortal.TextChanged += new System.EventHandler(this.datortal_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaxNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(69, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "speldata";
            // 
            // cmbMaxNumber
            // 
            this.cmbMaxNumber.FormattingEnabled = true;
            this.cmbMaxNumber.Location = new System.Drawing.Point(94, 41);
            this.cmbMaxNumber.Name = "cmbMaxNumber";
            this.cmbMaxNumber.Size = new System.Drawing.Size(121, 23);
            this.cmbMaxNumber.TabIndex = 1;
            this.cmbMaxNumber.SelectedIndexChanged += new System.EventHandler(this.cmbMaxNumber_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "störtatalet:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp10.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(288, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spelaigen);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.spelet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.spelet.ResumeLayout(false);
            this.spelet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button spelaigen;
        private System.Windows.Forms.GroupBox spelet;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.TextBox datortal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ComboBox cmbMaxNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

