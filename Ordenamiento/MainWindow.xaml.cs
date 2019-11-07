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
using System.Collections.ObjectModel;
namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(58);
            miLista.Add(45);
            miLista.Add(62);
            miLista.Add(07);
            miLista.Add(51);
            miLista.Add(65);
            miLista.Add(12);
            miLista.Add(11);
            miLista.Add(20);

            alumnos.Add(new Alumno("José", 9.8f, 2));
            alumnos.Add(new Alumno("Raul", 8.1f, 0));
            alumnos.Add(new Alumno("Pepe", 7.4f, 8));
            alumnos.Add(new Alumno("Chuy", 9.6f, 1));
            alumnos.Add(new Alumno("Juan", 8.0f, 4));

            lstNumeros.ItemsSource = alumnos;
        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /* if (miLista[0] > miLista[3])
             {
                 var temp = miLista[0];
                 miLista[0] = miLista[3];
                 miLista[3] = temp;
             }*/
            int gap, i, j;
            gap = alumnos.Count / 2;

            while(gap > 0)
            {
                for(i=0;i<alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Promedio > alumnos[gap + i].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }
                }
                gap--;
            }
            
        }

        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if(alumnos[i].Promedio > alumnos[ i + 1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                 
                }
            } while (intercambio);
        }

        private void BtnFaltasShell_Click(object sender, RoutedEventArgs e)
        {
            int gap, i, j;
            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count &&
                        alumnos[i].Faltas > alumnos[gap + i].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;

                    }
                }

                gap--;
            }
        }

        private void BtnFaltasBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Faltas > alumnos[i + 1].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }
    }
}
