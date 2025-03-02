namespace Stem_Squad_Gaming_Fanatics2
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.submitBTN = new System.Windows.Forms.Button();
            this.fname_LBL = new System.Windows.Forms.Label();
            this.fnameTXT = new System.Windows.Forms.TextBox();
            this.lnameLBL = new System.Windows.Forms.Label();
            this.lnameTXT = new System.Windows.Forms.TextBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.passLBL = new System.Windows.Forms.Label();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(368, 544);
            this.submitBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(141, 57);
            this.submitBTN.TabIndex = 0;
            this.submitBTN.Text = "submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // fname_LBL
            // 
            this.fname_LBL.AutoSize = true;
            this.fname_LBL.Location = new System.Drawing.Point(98, 335);
            this.fname_LBL.Name = "fname_LBL";
            this.fname_LBL.Size = new System.Drawing.Size(112, 25);
            this.fname_LBL.TabIndex = 1;
            this.fname_LBL.Text = "First Name:";
            // 
            // fnameTXT
            // 
            this.fnameTXT.Location = new System.Drawing.Point(212, 332);
            this.fnameTXT.Name = "fnameTXT";
            this.fnameTXT.Size = new System.Drawing.Size(503, 30);
            this.fnameTXT.TabIndex = 2;
            // 
            // lnameLBL
            // 
            this.lnameLBL.AutoSize = true;
            this.lnameLBL.Location = new System.Drawing.Point(98, 377);
            this.lnameLBL.Name = "lnameLBL";
            this.lnameLBL.Size = new System.Drawing.Size(117, 25);
            this.lnameLBL.TabIndex = 3;
            this.lnameLBL.Text = "Last Name: ";
            // 
            // lnameTXT
            // 
            this.lnameTXT.Location = new System.Drawing.Point(212, 374);
            this.lnameTXT.Name = "lnameTXT";
            this.lnameTXT.Size = new System.Drawing.Size(503, 30);
            this.lnameTXT.TabIndex = 4;
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Location = new System.Drawing.Point(98, 419);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(113, 25);
            this.userLBL.TabIndex = 5;
            this.userLBL.Text = "Username: ";
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(212, 416);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(503, 30);
            this.userTXT.TabIndex = 6;
            // 
            // passLBL
            // 
            this.passLBL.AutoSize = true;
            this.passLBL.Location = new System.Drawing.Point(98, 459);
            this.passLBL.Name = "passLBL";
            this.passLBL.Size = new System.Drawing.Size(109, 25);
            this.passLBL.TabIndex = 7;
            this.passLBL.Text = "Password: ";
            this.passLBL.Click += new System.EventHandler(this.passLBL_Click);
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(212, 456);
            this.passTXT.Name = "passTXT";
            this.passTXT.PasswordChar = '*';
            this.passTXT.Size = new System.Drawing.Size(503, 30);
            this.passTXT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-Mail: ";
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(212, 492);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(503, 30);
            this.emailTXT.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.passLBL);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.userLBL);
            this.Controls.Add(this.lnameTXT);
            this.Controls.Add(this.lnameLBL);
            this.Controls.Add(this.fnameTXT);
            this.Controls.Add(this.fname_LBL);
            this.Controls.Add(this.submitBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewAccount";
            this.Text = "New Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Label fname_LBL;
        private System.Windows.Forms.TextBox fnameTXT;
        private System.Windows.Forms.Label lnameLBL;
        private System.Windows.Forms.TextBox lnameTXT;
        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.Label passLBL;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}