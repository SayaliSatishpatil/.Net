using EstoreWebApp.Models;
using EstoreWebApp.Repositories;
using EstoreWebApp.Services;

namespace Services;

public class ProductService:IProductService{

public List<Product> GetProducts(){
    RepositoryManager mgr = new RepositoryManager();
    List<Product>products = new List<Product>();
    string fileName =@"D:\SayaliPatil\cdac\.Net\.NetLab\day8\EstoreWebApp\products.json";
    products=mgr.DeSerialize(fileName);
    return products;
}

public void AddProduct(Product p){
     RepositoryManager mgr = new RepositoryManager();
      List<Product>products = new List<Product>();
      string fileName =@"D:\SayaliPatil\cdac\.Net\.NetLab\day8\EstoreWebApp\products.json";
      products=mgr.DeSerialize(fileName);
      products.Add(p);
      mgr.Serialize(products,fileName);

}

public void DeleteProduct(int pid){
    RepositoryManager mgr = new RepositoryManager();
      List<Product>products = new List<Product>();
      string fileName =@"D:\SayaliPatil\cdac\.Net\.NetLab\day8\EstoreWebApp\products.json";
      products=mgr.DeSerialize(fileName);
      Product newProduct=null;
      foreach(Product p in products){
        if(p.Id==pid){
            newProduct=p;    
        }    
      }
        products.Remove(newProduct);
        mgr.Serialize(products,fileName);
}

}