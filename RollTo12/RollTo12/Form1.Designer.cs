namespace RollTo12
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
			this.lblDiceRoll = new System.Windows.Forms.Label();
			this.tbxDice = new System.Windows.Forms.TextBox();
			this.btnRollDice = new System.Windows.Forms.Button();
			this.tbxSum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblGeometric = new System.Windows.Forms.Label();
			this.btnAll = new System.Windows.Forms.Button();
			this.lblAll = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDiceRoll
			// 
			this.lblDiceRoll.AutoSize = true;
			this.lblDiceRoll.Location = new System.Drawing.Point(89, 30);
			this.lblDiceRoll.Name = "lblDiceRoll";
			this.lblDiceRoll.Size = new System.Drawing.Size(153, 34);
			this.lblDiceRoll.TabIndex = 0;
			this.lblDiceRoll.Text = "Write a number over 4 \r\nand below 24:";
			this.lblDiceRoll.Click += new System.EventHandler(this.lblDiceRoll_Click);
			// 
			// tbxDice
			// 
			this.tbxDice.Location = new System.Drawing.Point(320, 27);
			this.tbxDice.Multiline = true;
			this.tbxDice.Name = "tbxDice";
			this.tbxDice.ReadOnly = true;
			this.tbxDice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxDice.Size = new System.Drawing.Size(372, 332);
			this.tbxDice.TabIndex = 3;
			// 
			// btnRollDice
			// 
			this.btnRollDice.Location = new System.Drawing.Point(372, 397);
			this.btnRollDice.Name = "btnRollDice";
			this.btnRollDice.Size = new System.Drawing.Size(241, 73);
			this.btnRollDice.TabIndex = 4;
			this.btnRollDice.TabStop = false;
			this.btnRollDice.Text = "Roll Dice";
			this.btnRollDice.UseVisualStyleBackColor = true;
			this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
			// 
			// tbxSum
			// 
			this.tbxSum.Location = new System.Drawing.Point(117, 67);
			this.tbxSum.Name = "tbxSum";
			this.tbxSum.Size = new System.Drawing.Size(88, 22);
			this.tbxSum.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(346, 362);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Rolls four dices until you get your target number";
			// 
			// lblGeometric
			// 
			this.lblGeometric.AutoSize = true;
			this.lblGeometric.Location = new System.Drawing.Point(48, 103);
			this.lblGeometric.Name = "lblGeometric";
			this.lblGeometric.Size = new System.Drawing.Size(240, 17);
			this.lblGeometric.TabIndex = 7;
			this.lblGeometric.Text = "Sum up all dice rolls on the latest try:";
			// 
			// btnAll
			// 
			this.btnAll.Enabled = false;
			this.btnAll.Location = new System.Drawing.Point(117, 140);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(88, 45);
			this.btnAll.TabIndex = 6;
			this.btnAll.Text = "All";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// lblAll
			// 
			this.lblAll.AutoSize = true;
			this.lblAll.Location = new System.Drawing.Point(135, 212);
			this.lblAll.Name = "lblAll";
			this.lblAll.Size = new System.Drawing.Size(0, 17);
			this.lblAll.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 494);
			this.Controls.Add(this.lblAll);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblGeometric);
			this.Controls.Add(this.tbxSum);
			this.Controls.Add(this.btnRollDice);
			this.Controls.Add(this.tbxDice);
			this.Controls.Add(this.lblDiceRoll);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiceRoll;
        private System.Windows.Forms.TextBox tbxDice;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.TextBox tbxSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeometric;
        private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Label lblAll;
	}
}

