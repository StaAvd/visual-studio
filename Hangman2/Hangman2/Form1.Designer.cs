namespace Hangman2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSlutResultat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowLetters = new System.Windows.Forms.Label();
            this.txtGuessTheWord = new System.Windows.Forms.TextBox();
            this.btnGissaHelaOrdet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNyttOrd = new System.Windows.Forms.Button();
            this.txtTheWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnEnglish = new System.Windows.Forms.RadioButton();
            this.rbtnSwedish = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlutResultat
            // 
            this.lblSlutResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlutResultat.Location = new System.Drawing.Point(308, 63);
            this.lblSlutResultat.Name = "lblSlutResultat";
            this.lblSlutResultat.Size = new System.Drawing.Size(372, 23);
            this.lblSlutResultat.TabIndex = 1;
            this.lblSlutResultat.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gissa hela ordet";
            // 
            // lblShowLetters
            // 
            this.lblShowLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowLetters.Location = new System.Drawing.Point(598, 95);
            this.lblShowLetters.Name = "lblShowLetters";
            this.lblShowLetters.Size = new System.Drawing.Size(125, 23);
            this.lblShowLetters.TabIndex = 3;
            this.lblShowLetters.Text = "Bokstäver i ordet:  ";
            // 
            // txtGuessTheWord
            // 
            this.txtGuessTheWord.Location = new System.Drawing.Point(4, 32);
            this.txtGuessTheWord.Name = "txtGuessTheWord";
            this.txtGuessTheWord.Size = new System.Drawing.Size(149, 20);
            this.txtGuessTheWord.TabIndex = 4;
            // 
            // btnGissaHelaOrdet
            // 
            this.btnGissaHelaOrdet.Location = new System.Drawing.Point(6, 58);
            this.btnGissaHelaOrdet.Name = "btnGissaHelaOrdet";
            this.btnGissaHelaOrdet.Size = new System.Drawing.Size(102, 23);
            this.btnGissaHelaOrdet.TabIndex = 5;
            this.btnGissaHelaOrdet.TabStop = false;
            this.btnGissaHelaOrdet.Text = "Gissa hela ordet";
            this.btnGissaHelaOrdet.UseVisualStyleBackColor = true;
            this.btnGissaHelaOrdet.Click += new System.EventHandler(this.btnGissaHelaOrdet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNyttOrd);
            this.groupBox1.Controls.Add(this.txtTheWord);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(308, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 40);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnNyttOrd
            // 
            this.btnNyttOrd.Location = new System.Drawing.Point(209, 11);
            this.btnNyttOrd.Name = "btnNyttOrd";
            this.btnNyttOrd.Size = new System.Drawing.Size(75, 23);
            this.btnNyttOrd.TabIndex = 2;
            this.btnNyttOrd.Text = "Registrera";
            this.btnNyttOrd.UseVisualStyleBackColor = true;
            this.btnNyttOrd.Click += new System.EventHandler(this.btnNyttOrd_Click);
            // 
            // txtTheWord
            // 
            this.txtTheWord.Location = new System.Drawing.Point(103, 13);
            this.txtTheWord.Name = "txtTheWord";
            this.txtTheWord.Size = new System.Drawing.Size(100, 20);
            this.txtTheWord.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skriv ord att gissa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGissa);
            this.groupBox2.Controls.Add(this.txtGuess);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(306, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(5, 58);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 4;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.AcceptsTab = true;
            this.txtGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtGuess.Location = new System.Drawing.Point(5, 32);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(50, 20);
            this.txtGuess.TabIndex = 3;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skriv bokstav";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGissaHelaOrdet);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtGuessTheWord);
            this.groupBox3.Location = new System.Drawing.Point(306, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnEnglish);
            this.groupBox4.Controls.Add(this.rbtnSwedish);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(491, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 71);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Språk";
            // 
            // rbtnEnglish
            // 
            this.rbtnEnglish.AutoSize = true;
            this.rbtnEnglish.Location = new System.Drawing.Point(7, 38);
            this.rbtnEnglish.Name = "rbtnEnglish";
            this.rbtnEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbtnEnglish.TabIndex = 1;
            this.rbtnEnglish.Text = "English";
            this.rbtnEnglish.UseVisualStyleBackColor = true;
            // 
            // rbtnSwedish
            // 
            this.rbtnSwedish.AutoSize = true;
            this.rbtnSwedish.Checked = true;
            this.rbtnSwedish.Location = new System.Drawing.Point(7, 19);
            this.rbtnSwedish.Name = "rbtnSwedish";
            this.rbtnSwedish.Size = new System.Drawing.Size(65, 17);
            this.rbtnSwedish.TabIndex = 0;
            this.rbtnSwedish.TabStop = true;
            this.rbtnSwedish.Text = "Swedish";
            this.rbtnSwedish.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bokstäver i ordet:  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Hangman2.Properties.Resources.Galge;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblShowLetters);
            this.Controls.Add(this.lblSlutResultat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSlutResultat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowLetters;
        private System.Windows.Forms.TextBox txtGuessTheWord;
        private System.Windows.Forms.Button btnGissaHelaOrdet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNyttOrd;
        private System.Windows.Forms.TextBox txtTheWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnEnglish;
        private System.Windows.Forms.RadioButton rbtnSwedish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

