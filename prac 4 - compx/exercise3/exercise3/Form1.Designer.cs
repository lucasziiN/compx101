namespace exercise3
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
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.radioButtonHeads = new System.Windows.Forms.RadioButton();
            this.radioButtonTails = new System.Windows.Forms.RadioButton();
            this.buttonTossCoins = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(644, 52);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxBalance.TabIndex = 0;
            // 
            // textBoxBet
            // 
            this.textBoxBet.Location = new System.Drawing.Point(292, 131);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(100, 20);
            this.textBoxBet.TabIndex = 1;
            // 
            // radioButtonHeads
            // 
            this.radioButtonHeads.AutoSize = true;
            this.radioButtonHeads.Location = new System.Drawing.Point(277, 179);
            this.radioButtonHeads.Name = "radioButtonHeads";
            this.radioButtonHeads.Size = new System.Drawing.Size(56, 17);
            this.radioButtonHeads.TabIndex = 2;
            this.radioButtonHeads.TabStop = true;
            this.radioButtonHeads.Text = "Heads";
            this.radioButtonHeads.UseVisualStyleBackColor = true;
            this.radioButtonHeads.CheckedChanged += new System.EventHandler(this.radioButtonHeads_CheckedChanged);
            // 
            // radioButtonTails
            // 
            this.radioButtonTails.AutoSize = true;
            this.radioButtonTails.Location = new System.Drawing.Point(373, 179);
            this.radioButtonTails.Name = "radioButtonTails";
            this.radioButtonTails.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTails.TabIndex = 3;
            this.radioButtonTails.TabStop = true;
            this.radioButtonTails.Text = "Tails";
            this.radioButtonTails.UseVisualStyleBackColor = true;
            // 
            // buttonTossCoins
            // 
            this.buttonTossCoins.Location = new System.Drawing.Point(258, 261);
            this.buttonTossCoins.Name = "buttonTossCoins";
            this.buttonTossCoins.Size = new System.Drawing.Size(75, 23);
            this.buttonTossCoins.TabIndex = 4;
            this.buttonTossCoins.Text = "Toss Coins";
            this.buttonTossCoins.UseVisualStyleBackColor = true;
            this.buttonTossCoins.Click += new System.EventHandler(this.buttonTossCoins_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(442, 261);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bet amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonTossCoins);
            this.Controls.Add(this.radioButtonTails);
            this.Controls.Add(this.radioButtonHeads);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.textBoxBalance);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.RadioButton radioButtonHeads;
        private System.Windows.Forms.RadioButton radioButtonTails;
        private System.Windows.Forms.Button buttonTossCoins;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

