using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дипломная_работа
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
            PositionFormFill();
        }
        //Запролнение grid данными из таблицы position
        public void PositionFormFill()
        {
            string tableName = "position";
            dataGridViewPosition.DataSource = DBQueries.LoadGridInForm(tableName);
        }

        private void createRecordButton_Click(object sender, EventArgs e)
        {
            PositionCardForm positionCardForm = new PositionCardForm();
            positionCardForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PositionFormFill();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            int currentRow = (int)dataGridViewPosition.CurrentRow.Cells[0].Value;
            int rowIndex = dataGridViewPosition.CurrentRow.Index;
            dataGridViewPosition.Rows.Remove(dataGridViewPosition.Rows[rowIndex]);
            //удаление записи из базы данных
            DBQueries.DeleteRow("position", currentRow);  
        }
    }
}
