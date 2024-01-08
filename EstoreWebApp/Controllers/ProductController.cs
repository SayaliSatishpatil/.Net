using EstoreWebApp.Models;
using EstoreWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace EstoreWebApp.Controllers;

public class ProductController:Controller{

    public readonly IProductService _svc ;

    public ProductController(IProductService svc){
        this._svc=svc;
    }


    [HttpGet]
    public IActionResult Delete(){
        return View();

    }

    [HttpPost]
    public IActionResult Delete(int pid){
      // Product product = new Product(pid, pName);
        _svc.DeleteProduct(pid);
        return RedirectToAction("Index","Product",null);
    }

     [HttpGet]
     public IActionResult Index(){
        List<Product> products=_svc.GetProducts();
        ViewData["products"]=products;
        return View();
     }

    [HttpGet]
    public IActionResult Register(){
        return View();
    }

    [HttpPost]
    public IActionResult Register(int pid, string pName, double price){
        Product p = new Product(pid,pName,price);
        _svc.AddProduct(p);
        return RedirectToAction("Index","Product",null);
    }
}