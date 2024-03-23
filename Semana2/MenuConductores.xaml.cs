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

namespace Semana2
{
    /// <summary>
    /// Lógica de interacción para MenuConductores.xaml
    /// </summary>
    public partial class MenuConductores : Window
    {
        public MenuConductores()
        {
            InitializeComponent();
        }
        private void Registro_Click(object sender, RoutedEventArgs e)
        {
            RegistroConductores registro = new RegistroConductores();
            registro.Show();
            this.Close();
        }

        private void Lista_Click(object sender, RoutedEventArgs e)
        {
            ListaConductores lista = new ListaConductores();
            lista.Show();
            this.Close();
        }
    }
}
