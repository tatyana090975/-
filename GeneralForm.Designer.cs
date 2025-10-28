namespace Дипломная_работа
{
    partial class GeneralForm
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
            this.productReceipt = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buyerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.partnerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.employeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.positionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.personLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.usersLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.purchaseRportLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.salesReportLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stockLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.saleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salesPriceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stockLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameServiceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameProductLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productReceipt
            // 
            this.productReceipt.AutoSize = true;
            this.productReceipt.Location = new System.Drawing.Point(13, 32);
            this.productReceipt.Name = "productReceipt";
            this.productReceipt.Size = new System.Drawing.Size(124, 20);
            this.productReceipt.TabIndex = 0;
            this.productReceipt.TabStop = true;
            this.productReceipt.Text = "Приход товара";
            this.productReceipt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productReceipt_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 504);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buyerLinkLabel);
            this.panel6.Controls.Add(this.partnerLinkLabel);
            this.panel6.Controls.Add(this.employeLinkLabel);
            this.panel6.Controls.Add(this.positionLinkLabel);
            this.panel6.Controls.Add(this.personLinkLabel);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.usersLinkLabel);
            this.panel6.Location = new System.Drawing.Point(417, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 342);
            this.panel6.TabIndex = 4;
            // 
            // buyerLinkLabel
            // 
            this.buyerLinkLabel.AutoSize = true;
            this.buyerLinkLabel.Location = new System.Drawing.Point(13, 265);
            this.buyerLinkLabel.Name = "buyerLinkLabel";
            this.buyerLinkLabel.Size = new System.Drawing.Size(100, 20);
            this.buyerLinkLabel.TabIndex = 5;
            this.buyerLinkLabel.TabStop = true;
            this.buyerLinkLabel.Text = "Покупатели";
            this.buyerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buyerLinkLabel_LinkClicked);
            // 
            // partnerLinkLabel
            // 
            this.partnerLinkLabel.AutoSize = true;
            this.partnerLinkLabel.Location = new System.Drawing.Point(13, 215);
            this.partnerLinkLabel.Name = "partnerLinkLabel";
            this.partnerLinkLabel.Size = new System.Drawing.Size(109, 20);
            this.partnerLinkLabel.TabIndex = 4;
            this.partnerLinkLabel.TabStop = true;
            this.partnerLinkLabel.Text = "Контрагенты";
            this.partnerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.partnerLinkLabel_LinkClicked);
            // 
            // employeLinkLabel
            // 
            this.employeLinkLabel.AutoSize = true;
            this.employeLinkLabel.Location = new System.Drawing.Point(13, 165);
            this.employeLinkLabel.Name = "employeLinkLabel";
            this.employeLinkLabel.Size = new System.Drawing.Size(90, 20);
            this.employeLinkLabel.TabIndex = 3;
            this.employeLinkLabel.TabStop = true;
            this.employeLinkLabel.Text = "Работники";
            this.employeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.employeLinkLabel_LinkClicked);
            // 
            // positionLinkLabel
            // 
            this.positionLinkLabel.AutoSize = true;
            this.positionLinkLabel.Location = new System.Drawing.Point(13, 120);
            this.positionLinkLabel.Name = "positionLinkLabel";
            this.positionLinkLabel.Size = new System.Drawing.Size(95, 20);
            this.positionLinkLabel.TabIndex = 2;
            this.positionLinkLabel.TabStop = true;
            this.positionLinkLabel.Text = "Должности";
            this.positionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.positionLinkLabel_LinkClicked);
            // 
            // personLinkLabel
            // 
            this.personLinkLabel.AutoSize = true;
            this.personLinkLabel.Location = new System.Drawing.Point(13, 77);
            this.personLinkLabel.Name = "personLinkLabel";
            this.personLinkLabel.Size = new System.Drawing.Size(76, 20);
            this.personLinkLabel.TabIndex = 1;
            this.personLinkLabel.TabStop = true;
            this.personLinkLabel.Text = "Персоны";
            this.personLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.personLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вспомогательные справочники";
            // 
            // usersLinkLabel
            // 
            this.usersLinkLabel.AutoSize = true;
            this.usersLinkLabel.Location = new System.Drawing.Point(13, 32);
            this.usersLinkLabel.Name = "usersLinkLabel";
            this.usersLinkLabel.Size = new System.Drawing.Size(121, 20);
            this.usersLinkLabel.TabIndex = 0;
            this.usersLinkLabel.TabStop = true;
            this.usersLinkLabel.Text = "Пользователи";
            this.usersLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usersLinkLabel_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.purchaseRportLinkLabel);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.salesReportLinkLabel);
            this.panel5.Location = new System.Drawing.Point(417, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 109);
            this.panel5.TabIndex = 3;
            // 
            // purchaseRportLinkLabel
            // 
            this.purchaseRportLinkLabel.AutoSize = true;
            this.purchaseRportLinkLabel.Location = new System.Drawing.Point(13, 80);
            this.purchaseRportLinkLabel.Name = "purchaseRportLinkLabel";
            this.purchaseRportLinkLabel.Size = new System.Drawing.Size(152, 20);
            this.purchaseRportLinkLabel.TabIndex = 3;
            this.purchaseRportLinkLabel.TabStop = true;
            this.purchaseRportLinkLabel.Text = "Отчет по закупкам";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Отчеты для руководителя";
            // 
            // salesReportLinkLabel
            // 
            this.salesReportLinkLabel.AutoSize = true;
            this.salesReportLinkLabel.Location = new System.Drawing.Point(13, 32);
            this.salesReportLinkLabel.Name = "salesReportLinkLabel";
            this.salesReportLinkLabel.Size = new System.Drawing.Size(161, 20);
            this.salesReportLinkLabel.TabIndex = 0;
            this.salesReportLinkLabel.TabStop = true;
            this.salesReportLinkLabel.Text = "Отчет по продажам";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.stockLinkLabel1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.saleLinkLabel);
            this.panel4.Location = new System.Drawing.Point(20, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 109);
            this.panel4.TabIndex = 2;
            // 
            // stockLinkLabel1
            // 
            this.stockLinkLabel1.AutoSize = true;
            this.stockLinkLabel1.Location = new System.Drawing.Point(13, 80);
            this.stockLinkLabel1.Name = "stockLinkLabel1";
            this.stockLinkLabel1.Size = new System.Drawing.Size(146, 20);
            this.stockLinkLabel1.TabIndex = 3;
            this.stockLinkLabel1.TabStop = true;
            this.stockLinkLabel1.Text = "Товары на складе";
            this.stockLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stockLinkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Продажи";
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(13, 32);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(137, 20);
            this.saleLinkLabel.TabIndex = 0;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Продажа товара";
            this.saleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saleLinkLabel_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.salesPriceLinkLabel);
            this.panel3.Controls.Add(this.stockLinkLabel);
            this.panel3.Controls.Add(this.nameServiceLinkLabel);
            this.panel3.Controls.Add(this.nameProductLinkLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.productReceipt);
            this.panel3.Location = new System.Drawing.Point(13, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 267);
            this.panel3.TabIndex = 1;
            // 
            // salesPriceLinkLabel
            // 
            this.salesPriceLinkLabel.AutoSize = true;
            this.salesPriceLinkLabel.Location = new System.Drawing.Point(13, 214);
            this.salesPriceLinkLabel.Name = "salesPriceLinkLabel";
            this.salesPriceLinkLabel.Size = new System.Drawing.Size(141, 20);
            this.salesPriceLinkLabel.TabIndex = 4;
            this.salesPriceLinkLabel.TabStop = true;
            this.salesPriceLinkLabel.Text = "Продажные цены";
            this.salesPriceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.salesPriceLinkLabel_LinkClicked);
            // 
            // stockLinkLabel
            // 
            this.stockLinkLabel.AutoSize = true;
            this.stockLinkLabel.Location = new System.Drawing.Point(13, 169);
            this.stockLinkLabel.Name = "stockLinkLabel";
            this.stockLinkLabel.Size = new System.Drawing.Size(146, 20);
            this.stockLinkLabel.TabIndex = 3;
            this.stockLinkLabel.TabStop = true;
            this.stockLinkLabel.Text = "Товары на складе";
            this.stockLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.stockLinkLabel_LinkClicked);
            // 
            // nameServiceLinkLabel
            // 
            this.nameServiceLinkLabel.AutoSize = true;
            this.nameServiceLinkLabel.Location = new System.Drawing.Point(13, 120);
            this.nameServiceLinkLabel.Name = "nameServiceLinkLabel";
            this.nameServiceLinkLabel.Size = new System.Drawing.Size(165, 20);
            this.nameServiceLinkLabel.TabIndex = 2;
            this.nameServiceLinkLabel.TabStop = true;
            this.nameServiceLinkLabel.Text = "Наименование услуг";
            this.nameServiceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nameServiceLinkLabel_LinkClicked);
            // 
            // nameProductLinkLabel
            // 
            this.nameProductLinkLabel.AutoSize = true;
            this.nameProductLinkLabel.Location = new System.Drawing.Point(13, 77);
            this.nameProductLinkLabel.Name = "nameProductLinkLabel";
            this.nameProductLinkLabel.Size = new System.Drawing.Size(189, 20);
            this.nameProductLinkLabel.TabIndex = 1;
            this.nameProductLinkLabel.TabStop = true;
            this.nameProductLinkLabel.Text = "Наименование товаров";
            this.nameProductLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nameProductLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поступление товаров";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Location = new System.Drawing.Point(636, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 56);
            this.panel2.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(127, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeneralForm";
            this.Text = "Главная страница";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel productReceipt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel nameServiceLinkLabel;
        private System.Windows.Forms.LinkLabel nameProductLinkLabel;
        private System.Windows.Forms.LinkLabel stockLinkLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel purchaseRportLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel salesReportLinkLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel stockLinkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel employeLinkLabel;
        private System.Windows.Forms.LinkLabel positionLinkLabel;
        private System.Windows.Forms.LinkLabel personLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel usersLinkLabel;
        private System.Windows.Forms.LinkLabel salesPriceLinkLabel;
        private System.Windows.Forms.LinkLabel buyerLinkLabel;
        private System.Windows.Forms.LinkLabel partnerLinkLabel;
        private System.Windows.Forms.Button closeButton;
    }
}

