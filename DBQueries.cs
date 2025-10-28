using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;


namespace Дипломная_работа
{
    internal class DBQueries
    {
        //Загрузка списка пользователей в поле loginPasswordList LoginForm
        public static DataTable LoadLoginList()
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT users_id, users_login, users_password FROM users", dB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dB.closeConnection();
            return table;
        }
        //Сохранение нового пользователя в базу данных
        public static void SaveLoginCard(string login, string password)
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (users_login, users_password) VALUES (@l, @p)", dB.GetConnection());
            command.Parameters.AddWithValue("@l", login);
            command.Parameters.AddWithValue("@p", password);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dB.closeConnection();
        }
        //Сохранение новой персоны в БД таблица person
        public static void SavePersonCard(string name, string secondname, string surname, int user)
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO person (person_name, person_secondname, person_surname, person_users) VALUES (@n, @secn, @surn, @us)", dB.GetConnection());
            command.Parameters.AddWithValue("@n", name);
            command.Parameters.AddWithValue("@secn", secondname);
            command.Parameters.AddWithValue("@surn", surname);
            command.Parameters.AddWithValue("@us", user);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dB.closeConnection();
        }
    }
}
