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

namespace T2_ej3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opacidadAltaRadioButrton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Opacity = 1;
        }

        private void opacidadMediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Opacity = 0.65;
        }

        private void opacidadBajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Opacity = 0.3;
        }

        private void rellenoAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Stretch = Stretch.Fill;
        }

        private void uniformeAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Stretch = Stretch.Uniform;

        }

        private void rellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            changeImage.Stretch = Stretch.None;
        }
    }
}
