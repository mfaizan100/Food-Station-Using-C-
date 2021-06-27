namespace FOOD_ORDERING_PROJECT
{
    partial class Login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm));
            this.login_button = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.Pw_label = new System.Windows.Forms.Label();
            this.ext_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(205, 288);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(98, 32);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(141, 93);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(140, 20);
            this.textbox1.TabIndex = 5;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(141, 160);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.PasswordChar = '*';
            this.textbox2.Size = new System.Drawing.Size(140, 20);
            this.textbox2.TabIndex = 6;
            // 
            // username_label
            // 
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(26, 93);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(100, 20);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pw_label
            // 
            this.Pw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pw_label.Location = new System.Drawing.Point(32, 163);
            this.Pw_label.Name = "Pw_label";
            this.Pw_label.Size = new System.Drawing.Size(94, 17);
            this.Pw_label.TabIndex = 1;
            this.Pw_label.Text = "Password";
            this.Pw_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ext_button
            // 
            this.ext_button.Location = new System.Drawing.Point(47, 288);
            this.ext_button.Name = "ext_button";
            this.ext_button.Size = new System.Drawing.Size(98, 32);
            this.ext_button.TabIndex = 7;
            this.ext_button.Text = "Exit";
            this.ext_button.UseVisualStyleBackColor = true;
            this.ext_button.Click += new System.EventHandler(this.ext_button_Click);
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(385, 378);
            this.Controls.Add(this.ext_button);
            this.Controls.Add(this.Pw_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.login_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Pw_label;
        private System.Windows.Forms.Button ext_button;
        public System.Windows.Forms.Label username_label;
    }
}