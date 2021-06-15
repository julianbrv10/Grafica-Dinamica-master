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

namespace Grafica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //instancias de las cajas de texto para que cuando se ingrese algo realice el evento
            maximo.TextChanged += new TextChangedEventHandler(maximo_TextChanged);
            cantidad1.TextChanged += new TextChangedEventHandler(cantidad1_TextChanged);
            cantidad2.TextChanged += new TextChangedEventHandler(cantidad2_TextChanged);
            cantidad3.TextChanged += new TextChangedEventHandler(cantidad3_TextChanged);
            cantidad4.TextChanged += new TextChangedEventHandler(cantidad4_TextChanged);
            cantidad5.TextChanged += new TextChangedEventHandler(cantidad5_TextChanged);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void maximo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //se hace el parseo para la conversion de la division de cada parte de la grafica
                //de acuerdo al valor maximo que ingreso el usuario
                //lo divido y multiplico por 3 y 2 para hacer divitorio el num. maximo
                int total = Int32.Parse(maximo.Text) / 4;
                min3.Content = (total * 3).ToString();
                min2.Content = (total * 2).ToString(); 
                min1.Content = total.ToString();
            }
            catch
            {

            }
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void cantidad1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //un try catch por si ocurren errores en la ejecución
            try
            {
                //primero un parseo para guardar los valores ingresados 
                //por el usuario como valor maximo y el limite de cada uno.
                int valor = int.Parse(cantidad1.Text);
                int resultado = int.Parse(maximo.Text);

                //primer operacion para la division de cada pixel,
                //el limite que ingresio el usuario entre los 300 pixeles que es el tamaño de mi figura.
                int valor2 = 310 / resultado;

                //2da operacion es para que cada pixel se multiplique por el que ingreso el usuario
                //y asi sacar el tamaño total de los pixeles necesarios
                int valor3 = valor2 * valor;

                // reacomodo el rectangulo y el textbox para que aumenten su tamaño hacia arriba y no hacia abajo
                rec1.Margin = new Thickness(124,340 - valor3,0,0);
                cantidad1.Margin = new Thickness(124, 304 - valor3, 0, 0);

                //le paso el valor3 que es donde tiene el tamaño asignado en el rectangulo para que aumente
                rec1.Height = valor3;

                //cambia el color blanco cuando es numeros y no letras y no esta vacio
                cantidad1.Background = Brushes.White;

            }
            catch
            {
                //pasa a rojo cuando es un dato no debido
                cantidad1.Background = Brushes.Red;
            }
            
            
        }

        private void cantidad2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int valor = int.Parse(cantidad2.Text);
                int resultado = int.Parse(maximo.Text);
                int valor2 = 310 / resultado;
                int valor3 = valor2 * valor;
                rec2.Height = valor3;
                rec2.Margin = new Thickness(239, 340 - valor3, 0, 0);
                cantidad2.Margin = new Thickness(239, 304 - valor3, 0, 0);


                cantidad2.Background = Brushes.White;
            }
            catch
            {
                cantidad2.Background = Brushes.Red;
            }
        }

        private void cantidad3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int valor = int.Parse(cantidad3.Text);
                int resultado = int.Parse(maximo.Text);
                int valor2 = 310 / resultado;
                int valor3 = valor2 * valor;
                rec3.Height = valor3;
                rec3.Margin = new Thickness(345, 340 - valor3, 0, 0);
                cantidad3.Margin = new Thickness(345, 304 - valor3, 0, 0);

                cantidad3.Background = Brushes.White;
            }
            catch
            {
                cantidad3.Background = Brushes.Red;
            }
        }

        private void cantidad4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int valor = int.Parse(cantidad4.Text);
                int resultado = int.Parse(maximo.Text);
                int valor2 = 310 / resultado;
                int valor3 = valor2 * valor;
                rec4.Height = valor3;
                rec4.Margin = new Thickness(470, 340 - valor3, 0, 0);
                cantidad4.Margin = new Thickness(470, 304 - valor3, 0, 0);

                cantidad4.Background = Brushes.White;
            }
            catch
            {
                cantidad4.Background = Brushes.Red;
            }
        }

        private void cantidad5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int valor = int.Parse(cantidad5.Text);
                int resultado = int.Parse(maximo.Text);
                int valor2 = 310 / resultado;
                int valor3 = valor2 * valor;
                rec5.Height = valor3;
                rec5.Margin = new Thickness(595, 340 - valor3, 0, 0);
                cantidad5.Margin = new Thickness(595, 304 - valor3, 0, 0);

                cantidad5.Background = Brushes.White;
            }
            catch
            {
                cantidad5.Background = Brushes.Red;
            }
        }

        private void cantidad1_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }
    }
}
