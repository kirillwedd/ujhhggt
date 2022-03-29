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
using System.Windows.Shapes;

namespace PPproduct
{
    /// <summary>
    /// Логика взаимодействия для Добав_или_редактир_пользователя.xaml
    /// </summary>
    public partial class Добав_или_редактир_пользователя : Window
    {
        public Добав_или_редактир_пользователя()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Добав_или_редактир_пользователя().Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Добавление_пользователя().Show();
            Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new Редактирование_пользователя().Show();
            Hide();
        }
    }
}
