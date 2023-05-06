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

namespace KORWA
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

        private void kalkulaotr_button_Click(object sender, RoutedEventArgs e)
        {
            if (pojemnosc_box.Text is string || procent_box.Text is string || cena_box is string)
            {
                MessageBox.Show("bledne dane");
                

            }

            double pojemnosc = Convert.ToDouble(pojemnosc_box.Text);
        double procent = Convert.ToDouble(procent_box.Text);
          double cena = Convert.ToDouble(cena_box.Text);
            

            double etanol = pojemnosc * (procent / 100);
            etanol_box.Text = Convert.ToString(etanol);

            double koszt = etanol / cena;
            zl_box.Text = Convert.ToString(koszt);

        }
    }
}
