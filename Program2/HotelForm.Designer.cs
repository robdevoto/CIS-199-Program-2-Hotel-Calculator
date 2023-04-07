namespace Program2
{
    partial class HotelForm
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
            this.guestsLbl = new System.Windows.Forms.Label();
            this.nightsLbl = new System.Windows.Forms.Label();
            this.starsLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.guestsTxt = new System.Windows.Forms.TextBox();
            this.nightsTxt = new System.Windows.Forms.TextBox();
            this.starsCombo = new System.Windows.Forms.ComboBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.costOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guestsLbl
            // 
            this.guestsLbl.AutoSize = true;
            this.guestsLbl.Location = new System.Drawing.Point(146, 83);
            this.guestsLbl.Name = "guestsLbl";
            this.guestsLbl.Size = new System.Drawing.Size(117, 16);
            this.guestsLbl.TabIndex = 0;
            this.guestsLbl.Text = "Number of Guests:";
            // 
            // nightsLbl
            // 
            this.nightsLbl.AutoSize = true;
            this.nightsLbl.Location = new System.Drawing.Point(149, 133);
            this.nightsLbl.Name = "nightsLbl";
            this.nightsLbl.Size = new System.Drawing.Size(113, 16);
            this.nightsLbl.TabIndex = 1;
            this.nightsLbl.Text = "Number of Nights:";
            // 
            // starsLbl
            // 
            this.starsLbl.AutoSize = true;
            this.starsLbl.Location = new System.Drawing.Point(149, 192);
            this.starsLbl.Name = "starsLbl";
            this.starsLbl.Size = new System.Drawing.Size(76, 16);
            this.starsLbl.TabIndex = 2;
            this.starsLbl.Text = "Hotel Stars:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(146, 331);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(69, 16);
            this.costLbl.TabIndex = 3;
            this.costLbl.Text = "Hotel Cost";
            // 
            // guestsTxt
            // 
            this.guestsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestsTxt.Location = new System.Drawing.Point(287, 83);
            this.guestsTxt.Name = "guestsTxt";
            this.guestsTxt.Size = new System.Drawing.Size(100, 22);
            this.guestsTxt.TabIndex = 4;
            // 
            // nightsTxt
            // 
            this.nightsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nightsTxt.Location = new System.Drawing.Point(287, 145);
            this.nightsTxt.Name = "nightsTxt";
            this.nightsTxt.Size = new System.Drawing.Size(100, 22);
            this.nightsTxt.TabIndex = 5;
            // 
            // starsCombo
            // 
            this.starsCombo.FormattingEnabled = true;
            this.starsCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.starsCombo.Location = new System.Drawing.Point(287, 202);
            this.starsCombo.Name = "starsCombo";
            this.starsCombo.Size = new System.Drawing.Size(121, 24);
            this.starsCombo.TabIndex = 6;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(287, 260);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(84, 32);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // costOutputLbl
            // 
            this.costOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOutputLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.costOutputLbl.Location = new System.Drawing.Point(287, 331);
            this.costOutputLbl.Name = "costOutputLbl";
            this.costOutputLbl.Size = new System.Drawing.Size(100, 24);
            this.costOutputLbl.TabIndex = 8;
            // 
            // HotelForm
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costOutputLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.starsCombo);
            this.Controls.Add(this.nightsTxt);
            this.Controls.Add(this.guestsTxt);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.starsLbl);
            this.Controls.Add(this.nightsLbl);
            this.Controls.Add(this.guestsLbl);
            this.Name = "HotelForm";
            this.Text = "Program 2 - Hotel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guestsLbl;
        private System.Windows.Forms.Label nightsLbl;
        private System.Windows.Forms.Label starsLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.TextBox guestsTxt;
        private System.Windows.Forms.TextBox nightsTxt;
        private System.Windows.Forms.ComboBox starsCombo;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label costOutputLbl;
    }
}

