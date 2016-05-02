namespace WindowsFormsApplication3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCountSymbols = new System.Windows.Forms.Button();
            this.lblTextBox1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pctBox1 = new System.Windows.Forms.PictureBox();
            this.btnImageChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.btnCountSymbols);
            this.panel1.Controls.Add(this.lblTextBox1);
            this.panel1.Controls.Add(this.txtBox1);
            this.panel1.Location = new System.Drawing.Point(445, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 192);
            this.panel1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(19, 69);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 76);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "0";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnCountSymbols
            // 
            this.btnCountSymbols.Location = new System.Drawing.Point(316, 69);
            this.btnCountSymbols.Name = "btnCountSymbols";
            this.btnCountSymbols.Size = new System.Drawing.Size(121, 23);
            this.btnCountSymbols.TabIndex = 2;
            this.btnCountSymbols.Text = "Count Symbols";
            this.btnCountSymbols.UseVisualStyleBackColor = true;
            this.btnCountSymbols.Click += new System.EventHandler(this.btnCountSymbols_Click);
            // 
            // lblTextBox1
            // 
            this.lblTextBox1.AutoSize = true;
            this.lblTextBox1.Location = new System.Drawing.Point(19, 19);
            this.lblTextBox1.Name = "lblTextBox1";
            this.lblTextBox1.Size = new System.Drawing.Size(113, 13);
            this.lblTextBox1.TabIndex = 1;
            this.lblTextBox1.Text = "Text for count symbols";
            this.lblTextBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(152, 13);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(292, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.Text = "cvnmhjbgg";
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1025, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pctBox1
            // 
            this.pctBox1.Image = global::WindowsFormsApplication3.Properties.Resources.Galge;
            this.pctBox1.InitialImage = global::WindowsFormsApplication3.Properties.Resources.Galge;
            this.pctBox1.Location = new System.Drawing.Point(25, 25);
            this.pctBox1.Name = "pctBox1";
            this.pctBox1.Size = new System.Drawing.Size(372, 282);
            this.pctBox1.TabIndex = 1;
            this.pctBox1.TabStop = false;
            // 
            // btnImageChange
            // 
            this.btnImageChange.Location = new System.Drawing.Point(445, 266);
            this.btnImageChange.Name = "btnImageChange";
            this.btnImageChange.Size = new System.Drawing.Size(75, 23);
            this.btnImageChange.TabIndex = 3;
            this.btnImageChange.Text = "button1";
            this.btnImageChange.UseVisualStyleBackColor = true;
            this.btnImageChange.Click += new System.EventHandler(this.btnImageChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 319);
            this.Controls.Add(this.btnImageChange);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pctBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextBox1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCountSymbols;
        private System.Windows.Forms.PictureBox pctBox1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnImageChange;
    }
}

