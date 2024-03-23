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
    /// Lógica de interacción para ListaConductores.xaml
    /// </summary>
    public partial class ListaConductores : Window
    {
        public ListaConductores()
        {
            InitializeComponent();
            List<Conductor> conductores = new List<Conductor>
            {
                new Conductor { NombreConductor = "Juan Pérez", Licencia = "ABC123", Transporte = "Camión" },
                new Conductor { NombreConductor = "María García", Licencia = "DEF456", Transporte = "Furgoneta" },
            };

            dgConductores.ItemsSource = conductores;
        }
    }

    public class Conductor
    {
        public string NombreConductor { get; set; }
        public string Licencia { get; set; }
        public string Transporte { get; set; }
    }
}
