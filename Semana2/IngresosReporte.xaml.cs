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
    /// Lógica de interacción para IngresosReporte.xaml
    /// </summary>
    public partial class IngresosReporte : Window
    {
        public IngresosReporte()
        {
            InitializeComponent();

            List<Ingreso> ingresos = new List<Ingreso>
            {
                new Ingreso { Fecha = "2024-03-23", Placa = "ABC123", Turno = "Mañana", Conductor = "Juan Pérez", Producto = "Producto A", Peso = "1000 kg", Transporte = "Camión" },
                new Ingreso { Fecha = "2024-03-24", Placa = "DEF456", Turno = "Tarde", Conductor = "María García", Producto = "Producto B", Peso = "1500 kg", Transporte = "Furgoneta" },
            };

          
            dgIngresos.ItemsSource = ingresos;
        }
    }
    public class Ingreso
    {
        public string Fecha { get; set; }
        public string Placa { get; set; }
        public string Turno { get; set; }
        public string Conductor { get; set; }
        public string Producto { get; set; }
        public string Peso { get; set; }
        public string Transporte { get; set; }
    }

}
