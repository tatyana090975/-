using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
        private List<Tuple<int, string>> personList {  get; set; }
        public UsersCardForm()
        {
            InitializeComponent();
            LoadPersonComboBox();
        }
        //Заполнение personComboBox
        public void LoadPersonComboBox()
        {
            personList = new List<Tuple<int, string>>();
            string table = "person";
            DataTable tablePerson = DBQueries.LoadGridInForm(table);

            foreach (DataRow row in tablePerson.Rows)
            {
                string value1 = row[0]?.ToString() ?? string.Empty;
                string value2 = row[1]?.ToString() ?? string.Empty;
                string value3 = row[2]?.ToString() ?? string.Empty;
                string value4 = row[3]?.ToString() ?? string.Empty;

                personList.Add(Tuple.Create(Convert.ToInt32(value1),value2 + " " + value3 + " " + value4));
            }
            personComboBox.DataSource = new BindingSource(personList, null);
            personComboBox.DisplayMember = "Item2";
            personComboBox.ValueMember = "Item1";
            personComboBox.SelectedIndex = -1;
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
            string person = personComboBox.Text;
            Int32 personNum = (Int32)personComboBox.SelectedValue;
            
            if (login == "" || password == "" || person == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                string res = DBQueries.SaveUsersCard(personNum, login, password);
                
                if (res == "Карточка успешно сохранена.")
                {
                    MessageBox.Show(res);
                    Close();
                }
                else
                {
                    MessageBox.Show(res);
                    return;
                }
            }
        }        
    }
}
