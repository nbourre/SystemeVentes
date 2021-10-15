using System.Windows;
using SystemeVentes.Services;
using SystemeVentes.ViewModels;

namespace SystemeVentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dataService = 
                new ProductDataService();

            // À titre d'exemple
            var dataServiceB = 
                new ProductDataService();

            DataContext = new ProductViewModel(dataService);
        }
    }
}
