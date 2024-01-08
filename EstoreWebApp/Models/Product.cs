namespace EstoreWebApp.Models;

public class Product{

    public int Id{get;set;}
    public string Name{get;set;}
    public double Price{get;set;}

    public Product(int id,string name,double price){
        this.Id=id;
        this.Name=name;
        this.Price=price;
    }

}