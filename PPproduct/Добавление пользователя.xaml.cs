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
    /// Логика взаимодействия для Добавление_пользователя.xaml
    /// </summary>
    public partial class Добавление_пользователя : Window
    {
       
        public Добавление_пользователя()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {


            

                Entities.PPproductEntities db = new Entities.PPproductEntities();
                int UsersCount = db.Администрирование.Count() + 1;

                if (db.Администрирование.Any(x => x.Login == tbLog.Text
                && x.Password == tbPass.Text))
                {
                    MessageBox.Show("Такой пользователь уже существует.");
                }
                else
                {


                    if (tbPass.Text.Length >= 1 && tbName.Text.Length >= 1 && tbSub.Text.Length >= 1 && tbLast.Text.Length >= 1 && tbLog.Text.Length >= 1)
                        db.Администрирование.Add(new Entities.Администрирование()

                        {
                            ID = UsersCount,
                            Name = tbName.Text,
                            Surname = tbSub.Text,
                            Lastname = tbLast.Text,
                            Login = tbLog.Text,
                            Password = tbPass.Text,
                            role = tb_role.Text








                        });
                    db.SaveChanges();

                    
                }
                if((tbPass.Text.Length >= 1 && tbName.Text.Length >= 1 && tbSub.Text.Length >= 1 && tbLast.Text.Length >= 1 && tbLog.Text.Length >= 1))
                {
                MessageBox.Show($"Вы успешно зарегистрировали пользователя {tbLog}");
              
                }
                else
            {
                MessageBox.Show("Не успех");
            }
            
   
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPass.Text.Length >= 1 && tbName.Text.Length >= 1 && tbSub.Text.Length >= 1 && tbLast.Text.Length >= 1 && tbLog.Text.Length >= 1)
            {


                btn_add.IsEnabled = true;
                MessageBox.Show("Успех");


            }
            else
            {
                btn_add.IsEnabled = false;
            }
        }

        private void tbSub_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPass.Text.Length >= 1 && tbName.Text.Length >= 1 && tbSub.Text.Length >= 1 && tbLast.Text.Length >= 1 && tbLog.Text.Length >= 1)
            {


                btn_add.IsEnabled = true;
                MessageBox.Show("  Успех");


            }
            else
            {
                btn_add.IsEnabled = false;
            }
        }

        private void tbLast_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPass.Text.Length >= 1 && tbName.Text.Length >= 1 && tbSub.Text.Length >= 1 && tbLast.Text.Length >= 1 && tbLog.Text.Length >= 1)
            {


                btn_add.IsEnabled = true;
                MessageBox.Show("  Успех");


            }
            else
            {
                btn_add.IsEnabled = false;
            }
        }

        private void tbLog_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPass.Text.Length >= 1 && tbName.Text.Length >= 1 && tbSub.Text.Length >= 1 && tbLast.Text.Length >= 1 && tbLog.Text.Length >= 1)
            {


                btn_add.IsEnabled = true;
                MessageBox.Show("  Успех");


            }
            else
            {
                btn_add.IsEnabled = false;
            }
        }

        private void tbPass_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPass.Text.Length >=1 && tbName.Text.Length>=1 && tbSub.Text.Length>=1 && tbLast.Text.Length>=1 && tbLog.Text.Length>=1)
            {


                btn_add.IsEnabled = true;
                MessageBox.Show("  Успех");


            }
            else
            {
                btn_add.IsEnabled =false ;
            }
        }

        

        private void tb_role_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tb_role.Text == "Администратор" || tb_role.Text == "Пользователь" ) 
                {


                    btn_add.IsEnabled = true;
                    MessageBox.Show("Успех");


                }
                else
                {
                    btn_add.IsEnabled = false;
                }

        }
    }
}
