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
using System.Data.SqlClient;

namespace PPproduct
{
    /// <summary>
    /// Логика взаимодействия для Редактирование_пользователя.xaml
    /// </summary>
    public partial class Редактирование_пользователя : Window
    {

   

        public Редактирование_пользователя()
        {
          
            InitializeComponent();
          

          

        }

      

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
       
        
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Entities.PPproductEntities db = new Entities.PPproductEntities();
            if (db.Администрирование.Any(x => x.Login == LoginBox.Text && x.role != RoleBox.Text))
               
            {
                db.SaveChanges();

            }
            

       


            

           

            


           
            
           
          
        
          


        }
    }
    
}
