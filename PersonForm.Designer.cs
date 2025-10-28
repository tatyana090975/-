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
            this.panel2.Location = new System.Drawing.Point(587, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(105, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteRecordButton);
            this.panel1.Controls.Add(this.createRecordButton);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 80);
            this.panel1.TabIndex = 7;
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRecordButton.Location = new System.Drawing.Point(109, 3);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(180, 29);
            this.deleteRecordButton.TabIndex = 1;
            this.deleteRecordButton.Text = "Удаление записи";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // createRecordButton
            // 
            this.createRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRecordButton.Location = new System.Drawing.Point(3, 3);
            this.createRecordButton.Name = "createRecordButton";
            this.createRecordButton.Size = new System.Drawing.Size(75, 74);
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
            this.tablePanel.Location = new System.Drawing.Point(12, 97);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(776, 297);
            this.tablePanel.TabIndex = 6;
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridViewPerson.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerson.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.Size = new System.Drawing.Size(774, 295);
            this.dataGridViewPerson.TabIndex = 0;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablePanel);
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
    }
}