namespace FOOD_ORDERING_PROJECT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Home = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(284, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(115, 33);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(431, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(115, 33);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(574, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(115, 33);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(408, 399);
            this.Account.Multiline = true;
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(160, 37);
            this.Account.TabIndex = 39;
            this.Account.Text = "Don\'t have an account?";
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.Lavender;
            this.Signup.Location = new System.Drawing.Point(574, 398);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(114, 38);
            this.Signup.TabIndex = 38;
            this.Signup.Text = "Signup";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.MistyRose;
            this.Welcome.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Welcome.Location = new System.Drawing.Point(12, 63);
            this.Welcome.Multiline = true;
            this.Welcome.Name = "Welcome";
            this.Welcome.ReadOnly = true;
            this.Welcome.Size = new System.Drawing.Size(288, 32);
            this.Welcome.TabIndex = 37;
            this.Welcome.Text = "Welcome To Food Station";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 468);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Home);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOOD STATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.TextBox Welcome;
    }
}

