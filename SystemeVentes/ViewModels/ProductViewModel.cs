
using System.Collections.ObjectModel;
using SystemeVentes.Models;
using SystemeVentes.Services;

namespace SystemeVentes.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        IDataService<Product> dataService;

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public ProductViewModel(IDataService<Product> _productDataService)
        {
            dataService = _productDataService;

            Products = 
                new ObservableCollection<Product>
                (dataService.GetAll());
        }
    }
}