
using System.Collections.ObjectModel;
using SystemeVentes.Models;
using SystemeVentes.Services;

namespace SystemeVentes.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        ProductDataService productDataService = new ProductDataService();

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public ProductViewModel()
        {
            Products = 
                new ObservableCollection<Product>
                (productDataService.GetAll());
        }
    }
}