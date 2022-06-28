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

namespace HelloWordEmWpf
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

        private void ButtonAddNome_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && !ListarNomes.Items.Contains(txtNome.Text))
            {
                ListarNomes.Items.Add(txtNome.Text);
                txtNome.Clear();
            }
        }
    }
}
