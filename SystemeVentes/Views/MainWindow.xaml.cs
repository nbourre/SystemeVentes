using System.Windows;
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

            DataContext = new ProductViewModel();
        }
    }
}
