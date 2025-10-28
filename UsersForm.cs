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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        //Кнопка "Создать запись"
        private void createRecordButton_Click(object sender, EventArgs e)
        {
            UsersCardForm usersCardForm = new UsersCardForm();
            usersCardForm.ShowDialog();
        }
        //Кнопка "Выход"
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GeneralForm generalForm = new GeneralForm();
            generalForm.ShowDialog();
        }
    }
}
