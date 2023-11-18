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

namespace test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Liquid liquid1 = new("", 0, 0),
            liquid2 = new("", 0, 0);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddV1_Click(object sender, RoutedEventArgs e)
        {
            liquid1++;
            tbV1.Text = liquid1.V.ToString();
        }

        private void btnAddV2_Click(object sender, RoutedEventArgs e)
        {
            liquid2++;
            tbV2.Text = liquid2.V.ToString();
        }

        private void btnRemoveV2_Click(object sender, RoutedEventArgs e)
        {
            liquid2--;
            tbV2.Text = liquid2.V.ToString();
        }

        private void btnRemoveV1_Click(object sender, RoutedEventArgs e)
        {         
            liquid1--;
            tbV1.Text = liquid1.V.ToString();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            if (liquid1 == liquid2)
            {
                tbResult1.Text = "Жидкости равны";
            }
            else tbResult1.Text = "Жидкости не равны";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tb1Values_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool f1, f2;
            f1 = int.TryParse(tbP1.Text, out int p1);
            f2 = int.TryParse(tbV1.Text, out int v1);

            if (f1 && f2)
            {
                liquid1.SetParams(tbName1.Text, p1, v1);
            }
        }

        private void tb2Values_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool f1, f2;
            f1 = int.TryParse(tbP2.Text, out int p2);
            f2 = int.TryParse(tbV2.Text, out int v2);

            if (f1 && f2)
            {
                liquid2.SetParams(tbName2.Text, p2, v2);
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
