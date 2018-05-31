namespace LoginForm
{
    partial class Login
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
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txtbox_userName = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_passWord = new System.Windows.Forms.Label();
            this.txtbox_passWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(12, 65);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(182, 37);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username: ";
            // 
            // txtbox_userName
            // 
            this.txtbox_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_userName.Location = new System.Drawing.Point(211, 65);
            this.txtbox_userName.Name = "txtbox_userName";
            this.txtbox_userName.Size = new System.Drawing.Size(215, 38);
            this.txtbox_userName.TabIndex = 1;
            //this.txtbox_userName.TextChanged += new System.EventHandler(this.txtbox_userName_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(164, 248);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(96, 43);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_passWord
            // 
            this.lbl_passWord.AutoSize = true;
            this.lbl_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passWord.Location = new System.Drawing.Point(12, 149);
            this.lbl_passWord.Name = "lbl_passWord";
            this.lbl_passWord.Size = new System.Drawing.Size(167, 37);
            this.lbl_passWord.TabIndex = 3;
            this.lbl_passWord.Text = "Password:";
            // 
            // txtbox_passWord
            // 
            this.txtbox_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_passWord.Location = new System.Drawing.Point(211, 149);
            this.txtbox_passWord.Name = "txtbox_passWord";
            this.txtbox_passWord.PasswordChar = '*';
            this.txtbox_passWord.Size = new System.Drawing.Size(215, 38);
            this.txtbox_passWord.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(438, 364);
            this.Controls.Add(this.txtbox_passWord);
            this.Controls.Add(this.lbl_passWord);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtbox_userName);
            this.Controls.Add(this.lbl_userName);
            this.Name = "Login";
            this.Text = "Login";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txtbox_userName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_passWord;
        private System.Windows.Forms.TextBox txtbox_passWord;
    }
}

