namespace NewsClient
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordChecker = new System.Windows.Forms.RichTextBox();
            this.loginChecker = new System.Windows.Forms.RichTextBox();
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(29, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordChecker
            // 
            this.passwordChecker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordChecker.ForeColor = System.Drawing.Color.White;
            this.passwordChecker.Location = new System.Drawing.Point(117, 195);
            this.passwordChecker.Name = "passwordChecker";
            this.passwordChecker.Size = new System.Drawing.Size(241, 45);
            this.passwordChecker.TabIndex = 3;
            this.passwordChecker.Text = "";
            // 
            // loginChecker
            // 
            this.loginChecker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginChecker.ForeColor = System.Drawing.Color.White;
            this.loginChecker.Location = new System.Drawing.Point(117, 145);
            this.loginChecker.Name = "loginChecker";
            this.loginChecker.Size = new System.Drawing.Size(241, 44);
            this.loginChecker.TabIndex = 4;
            this.loginChecker.Text = "";
            // 
            // signin
            // 
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.White;
            this.signin.Location = new System.Drawing.Point(18, 255);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(163, 45);
            this.signin.TabIndex = 5;
            this.signin.Text = "SIGN IN";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(195, 255);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(163, 45);
            this.signup.TabIndex = 6;
            this.signup.Text = "SIGN UP";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "©NEWS SUITE 2019";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::NewsClient.Properties.Resources.backgImage;
            this.ClientSize = new System.Drawing.Size(370, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.loginChecker);
            this.Controls.Add(this.passwordChecker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox passwordChecker;
        private System.Windows.Forms.RichTextBox loginChecker;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label label3;
    }
}

