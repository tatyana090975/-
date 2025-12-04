using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
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
        public static void SavePersonCard(string name, string secondname, string surname)
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO person (name, secondname, surname) VALUES (@n, @secn, @surn)", dB.GetConnection());
            command.Parameters.AddWithValue("@n", name);
            command.Parameters.AddWithValue("@secn", secondname);
            command.Parameters.AddWithValue("@surn", surname);            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dB.closeConnection();
        }
        //Заполнение grid в простых формах (данные берутся из одной таблицы бд)
        public static DataTable LoadGridInForm(string tableName)
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            string columnName = $"{tableName}_id";
            string query = $"SELECT * FROM `{tableName}`";
            MySqlCommand command = new MySqlCommand(query, dB.GetConnection());
            adapter1.SelectCommand = command;
            adapter1.Fill(table);
            dB.closeConnection();
            return table;
        }
        //удаление строки из базы данных по id
        public static void DeleteRow(string tableName, int numId)
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            // Формируем имя столбца как имя_таблицы_id
            string columnName = $"{tableName}_id";
            string query = $"DELETE FROM `{tableName}` WHERE `{columnName}` = @numId";

            MySqlCommand command = new MySqlCommand(query, dB.GetConnection());
            command.Parameters.AddWithValue("@numId", numId);
            adapter1.SelectCommand = command;
            adapter1.Fill(table);

            dB.closeConnection();
            
        }
        //Сохраниение должности в таблицу position
        public static string SavePositionCard(string position)
        {
            string errorMessage = string.Empty;
            DB dB = new DB();
            try
            {
                dB.openConnection();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO position (position) VALUES (@n)", dB.GetConnection());
                command.Parameters.AddWithValue("@n", position);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                errorMessage = "Карточка успешно сохранена.";
                return errorMessage;
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Код ошибки дублирования
            {
                // Извлекаем значение из сообщения об ошибке
                errorMessage = $"Должность '{position}' уже существует в базе данных.";
                return errorMessage;
            }
            catch (MySqlException ex)
            {
                errorMessage = $"Ошибка базы данных: {ex.Message}";
                return errorMessage;
            }
            catch (Exception ex)
            {
                errorMessage = $"Ошибка: {ex.Message}";
                return errorMessage;
            }
            finally
            {
                dB.closeConnection();
            }
        }

        //Сохраниение должности в таблицу users
        public static string SaveUsersCard(int person_id, string login, string password)
        {
            string errorMessage = string.Empty;
            DB dB = new DB();
            try
            {
                dB.openConnection();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO users (person_id, login, password) VALUES ( @pers, @log, @pass)", dB.GetConnection());
                command.Parameters.AddWithValue("@pers", person_id);
                command.Parameters.AddWithValue("@log", login);
                command.Parameters.AddWithValue("@pass", password);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                errorMessage = "Карточка успешно сохранена.";
                return errorMessage;
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Код ошибки дублирования
            {
                // Извлекаем значение из сообщения об ошибке
                errorMessage = $"Логин '{login}' уже занят. Придумайте другой";
                return errorMessage;
            }
            catch (MySqlException ex)
            {
                errorMessage = $"Ошибка базы данных: {ex.Message}";
                return errorMessage;
            }
            catch (Exception ex)
            {
                errorMessage = $"Ошибка: {ex.Message}";
                return errorMessage;
            }
            finally
            {
                dB.closeConnection();
            }
        }
        //Заполнение grid UsersForms данными из таблиц users и person
        public static DataTable LoadGridUsersForm()
        {
            DB dB = new DB();
            dB.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();                
            MySqlCommand command = new MySqlCommand("SELECT u.users_id, u.login, p.name, p.secondname, p.surname FROM users u LEFT OUTER JOIN person p ON u.person_id = p.person_id",dB.GetConnection());
            adapter1.SelectCommand = command;
            adapter1.Fill(table);
            dB.closeConnection();
            return table;
        }
    
    }
}
