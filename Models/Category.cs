using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Module5.Models
{
    public class Category {
        public int CategoryId {get;set;}
        public string CategoryName {get;set;}
        public string Description {get;set;}
        public ICollection<Product> Products {get;set;}
    }
}