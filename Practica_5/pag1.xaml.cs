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

namespace Practica_5
{
    /// <summary>
    /// Interaction logic for pag1.xaml
    /// </summary>
    public partial class pag1 : Window
    {

        Sala sala;
        Asientos asientos;
        public pag1(Sala s)
        {
            InitializeComponent();
            this.sala = s;
        }
        
        
        
        private int _status = 0;
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            _status = 1;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            _status = 2;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            _status = 0;
        }

        private void s25_Click(object sender, RoutedEventArgs e)
        {
            if (_status > 0)
            {
                if (_status == 1)
                {
                    sala.listSala.Add(new Asientos(1, 1, _status));
                    s25.Background = Brushes.Red;

                }
                else if (_status == 2)
                {
                    s25.Background = Brushes.Yellow;
                }
                else if (_status == 0)
                {
                    s25.Background = Brushes.Green;
                }
            } 
            
        }

        private void s26_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s26.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s26.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s26.Background = Brushes.Green;
            }
        }

        private void s27_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s27.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s27.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s27.Background = Brushes.Green;
            }
        }

        private void s28_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s28.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s28.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s28.Background = Brushes.Green;
            }
        }


        private void s30_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s30.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s30.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s30.Background = Brushes.Green;
            }
        }

        private void s29_Click_1(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s29.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s29.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s29.Background = Brushes.Green;
            }
        }

        private void s31_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s31.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s31.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s31.Background = Brushes.Green;
            }
        }

        private void s32_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s32.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s32.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s32.Background = Brushes.Green;
            }
        }

        private void s9_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s9.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s9.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s9.Background = Brushes.Green;
            }
        }

        private void s10_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1 )
            {
                s10.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s10.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s10.Background = Brushes.Green;
            }
        }

        private void s11_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s11.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s11.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s11.Background = Brushes.Green;
            }
        }

        private void s12_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s12.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s12.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s12.Background = Brushes.Green;
            }
        }

        private void s13_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s13.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s13.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s13.Background = Brushes.Green;
            }
        }

        private void s14_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s14.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s14.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s14.Background = Brushes.Green;
            }
        }

        private void s15_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s15.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s15.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s15.Background = Brushes.Green;
            }
        }

        private void s16_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s16.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s16.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s16.Background = Brushes.Green;
            }
        }

        private void s17_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s17.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s17.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s17.Background = Brushes.Green;
            }
        }

        private void s18_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s18.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s18.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s18.Background = Brushes.Green;
            }
        }

        private void s19_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s19.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s19.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s19.Background = Brushes.Green;
            }
        }

        private void s20_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s20.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s20.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s20.Background = Brushes.Green;
            }
        }

        private void s21_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s21.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s21.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s21.Background = Brushes.Green;
            }
        }

        private void s22_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s22.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s22.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s22.Background = Brushes.Green;
            }
        }

        private void s23_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s23.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s23.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s23.Background = Brushes.Green;
            }
        }

        private void s24_Click(object sender, RoutedEventArgs e)
        {
            if (_status == 1)
            {
                s24.Background = Brushes.Red;
            }
            else if (_status == 2)
            {
                s24.Background = Brushes.Yellow;
            }
            else if (_status == 0)
            {
                s24.Background = Brushes.Green;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lb1.Content = "Nombre de obra : " + sala.nombreEven;
            lb2.Content = "Fecha : " + sala.fecha;
            lb3.Content = "Hora : " + sala.hora;

            //Primara fila de sillas
            
            sala.listSala.Add(new Asientos(1, 1, 0));
            sala.listSala.Add(new Asientos(1, 1, 0));
            sala.listSala.Add(new Asientos(1, 1, 0));

            //Segunda fila de sillas
            sala.listSala.Add(new Asientos(1, 2, 0));
            sala.listSala.Add(new Asientos(2, 2, 0));
            sala.listSala.Add(new Asientos(3, 2, 0));
            sala.listSala.Add(new Asientos(4, 2, 0));

            //Tercera fila de sillas
            sala.listSala.Add(new Asientos(1, 3, 0));
            sala.listSala.Add(new Asientos(2, 3, 0));
            sala.listSala.Add(new Asientos(3, 3, 0));
            sala.listSala.Add(new Asientos(4, 3, 0));

            //Cuarta fila de sillas
            sala.listSala.Add(new Asientos(1, 4, 0));
            sala.listSala.Add(new Asientos(2, 4, 0));
            sala.listSala.Add(new Asientos(3, 4, 0));
            sala.listSala.Add(new Asientos(4, 4, 0));
        }
    }
}
