﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Navigation;


namespace kursachMain.Windows
{
    /// <summary>
    /// Логика взаимодействия для Prepods.xaml
    /// </summary>
    public partial class Prepods : Window
    {
        

        public Prepods()
        {
            InitializeComponent();
            //string connectionString = "SERVER=localhost;DATABASE=kursach;UID=root;PASSWORD=";
            //MySqlConnection = new MySq
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)///save in database Prepods 
        {
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "admin"; // Имя пользователя
            string dbName = "kursach"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = ""; // Пароль для подключения
            string dbConnectionString = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";      
            SqlConnection sqlCon = new SqlConnection(dbConnectionString);
            //open connection database 
            try
            {
                sqlCon.Open();
                string Query = "insert into Преподаватели (IDПреподавателя,ФИОПреподавателя,Должность,Кафедра)  values ('"+ this.FIO_txt.Text + "','"+ this.Positin_txt.Text+ "','"+ Pulpit_txt.Text +"')";
                SqlCommand createCommand = new SqlCommand(Query, sqlCon);
                createCommand.ExecuteNonQuery();
                MessageBox.Show("saved");

                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)///show sql database Prepods
        {
            SqlConnection sqlCon = new SqlConnection();
            //open connection database 
            try
            {
                sqlCon.Open();
                string Query = "select *from Преподаватели";
                SqlCommand createCommand = new SqlCommand(Query, sqlCon);
                createCommand.ExecuteNonQuery();

                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
