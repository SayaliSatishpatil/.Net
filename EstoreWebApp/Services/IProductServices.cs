using EstoreWebApp.Models;

namespace EstoreWebApp.Services;

public interface IProductService{
 List<Product> GetProducts();

void AddProduct(Product p);

void DeleteProduct(int pid);

}
