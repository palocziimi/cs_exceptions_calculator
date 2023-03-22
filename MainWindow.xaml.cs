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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOsztas_Click(object sender, RoutedEventArgs e)
        {
            int szam1 = 0;
            int szam2 = 0;
            try
            {
                szam1 = Convert.ToInt32(txtSzam1.Text);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Az első szám nagyobb, mint amit az int megenged");
                txtSzam1.Text = "";
                txtSzam1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Az első mezőben nem szám szerepel");
                txtSzam1.Text = "";
                txtSzam1.Focus();
            }

            try
            {
                if (Convert.ToDouble(txtSzam2.Text) == 0)
                {
                    MessageBox.Show("Nullával nem osztunk!");
                }
                szam2 = Convert.ToInt32(txtSzam2.Text);
                lblEredmeny.Content = szam1 / szam2;
            }
            catch (OverflowException)
            {
                MessageBox.Show("A második szám nagyobb, mint amit az int megenged");
                txtSzam2.Text = "";
                txtSzam2.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("A második mezőben nem szám szerepel");
                txtSzam2.Text = "";
                txtSzam2.Focus();
            }



        }
    }
}
