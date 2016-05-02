namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pctBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBox1 = new System.Windows.Forms.GroupBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).BeginInit();
            this.gbBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(896, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctBox1
            // 
            this.pctBox1.Location = new System.Drawing.Point(12, 12);
            this.pctBox1.Name = "pctBox1";
            this.pctBox1.Size = new System.Drawing.Size(295, 227);
            this.pctBox1.TabIndex = 1;
            this.pctBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // gbBox1
            // 
            this.gbBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbBox1.Controls.Add(this.btnCount);
            this.gbBox1.Controls.Add(this.label2);
            this.gbBox1.Controls.Add(this.tBox1);
            this.gbBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBox1.Location = new System.Drawing.Point(385, 38);
            this.gbBox1.Name = "gbBox1";
            this.gbBox1.Size = new System.Drawing.Size(455, 140);
            this.gbBox1.TabIndex = 4;
            this.gbBox1.TabStop = false;
            this.gbBox1.Text = "Text för räkna";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(296, 98);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(124, 23);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Count symbols";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "My text";
            // 
            // tBox1
            // 
            this.tBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox1.Location = new System.Drawing.Point(99, 19);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(243, 20);
            this.tBox1.TabIndex = 3;
            this.tBox1.Text = "dh";
            this.tBox1.TextChanged += new System.EventHandler(this.tBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(997, 260);
            this.Controls.Add(this.gbBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "MainForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).EndInit();
            this.gbBox1.ResumeLayout(false);
            this.gbBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.Button btnCount;
    }
}

