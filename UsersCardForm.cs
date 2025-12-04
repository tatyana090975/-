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
    public partial class UsersCardForm : Form
    {
        public UsersCardForm()
        {
            InitializeComponent();
        }
        //Выход из формы при отказе от создания новой записи
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Сохранение нового логина и пароля в БД
        private void OKBbutton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passTextBox.Text;
            //Ищем совпадения по логину/паролю
            var result = LoginForm.loginPasswordList.Any(t => t.Item2 == login);

            if (result == true)
            {
                MessageBox.Show("Логин занят!");
            }
            else
            {
                DBQueries.SaveLoginCard(login, password);
                this.Close();
            }            
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
