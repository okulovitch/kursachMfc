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

namespace kursachMain.Windows
{
    /// <summary>
    /// Логика взаимодействия для Enterprises.xaml
    /// </summary>
    public partial class Enterprises : Window
    {
        public Enterprises()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.createContract createCont = new createContract();
            createCont.Show();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            kursachMain.kursachDataSet kursachDataSet = ((kursachMain.kursachDataSet)(this.FindResource("kursachDataSet")));
            // Загрузить данные в таблицу Предприятия. Можно изменить этот код как требуется.
            kursachMain.kursachDataSetTableAdapters.ПредприятияTableAdapter kursachDataSetПредприятияTableAdapter = new kursachMain.kursachDataSetTableAdapters.ПредприятияTableAdapter();
            kursachDataSetПредприятияTableAdapter.Fill(kursachDataSet.Предприятия);
            System.Windows.Data.CollectionViewSource предприятияViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("предприятияViewSource")));
            предприятияViewSource.View.MoveCurrentToFirst();
        }
    }
}
