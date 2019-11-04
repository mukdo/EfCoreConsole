using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
namespace efcore
{
    
    class Product
    {
       

        public int Id { get; set; }
        public string ProductName { get; set;}
        public string ProductPrice { get; set; }


    }
}
