namespace Kursach
{
    partial class Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.NewLogin = new System.Windows.Forms.RichTextBox();
            this.NewPassword = new System.Windows.Forms.RichTextBox();
            this.reg_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.Transparent;
            this.label_1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_1.Location = new System.Drawing.Point(80, 45);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(110, 37);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Логин";
            this.label_1.Click += new System.EventHandler(this.label_1_Click);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.BackColor = System.Drawing.Color.Transparent;
            this.label_2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_2.Location = new System.Drawing.Point(80, 174);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(126, 37);
            this.label_2.TabIndex = 1;
            this.label_2.Text = "Пароль";
            this.label_2.Click += new System.EventHandler(this.label_2_Click);
            // 
            // NewLogin
            // 
            this.NewLogin.BackColor = System.Drawing.Color.Azure;
            this.NewLogin.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLogin.Location = new System.Drawing.Point(103, 85);
            this.NewLogin.Name = "NewLogin";
            this.NewLogin.Size = new System.Drawing.Size(217, 43);
            this.NewLogin.TabIndex = 2;
            this.NewLogin.Text = "";
            this.NewLogin.TextChanged += new System.EventHandler(this.NewLogin_TextChanged);
            // 
            // NewPassword
            // 
            this.NewPassword.BackColor = System.Drawing.Color.Azure;
            this.NewPassword.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassword.Location = new System.Drawing.Point(103, 214);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(217, 43);
            this.NewPassword.TabIndex = 3;
            this.NewPassword.Text = "";
            this.NewPassword.TextChanged += new System.EventHandler(this.NewPassword_TextChanged);
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.Azure;
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_button.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(49, 327);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(323, 45);
            this.reg_button.TabIndex = 4;
            this.reg_button.Text = "Зарегистрироваться";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 457);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewLogin);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Name = "Reg";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.RichTextBox NewLogin;
        private System.Windows.Forms.RichTextBox NewPassword;
        private System.Windows.Forms.Button reg_button;
    }
}