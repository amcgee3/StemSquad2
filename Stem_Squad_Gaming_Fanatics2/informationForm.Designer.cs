namespace Stem_Squad_Gaming_Fanatics2
{
    partial class informationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.name2LBL = new System.Windows.Forms.Label();
            this.userLBL = new System.Windows.Forms.Label();
            this.emailLBL = new System.Windows.Forms.Label();
            this.accessLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(332, 307);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(131, 29);
            this.nameLBL.TabIndex = 1;
            this.nameLBL.Text = "First Name";
            this.nameLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // name2LBL
            // 
            this.name2LBL.AutoSize = true;
            this.name2LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2LBL.Location = new System.Drawing.Point(332, 345);
            this.name2LBL.Name = "name2LBL";
            this.name2LBL.Size = new System.Drawing.Size(128, 29);
            this.name2LBL.TabIndex = 2;
            this.name2LBL.Text = "Last Name";
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLBL.Location = new System.Drawing.Point(332, 384);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(124, 29);
            this.userLBL.TabIndex = 3;
            this.userLBL.Text = "Username";
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLBL.Location = new System.Drawing.Point(332, 422);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(74, 29);
            this.emailLBL.TabIndex = 4;
            this.emailLBL.Text = "Email";
            this.emailLBL.Click += new System.EventHandler(this.emailLBL_Click);
            // 
            // accessLBL
            // 
            this.accessLBL.AutoSize = true;
            this.accessLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLBL.Location = new System.Drawing.Point(332, 460);
            this.accessLBL.Name = "accessLBL";
            this.accessLBL.Size = new System.Drawing.Size(154, 29);
            this.accessLBL.TabIndex = 5;
            this.accessLBL.Text = "Access Level";
            // 
            // informationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 521);
            this.Controls.Add(this.accessLBL);
            this.Controls.Add(this.emailLBL);
            this.Controls.Add(this.userLBL);
            this.Controls.Add(this.name2LBL);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "informationForm";
            this.Text = "informationForm";
            this.Load += new System.EventHandler(this.informationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label nameLBL;
        public System.Windows.Forms.Label name2LBL;
        public System.Windows.Forms.Label userLBL;
        public System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Label accessLBL;
    }
}