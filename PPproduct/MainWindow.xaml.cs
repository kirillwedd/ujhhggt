using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;

namespace PPproduct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
            
        {
            try
            {
                Entities.PPproductEntities db = new Entities.PPproductEntities();
                if (db.Администрирование.Any(x => x.Login == LoginBox.Text && x.Password == PassBox.Text && x.role == "Администратор"))
                {
                    new Добав_или_редактир_пользователя().Show();
                    Hide();
                }


                if (db.Администрирование.Any(x => x.Login == LoginBox.Text && x.Password == PassBox.Text && x.role == "Пользователь"))
                {
                    new Добав_или_редактир_пользователя().Show();
                    Hide();
                }
            }
            catch 
            {
                
                    MessageBox.Show("Вы ввели неверно логин или пароль");
                
            }
        }

        private void LoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
