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
            //Load_PersonCardForm();
        }
        //Загрузка формы (заполнение поля loginPasswordList данными)
        

        private void OKButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String secondname = secondnameTextBox.Text;
            String surname = surnameTextBox.Text;
            
            
            //Проверка заполненности полей
            if (name == "" || surname == "")
            {     
                MessageBox.Show("Заполните поля \"Имя\" и \"Фамилия\"!");
                return;
            }
            //Сохранение данных о персоне в таблицу person
            DBQueries.SavePersonCard(name, secondname, surname);
            this.Close();
        }
        //Выход из формы при отказе от создания новой записи
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
