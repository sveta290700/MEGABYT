﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                SqlConnection myConnection;
                myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Store.Properties.Settings.MEGABYTConnectionString"].ConnectionString);
                myConnection.Open();
                string sql1 = "SELECT COUNT(*) FROM dbo.Profile AS Profile WHERE Profile.Login='" + textBox1.Text + "' AND Profile.Password='" + textBox2.Text + "'";
                SqlCommand findProfile = new SqlCommand(sql1, myConnection);
                int res1 = (int)findProfile.ExecuteScalar();
                myConnection.Close();
                if (res1 == 0)
                {
                    MessageBox.Show(
                    "Пользователь с введенными логином и паролем не найден.\nПопробуйте снова или обратитесь к IT-менеджеру.",
                    "В доступе отказано",
                    MessageBoxButtons.OK);
                }
                else
                {
                    myConnection.Open();
                    string sql2 = "SELECT Posts.NamePost FROM dbo.Employee AS Employee INNER JOIN dbo.Profile AS Profile ON Employee.IDProfile = Profile.IDProfile INNER JOIN dbo.Posts AS Posts ON Employee.IDPost = Posts.IDPost WHERE Profile.Login='" + textBox1.Text + "' AND Profile.Password='" + textBox2.Text + "'";
                    SqlCommand findPost = new SqlCommand(sql2, myConnection);
                    string res2 = (string)findPost.ExecuteScalar();
                    myConnection.Close();
                    if (res2 == "Менеджер по закупкам")
                    {
                        myConnection.Open();
                        string sql3 = "SELECT Employee.SName+' '+Employee.FName+' '+Employee.Patronym FROM dbo.Employee AS Employee INNER JOIN dbo.Profile AS Profile ON Employee.IDProfile = Profile.IDProfile INNER JOIN dbo.Posts AS Posts ON Employee.IDPost = Posts.IDPost WHERE Profile.Login='" + textBox1.Text + "' AND Profile.Password='" + textBox2.Text + "'";
                        SqlCommand findEmployeeName = new SqlCommand(sql3, myConnection);
                        string res3 = (string)findEmployeeName.ExecuteScalar();
                        myConnection.Close();
                        SupplyManagerForm f = new SupplyManagerForm(res3);
                        f.ShowDialog(); ;
                    }
                    else if (res2 == "Продавец-консультант")
                    {
                        myConnection.Open();
                        string sql3 = "SELECT Employee.SName+' '+Employee.FName+' '+Employee.Patronym FROM dbo.Employee AS Employee INNER JOIN dbo.Profile AS Profile ON Employee.IDProfile = Profile.IDProfile INNER JOIN dbo.Posts AS Posts ON Employee.IDPost = Posts.IDPost WHERE Profile.Login='" + textBox1.Text + "' AND Profile.Password='" + textBox2.Text + "'";
                        SqlCommand findEmployeeName = new SqlCommand(sql3, myConnection);
                        string res3 = (string)findEmployeeName.ExecuteScalar();
                        myConnection.Close();
                        SellerForm f = new SellerForm(res3);
                        f.ShowDialog();
                    }
                    else if (res2 == "Менеджер по кадрам")
                    {
                        myConnection.Open();
                        string sql3 = "SELECT Employee.SName+' '+Employee.FName+' '+Employee.Patronym FROM dbo.Employee AS Employee INNER JOIN dbo.Profile AS Profile ON Employee.IDProfile = Profile.IDProfile INNER JOIN dbo.Posts AS Posts ON Employee.IDPost = Posts.IDPost WHERE Profile.Login='" + textBox1.Text + "' AND Profile.Password='" + textBox2.Text + "'";
                        SqlCommand findEmployeeName = new SqlCommand(sql3, myConnection);
                        string res3 = (string)findEmployeeName.ExecuteScalar();
                        myConnection.Close();
                        PersonnelManagerForm f = new PersonnelManagerForm(res3);
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Интерфейс для данного пользователя отсутствует.\nПопробуйте снова или обратитесь к IT-менеджеру.",
                            "Ошибка",
                            MessageBoxButtons.OK);
                    }
                }
            }
            else
                MessageBox.Show(
                    "Заполните поля логина и пароля",
                    "Ошибка",
                    MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
