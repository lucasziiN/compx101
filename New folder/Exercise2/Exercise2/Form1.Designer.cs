namespace Exercise2
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
            this.buttonDrawSquare = new System.Windows.Forms.Button();
            this.buttonDrawTriangle = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawSquare
            // 
            this.buttonDrawSquare.Location = new System.Drawing.Point(444, 329);
            this.buttonDrawSquare.Name = "buttonDrawSquare";
            this.buttonDrawSquare.Size = new System.Drawing.Size(92, 34);
            this.buttonDrawSquare.TabIndex = 1;
            this.buttonDrawSquare.Text = "Draw Square";
            this.buttonDrawSquare.UseVisualStyleBackColor = true;
            this.buttonDrawSquare.Click += new System.EventHandler(this.buttonDrawSquare_Click);
            // 
            // buttonDrawTriangle
            // 
            this.buttonDrawTriangle.Location = new System.Drawing.Point(154, 329);
            this.buttonDrawTriangle.Name = "buttonDrawTriangle";
            this.buttonDrawTriangle.Size = new System.Drawing.Size(98, 34);
            this.buttonDrawTriangle.TabIndex = 2;
            this.buttonDrawTriangle.Text = "Draw Triangle";
            this.buttonDrawTriangle.UseVisualStyleBackColor = true;
            this.buttonDrawTriangle.Click += new System.EventHandler(this.buttonDrawTriangle_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(296, 329);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(97, 34);
            this.buttonErase.TabIndex = 3;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 203);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonDrawTriangle);
            this.Controls.Add(this.buttonDrawSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDrawSquare;
        private System.Windows.Forms.Button buttonDrawTriangle;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

