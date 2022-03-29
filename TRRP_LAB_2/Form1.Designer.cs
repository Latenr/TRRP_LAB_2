namespace TRRP_LAB_2
{
    partial class Form1
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
            this.SoketNormalizeButton = new System.Windows.Forms.Button();
            this.SoketGroup = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MQGroup = new System.Windows.Forms.GroupBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.rabbitmqIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MQNormalizeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SoketGroup.SuspendLayout();
            this.MQGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoketNormalizeButton
            // 
            this.SoketNormalizeButton.Location = new System.Drawing.Point(9, 136);
            this.SoketNormalizeButton.Name = "SoketNormalizeButton";
            this.SoketNormalizeButton.Size = new System.Drawing.Size(116, 32);
            this.SoketNormalizeButton.TabIndex = 0;
            this.SoketNormalizeButton.Text = "Нормализовать";
            this.SoketNormalizeButton.UseVisualStyleBackColor = true;
            this.SoketNormalizeButton.Click += new System.EventHandler(this.SoketNormalizeButton_Click);
            // 
            // SoketGroup
            // 
            this.SoketGroup.Controls.Add(this.textBox5);
            this.SoketGroup.Controls.Add(this.textBox4);
            this.SoketGroup.Controls.Add(this.label2);
            this.SoketGroup.Controls.Add(this.label1);
            this.SoketGroup.Controls.Add(this.SoketNormalizeButton);
            this.SoketGroup.Location = new System.Drawing.Point(51, 12);
            this.SoketGroup.Name = "SoketGroup";
            this.SoketGroup.Size = new System.Drawing.Size(135, 176);
            this.SoketGroup.TabIndex = 1;
            this.SoketGroup.TabStop = false;
            this.SoketGroup.Text = "Сокеты";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Порт для подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-адрес сервера";
            // 
            // MQGroup
            // 
            this.MQGroup.Controls.Add(this.passwordBox);
            this.MQGroup.Controls.Add(this.loginBox);
            this.MQGroup.Controls.Add(this.rabbitmqIP);
            this.MQGroup.Controls.Add(this.label5);
            this.MQGroup.Controls.Add(this.label4);
            this.MQGroup.Controls.Add(this.label3);
            this.MQGroup.Controls.Add(this.MQNormalizeButton);
            this.MQGroup.Location = new System.Drawing.Point(219, 12);
            this.MQGroup.Name = "MQGroup";
            this.MQGroup.Size = new System.Drawing.Size(136, 176);
            this.MQGroup.TabIndex = 2;
            this.MQGroup.TabStop = false;
            this.MQGroup.Text = "Очередь сообщений";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(9, 110);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(116, 20);
            this.passwordBox.TabIndex = 6;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(9, 71);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(116, 20);
            this.loginBox.TabIndex = 5;
            // 
            // rabbitmqIP
            // 
            this.rabbitmqIP.Location = new System.Drawing.Point(9, 32);
            this.rabbitmqIP.Name = "rabbitmqIP";
            this.rabbitmqIP.Size = new System.Drawing.Size(116, 20);
            this.rabbitmqIP.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Логин ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP-адрес сервера";
            // 
            // MQNormalizeButton
            // 
            this.MQNormalizeButton.Location = new System.Drawing.Point(9, 136);
            this.MQNormalizeButton.Name = "MQNormalizeButton";
            this.MQNormalizeButton.Size = new System.Drawing.Size(116, 32);
            this.MQNormalizeButton.TabIndex = 0;
            this.MQNormalizeButton.Text = "Нормализовать";
            this.MQNormalizeButton.UseVisualStyleBackColor = true;
            this.MQNormalizeButton.Click += new System.EventHandler(this.MQNormalizeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "C:\\Users\\Latenr\\source\\repos\\TRRP_LAB_2\\TRRP_LAB_2\\database.db";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 215);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MQGroup);
            this.Controls.Add(this.SoketGroup);
            this.Name = "Form1";
            this.Text = "Нормализатор";
            this.SoketGroup.ResumeLayout(false);
            this.SoketGroup.PerformLayout();
            this.MQGroup.ResumeLayout(false);
            this.MQGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SoketNormalizeButton;
        private System.Windows.Forms.GroupBox SoketGroup;
        private System.Windows.Forms.GroupBox MQGroup;
        private System.Windows.Forms.Button MQNormalizeButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox rabbitmqIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

