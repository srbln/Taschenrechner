using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
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

        private void berechneBT_Click(object sender, RoutedEventArgs e)
        {
            fehler.Content = string.Empty;
            if (int.TryParse(zahl1.Text, out int op1) && int.TryParse(zahl2.Text, out int op2))
            {
                try
                {
                    int wert = 0;
                    int me = methode.SelectedIndex;
                    switch (me)
                    {
                        case 0:
                            wert = Mathe.Summieren(op1, op2);
                            break;
                        case 1:
                            wert = Mathe.Subtrahieren(op1, op2);
                            break;
                        case 2:
                            wert = Mathe.Multiplizieren(op1, op2);
                            break;
                        case 3:
                            wert = Mathe.Dividieren(op1, op2);
                            break;
                    }
                    ausgabe.Content = wert.ToString();
                }
                catch (Exception ex)
                {
                    fehler.Content = ex.Message;
                }
            }
            else fehler.Content = "Bitte Zahlen eingeben!";
        }
    }
}