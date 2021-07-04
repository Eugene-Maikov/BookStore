using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        List<Книги> BooksList = Base.mE.Книги.ToList(); //Список
        /*List<Книги> BooksList2 = new List<Книги>();*/ //Отрисовка
        
        public Admin()
        {
            InitializeComponent();
            DGBooks.ItemsSource = BooksList;
        }

      
        //Инициализация картинки
        int i = -1;
        private void MediaElement_Initialized(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                i++;
                MediaElement ME = (MediaElement)sender;
                Книги S = BooksList[i];
                Uri U = new Uri(S.MainImagePath, UriKind.RelativeOrAbsolute);
                ME.Source = U;
                
            }
        }

        //Инициализация названия
        private void Label_Initialized(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                i++;
                TextBlock TB = (TextBlock)sender;
                Книги S = BooksList[i];
                TB.Text = S.Название;
                
            }
        }
        //Инициализация автора
        private void Label_Initialized_1(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                TextBlock Author = (TextBlock)sender;
                Книги S = BooksList[i];
                Author.Text = Convert.ToInt32(S.Автор) + "";
                
            }
        }
        //Инициализация стоимости
        private void Label_Initialized_2(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                TextBlock Price = (TextBlock)sender;
                Книги S = BooksList[i];
                Price.Text = Convert.ToInt32(S.Цена) + "";
                
            }
        }

        //Цвет фона яцейки
        private void StackPanel_Initialized(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                StackPanel SP = (StackPanel)sender;
                Книги S = BooksList[i];
                if (S.Цена != 0)
                {
                    SP.Background = new SolidColorBrush(Color.FromRgb(231, 250, 191));
                }
            }
        }
        //Количество_магазин
        private void Label_Initialized_3(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                TextBlock CM = (TextBlock)sender;
                Книги S = BooksList[i];
                CM.Text = Convert.ToInt32(S.Количество_магазин) + "";
                
            }
        }
        //Количество_склад
        private void Label_Initialized_4(object sender, EventArgs e)
        {
            if (i < BooksList.Count)
            {
                TextBlock CC = (TextBlock)sender;
                Книги S = BooksList[i];
                CC.Text = Convert.ToInt32(S.Количество_склад) + "";
                
            }
        }


        //Инициализация кнопок
        private void BtnStyle_Initialized(object sender, EventArgs e)
        {
            Button BtnBuy = (Button)sender;
            if (BtnBuy != null)
            {
                BtnBuy.Uid = Convert.ToString(i);
            }
        }

        private void BtnStyle_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
