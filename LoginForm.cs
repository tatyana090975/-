using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Дипломная_работа
{
    public partial class LoginForm : Form
    {
        //Поле для загрузки данных из базы данных
        internal static List<Tuple<int, string, string>> loginPasswordList {  get; set; }
        public static int userId { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            Load_LoginForm();
        }
        //Загрузка формы (заполнение поля loginPasswordList данными)
        private void Load_LoginForm()
        {
            //Загрузка списка логинов и паролей из базы данных
            loginPasswordList = DBQueries.LoadLoginList().AsEnumerable()
                .Select(row => new Tuple<int, string, string>((int)row[0], row[1].ToString(), row[2].ToString())).ToList();
        }
        //Вход в приложение
        private void OKButton_Click(object sender, EventArgs e)
        {
            //Кнопка "ОК"
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            //Ищем совпадения по логину/паролю
            var result = loginPasswordList.Any(t => t.Item2 == loginUser && t.Item3 == passUser);

            if (result == false)
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
            else
            {
                userId = loginPasswordList.First(t => t.Item2 == loginUser && t.Item3 == passUser).Item1;
                this.Hide();
                GeneralForm generalForm = new GeneralForm();
                generalForm.Show();
            }

        }
        //Выход со страницы (кнопка "Отмена")
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
