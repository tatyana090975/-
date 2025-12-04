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
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
            PersonFormFill();
        }
        //Заполнение грида данными
        public void PersonFormFill()
        {
            string tableName = "person";
            dataGridViewPerson.DataSource = DBQueries.LoadGridInForm(tableName);
        }
        //Кнопка "Создать запись"
        private void createRecordButton_Click(object sender, EventArgs e)
        {
            PersonCardForm form = new PersonCardForm();
            form.ShowDialog();
        }
        //Кнопка "Выход"
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GeneralForm generalForm = new GeneralForm();
            generalForm.ShowDialog();
        }
        //Кнопка "Удаление записи"
        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            int currentRow = (int)dataGridViewPerson.CurrentRow.Cells[0].Value;
            int rowIndex = dataGridViewPerson.CurrentRow.Index;
            dataGridViewPerson.Rows.Remove(dataGridViewPerson.Rows[rowIndex]);
            //удаление записи из базы данных
            DBQueries.DeleteRow("person", currentRow);
        }
        //Кнопка "Обновить"
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PersonFormFill();
        }
    }
}
