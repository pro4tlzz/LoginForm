namespace LoginForm
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
            this.txtbox_passWord = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_passWord = new System.Windows.Forms.Label();
            this.txtbox_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_passWord
            // 
            this.txtbox_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_passWord.Location = new System.Drawing.Point(193, 195);
            this.txtbox_passWord.Name = "txtbox_passWord";
            this.txtbox_passWord.PasswordChar = '*';
            this.txtbox_passWord.Size = new System.Drawing.Size(163, 35);
            this.txtbox_passWord.TabIndex = 0;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(55, 142);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(136, 29);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "Username: ";
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(193, 267);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(90, 41);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // lbl_passWord
            // 
            this.lbl_passWord.AutoSize = true;
            this.lbl_passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passWord.Location = new System.Drawing.Point(55, 195);
            this.lbl_passWord.Name = "lbl_passWord";
            this.lbl_passWord.Size = new System.Drawing.Size(132, 29);
            this.lbl_passWord.TabIndex = 3;
            this.lbl_passWord.Text = "Password: ";
            // 
            // txtbox_userName
            // 
            this.txtbox_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_userName.Location = new System.Drawing.Point(193, 142);
            this.txtbox_userName.Name = "txtbox_userName";
            this.txtbox_userName.Size = new System.Drawing.Size(163, 35);
            this.txtbox_userName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login Page";
            // 
            // LoginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(471, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_userName);
            this.Controls.Add(this.lbl_passWord);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.txtbox_passWord);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(487, 428);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_passWord;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_passWord;
        private System.Windows.Forms.TextBox txtbox_userName;
        private System.Windows.Forms.Label label1;
    }
}

