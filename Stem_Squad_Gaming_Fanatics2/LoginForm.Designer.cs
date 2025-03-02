namespace Stem_Squad_Gaming_Fanatics2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userLBL = new System.Windows.Forms.Label();
            this.passLBL = new System.Windows.Forms.Label();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Location = new System.Drawing.Point(472, 114);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(108, 25);
            this.userLBL.TabIndex = 0;
            this.userLBL.Text = "Username:";
            // 
            // passLBL
            // 
            this.passLBL.AutoSize = true;
            this.passLBL.Location = new System.Drawing.Point(471, 164);
            this.passLBL.Name = "passLBL";
            this.passLBL.Size = new System.Drawing.Size(109, 25);
            this.passLBL.TabIndex = 1;
            this.passLBL.Text = "Password: ";
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(580, 111);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(408, 30);
            this.userTXT.TabIndex = 2;
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(579, 164);
            this.passTXT.Name = "passTXT";
            this.passTXT.PasswordChar = '*';
            this.passTXT.Size = new System.Drawing.Size(408, 30);
            this.passTXT.TabIndex = 3;
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(880, 253);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(107, 34);
            this.closeBTN.TabIndex = 4;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(673, 253);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(107, 34);
            this.loginBTN.TabIndex = 5;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "This is a secured software. Unauthorized access is not permitted.";
            // 
            // newBTN
            // 
            this.newBTN.Location = new System.Drawing.Point(461, 253);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(149, 34);
            this.newBTN.TabIndex = 8;
            this.newBTN.Text = "New Account";
            this.newBTN.UseVisualStyleBackColor = true;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 346);
            this.Controls.Add(this.newBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.passLBL);
            this.Controls.Add(this.userLBL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.Label passLBL;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newBTN;
    }
}

