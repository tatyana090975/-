namespace Дипломная_работа
{
    partial class UsersCardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.OKBbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.зукыщтДabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.зукыщтДabel);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.passTextBox);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.loginTextBox);
            this.panel1.Location = new System.Drawing.Point(36, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 341);
            this.panel1.TabIndex = 0;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(240, 127);
            this.passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(80, 25);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(221, 167);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(622, 30);
            this.passTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(240, 33);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(68, 25);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(221, 77);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(622, 30);
            this.loginTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.OKBbutton);
            this.panel2.Location = new System.Drawing.Point(656, 468);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 71);
            this.panel2.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(64, 22);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(124, 33);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // OKBbutton
            // 
            this.OKBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBbutton.Location = new System.Drawing.Point(224, 22);
            this.OKBbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKBbutton.Name = "OKBbutton";
            this.OKBbutton.Size = new System.Drawing.Size(124, 33);
            this.OKBbutton.TabIndex = 0;
            this.OKBbutton.Text = "OK";
            this.OKBbutton.UseVisualStyleBackColor = true;
            this.OKBbutton.Click += new System.EventHandler(this.OKBbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(622, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // зукыщтДabel
            // 
            this.зукыщтДabel.AutoSize = true;
            this.зукыщтДabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.зукыщтДabel.Location = new System.Drawing.Point(240, 217);
            this.зукыщтДabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.зукыщтДabel.Name = "зукыщтДabel";
            this.зукыщтДabel.Size = new System.Drawing.Size(90, 25);
            this.зукыщтДabel.TabIndex = 5;
            this.зукыщтДabel.Text = "Персона";
            // 
            // UsersCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersCardForm";
            this.Text = "Карточка пользователя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OKBbutton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label зукыщтДabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}