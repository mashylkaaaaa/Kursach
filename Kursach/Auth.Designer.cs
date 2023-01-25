namespace Kursach
{
    partial class Authorithation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorithation_Form));
            this.VhodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.Log_in = new System.Windows.Forms.RichTextBox();
            this.pasword = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // VhodButton
            // 
            this.VhodButton.BackColor = System.Drawing.Color.Azure;
            this.VhodButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VhodButton.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VhodButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VhodButton.Location = new System.Drawing.Point(156, 355);
            this.VhodButton.Name = "VhodButton";
            this.VhodButton.Size = new System.Drawing.Size(108, 43);
            this.VhodButton.TabIndex = 0;
            this.VhodButton.Text = "Вход";
            this.VhodButton.UseVisualStyleBackColor = false;
            this.VhodButton.Click += new System.EventHandler(this.VhodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Azure;
            this.RegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegButton.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(103, 301);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(217, 48);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Log_in
            // 
            this.Log_in.BackColor = System.Drawing.Color.Azure;
            this.Log_in.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_in.Location = new System.Drawing.Point(103, 84);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(217, 43);
            this.Log_in.TabIndex = 6;
            this.Log_in.Text = "";
            this.Log_in.TextChanged += new System.EventHandler(this.Log_in_TextChanged);
            // 
            // pasword
            // 
            this.pasword.BackColor = System.Drawing.Color.Azure;
            this.pasword.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasword.Location = new System.Drawing.Point(103, 195);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(217, 43);
            this.pasword.TabIndex = 7;
            this.pasword.Text = "";
            this.pasword.TextChanged += new System.EventHandler(this.pasword_TextChanged);
            // 
            // Authorithation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 457);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VhodButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Authorithation_Form";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorithation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VhodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.RichTextBox Log_in;
        private System.Windows.Forms.RichTextBox pasword;
    }
}

