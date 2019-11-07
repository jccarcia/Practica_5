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

namespace Practica_5
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

        List<Sala> listsalas = new List<Sala>();

        Sala wwe = new Sala("WWE vs RAW", "12 de enero", "14:00");
        Sala torbe = new Sala("El lazarillo de torbe", "1 de enero", "17:59");
        Sala vida = new Sala("La vida es una ******", "Todos los lunes", "8:00 a 14:30");
        Sala potter = new Sala("Juanki potter y la piedra cuetosofal", "17 de Octubre", "10:00" );
        
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if(lbObras.SelectedItem.ToString().Contains("WWE vs RAW"))
            {
                pag1 w1 = new pag1(wwe);
                w1.Show();
            }
            else if (lbObras.SelectedItem.ToString().Contains("El lazarillo de Torbe"))
            {
                pag1 w2 = new pag1(torbe);
                w2.Show();
            }
            else if (lbObras.SelectedItem.ToString().Contains("La vida es una ******"))
            {
                pag1 w1 = new pag1(vida);
                w1.Show();
            }
            else if (lbObras.SelectedItem.ToString().Contains("Juanki potter y la piedra cuetosofal"))
            {
                pag1 w1 = new pag1(potter);
                w1.Show();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
