namespace Nilesh_s_Business
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
            this.buttonConcrete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDrivewayLength = new System.Windows.Forms.TextBox();
            this.textBoxDrivewayWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCementRequired = new System.Windows.Forms.TextBox();
            this.textBoxConcreteRequired = new System.Windows.Forms.TextBox();
            this.textBoxBagsRequired = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConcrete
            // 
            this.buttonConcrete.Location = new System.Drawing.Point(329, 106);
            this.buttonConcrete.Name = "buttonConcrete";
            this.buttonConcrete.Size = new System.Drawing.Size(132, 23);
            this.buttonConcrete.TabIndex = 0;
            this.buttonConcrete.Text = "Calculate Concrete Cost";
            this.buttonConcrete.UseVisualStyleBackColor = true;
            this.buttonConcrete.Click += new System.EventHandler(this.buttonConcrete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(488, 386);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(206, 386);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(132, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Driveway Length";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Driveway Width";
            // 
            // textBoxDrivewayLength
            // 
            this.textBoxDrivewayLength.Location = new System.Drawing.Point(228, 62);
            this.textBoxDrivewayLength.Name = "textBoxDrivewayLength";
            this.textBoxDrivewayLength.Size = new System.Drawing.Size(132, 20);
            this.textBoxDrivewayLength.TabIndex = 6;
            // 
            // textBoxDrivewayWidth
            // 
            this.textBoxDrivewayWidth.Location = new System.Drawing.Point(583, 62);
            this.textBoxDrivewayWidth.Name = "textBoxDrivewayWidth";
            this.textBoxDrivewayWidth.Size = new System.Drawing.Size(132, 20);
            this.textBoxDrivewayWidth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volume of Concrete Required";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kilograms of Cement Required";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxCementRequired
            // 
            this.textBoxCementRequired.Location = new System.Drawing.Point(512, 288);
            this.textBoxCementRequired.Name = "textBoxCementRequired";
            this.textBoxCementRequired.Size = new System.Drawing.Size(80, 20);
            this.textBoxCementRequired.TabIndex = 10;
            this.textBoxCementRequired.TextChanged += new System.EventHandler(this.cementRequired_TextChanged);
            // 
            // textBoxConcreteRequired
            // 
            this.textBoxConcreteRequired.Location = new System.Drawing.Point(512, 176);
            this.textBoxConcreteRequired.Name = "textBoxConcreteRequired";
            this.textBoxConcreteRequired.Size = new System.Drawing.Size(80, 20);
            this.textBoxConcreteRequired.TabIndex = 11;
            this.textBoxConcreteRequired.TextChanged += new System.EventHandler(this.concreteRequired_TextChanged);
            // 
            // textBoxBagsRequired
            // 
            this.textBoxBagsRequired.Location = new System.Drawing.Point(512, 216);
            this.textBoxBagsRequired.Name = "textBoxBagsRequired";
            this.textBoxBagsRequired.Size = new System.Drawing.Size(80, 20);
            this.textBoxBagsRequired.TabIndex = 13;
            this.textBoxBagsRequired.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bags of Cement Required";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(512, 332);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(80, 20);
            this.textBoxTotalCost.TabIndex = 15;
            this.textBoxTotalCost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Cost of Cement";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBagsRequired);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxConcreteRequired);
            this.Controls.Add(this.textBoxCementRequired);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDrivewayWidth);
            this.Controls.Add(this.textBoxDrivewayLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConcrete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConcrete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDrivewayLength;
        private System.Windows.Forms.TextBox textBoxDrivewayWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCementRequired;
        private System.Windows.Forms.TextBox textBoxConcreteRequired;
        private System.Windows.Forms.TextBox textBoxBagsRequired;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label label3;
    }
}

