using System.Windows;
using System.Windows.Controls;

namespace Ejercicio4_LimitacionDeCaracteres
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            item_TextBox.Text = "0/140";
        }

        private void Item_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int longitud = cuadroDeTexto.Text.Length;
            if (longitud >= 140)
                cuadroDeTexto.IsReadOnly = true;
            item_TextBox.Text = cuadroDeTexto.Text.Length + "/140";
        }
    }
}
