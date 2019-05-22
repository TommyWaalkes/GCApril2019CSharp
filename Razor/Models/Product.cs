using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razor.Models
{
    public class Product
    {
        public String Name { get; set; }
        public double Cost { get; set; }
        public String Description { get; set; }
        public Product()
        {
            //Note this empty constructor is here to avoid an error
            //In reality you'd almost never make a constructor for 
            //a Model, but since we don't know APIs or Databases yet 
            //I'm faking one here. 
        }
        public Product(String name, double cost, string Description)
        {
            //Again don't define constructors for models 
            //We want .Net to do that for us and handle it for us
            this.Name = name;
            this.Cost = cost;
            this.Description = Description;
        }
    }
}