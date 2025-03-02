namespace Stem_Squad_Gaming_Fanatics2
{
    partial class securityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(securityForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.passLBL = new System.Windows.Forms.Label();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Location = new System.Drawing.Point(110, 276);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(113, 25);
            this.userLBL.TabIndex = 1;
            this.userLBL.Text = "Username: ";
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(217, 273);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(413, 30);
            this.userTXT.TabIndex = 2;
            // 
            // passLBL
            // 
            this.passLBL.AutoSize = true;
            this.passLBL.Location = new System.Drawing.Point(110, 323);
            this.passLBL.Name = "passLBL";
            this.passLBL.Size = new System.Drawing.Size(109, 25);
            this.passLBL.TabIndex = 3;
            this.passLBL.Text = "Password: ";
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(217, 320);
            this.passTXT.Name = "passTXT";
            this.passTXT.PasswordChar = '*';
            this.passTXT.Size = new System.Drawing.Size(413, 30);
            this.passTXT.TabIndex = 4;
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(328, 370);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(134, 43);
            this.submitBTN.TabIndex = 5;
            this.submitBTN.Text = "submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // securityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 428);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.passLBL);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.userLBL);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "securityForm";
            this.Text = "STOP! Verification Needed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLBL;
        public System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.Label passLBL;
        public System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Button submitBTN;
    }
}