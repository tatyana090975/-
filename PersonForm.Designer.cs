namespace Дипломная_работа
{
    partial class PersonForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.createRecordButton = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Location = new System.Drawing.Point(783, 492);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 49);
            this.panel2.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(140, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 34);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.deleteRecordButton);
            this.panel1.Controls.Add(this.createRecordButton);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 98);
            this.panel1.TabIndex = 7;
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRecordButton.Location = new System.Drawing.Point(145, 4);
            this.deleteRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(240, 36);
            this.deleteRecordButton.TabIndex = 1;
            this.deleteRecordButton.Text = "Удаление записи";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // createRecordButton
            // 
            this.createRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRecordButton.Location = new System.Drawing.Point(4, 4);
            this.createRecordButton.Margin = new System.Windows.Forms.Padding(4);
            this.createRecordButton.Name = "createRecordButton";
            this.createRecordButton.Size = new System.Drawing.Size(100, 91);
            this.createRecordButton.TabIndex = 0;
            this.createRecordButton.Text = "Создать запись";
            this.createRecordButton.UseVisualStyleBackColor = true;
            this.createRecordButton.Click += new System.EventHandler(this.createRecordButton_Click);
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.AutoScroll = true;
            this.tablePanel.AutoSize = true;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel.Controls.Add(this.dataGridViewPerson);
            this.tablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablePanel.Location = new System.Drawing.Point(16, 119);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1034, 365);
            this.tablePanel.TabIndex = 6;
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridViewPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerson.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPerson.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.RowHeadersWidth = 51;
            this.dataGridViewPerson.Size = new System.Drawing.Size(1032, 363);
            this.dataGridViewPerson.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.Location = new System.Drawing.Point(145, 48);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(240, 36);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonForm";
            this.Text = "Персоны";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button createRecordButton;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.Button buttonRefresh;
    }
}