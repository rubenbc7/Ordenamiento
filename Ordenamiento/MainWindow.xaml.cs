﻿using System;
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
            lstNumeros.ItemsSource = miLista;
        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /* if (miLista[0] > miLista[3])
             {
                 var temp = miLista[0];
                 miLista[0] = miLista[3];
                 miLista[3] = temp;
             }*/
            int gap, temp, i, j;
            gap = miLista.Count / 2;

            while(gap > 0)
            {
                for(i=0;i<miLista.Count; i++)
                {
                    if (gap + i < miLista.Count && miLista[i] > miLista[gap + i])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;
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
                for (int i = 0; i < miLista.Count - 1; i++)
                {
                    if(miLista[i] > miLista[ i + 1])
                    {
                        int temp = miLista[i];
                        miLista[i] = miLista[i + 1];
                        miLista[i + 1] = temp;
                        intercambio = true;
                    }
                 
                }
            } while (intercambio);
        }
    }
}
