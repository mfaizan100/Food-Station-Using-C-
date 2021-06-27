namespace FOOD_ORDERING_PROJECT
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.Pw = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.Signup1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pw
            // 
            this.Pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pw.Location = new System.Drawing.Point(21, 150);
            this.Pw.Name = "Pw";
            this.Pw.Size = new System.Drawing.Size(100, 17);
            this.Pw.TabIndex = 12;
            this.Pw.Text = "Password";
            this.Pw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(21, 84);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 11;
            this.username.Text = "Username";
            this.username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(155, 150);
            this.textbox2.Name = "textbox2";
            this.textbox2.PasswordChar = '*';
            this.textbox2.Size = new System.Drawing.Size(279, 20);
            this.textbox2.TabIndex = 10;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(155, 84);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(279, 20);
            this.textbox1.TabIndex = 9;
            // 
            // Signup1
            // 
            this.Signup1.Location = new System.Drawing.Point(276, 244);
            this.Signup1.Name = "Signup1";
            this.Signup1.Size = new System.Drawing.Size(158, 50);
            this.Signup1.TabIndex = 21;
            this.Signup1.Text = "Sign-up";
            this.Signup1.UseVisualStyleBackColor = true;
            this.Signup1.Click += new System.EventHandler(this.Signup1_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 336);
            this.Controls.Add(this.Signup1);
            this.Controls.Add(this.Pw);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pw;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button Signup1;
    }
}