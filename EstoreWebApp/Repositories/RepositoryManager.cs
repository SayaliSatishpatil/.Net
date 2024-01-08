namespace EstoreWebApp.Repositories;
using EstoreWebApp.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class RepositoryManager{
     public void Serialize(List<Product> products,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var productsJson=JsonSerializer.Serialize<List<Product>>(products,options);
    File.WriteAllText(fileName,productsJson);
   
    }
    public List<Product> DeSerialize(string fileName){
   
      
            string jsonString = File.ReadAllText(fileName);
            List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
               
        return jsonProducts;
    }
}