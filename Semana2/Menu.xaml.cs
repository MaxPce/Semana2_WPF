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

    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Operaciones_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Show();
            this.Close();
        }

        private void Mantenimientos_Click(object sender, RoutedEventArgs e)
        {
            Mantenimientos mantenimientos = new Mantenimientos();
            mantenimientos.Show();
            this.Close();
        }

        private void Reportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }

    }
}
