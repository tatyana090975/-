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
    public partial class PersonCardForm : Form
    {
        //Поле для загрузки данных из базы данных
        internal static List<Tuple<int, string, string>> loginPasswordList { get; set; }
        public PersonCardForm()
        {
            InitializeComponent();
            Load_PersonCardForm();
        }
        //Загрузка формы (заполнение поля loginPasswordList данными)
        private void Load_PersonCardForm()
        {
            //Загрузка списка логинов и паролей из базы данных
            loginPasswordList = DBQueries.LoadLoginList().AsEnumerable()
                .Select(row => new Tuple<int, string, string>((int)row[0], row[1].ToString(), row[2].ToString())).ToList();
            usersComboBox.DataSource = loginPasswordList;
            usersComboBox.DisplayMember = "Item2";
            usersComboBox.ValueMember = "Item1";
            usersComboBox.SelectedIndex = -1;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String secondname = secondnameTextBox.Text;
            String surname = surnameTextBox.Text;
            String user = usersComboBox.Text;
            Int32 userNum = (int)usersComboBox.SelectedValue;
            //Проверка заполненности полей
            if (name == "" || surname == "")
            {     
                MessageBox.Show("Заполните поля \"Имя\" и \"Фамилия\"!");
                return;
            }
            //Сохранение данных о персоне в таблицу person
            DBQueries.SavePersonCard(name, secondname, surname, userNum);
            this.Close();
        }
        //Выход из формы при отказе от создания новой записи
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
