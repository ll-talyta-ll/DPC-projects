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

namespace my.dockpanel
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void OnAboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Como podemos te ajudar?");
        }
        private void OnCadastroClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vamos Começar o cadastro!");
        }
        private void OnInfoDPCClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá, somos a DPC Consultoria, como podemos ajudar?");
        }
         private void OnEmpresasClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("olá, trabalhamos com grandes clientes");
        }
        private void OnServicosBIMClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Olá, somos a DPC Consultoria, fazemos projetos para grandes empresas utilizando os Serviços BIM!");
        }
    }
}
