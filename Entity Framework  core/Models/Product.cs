using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework__core.Models
{
    internal class Product
    {

        public int ProductId { get; set; }

        [Unicode(true)]
        [MaxLength (50)]
        public string Name { get; set; }
        public double Quantity  { get; set; }
        public int Price { get; set; }
        public int Sales { get; set; }
        public string Description { get; set; }
    }

    internal class Customer
    {
       public int CustomerId { get; set; }

        [Unicode(true)]
        [MaxLength(100)]
       public string Name { get; set; }


        [Unicode(false)]
        [MaxLength(80)]
       public string Email { get; set; }
       public string CardNumper { get; set; }
       public int Sales { get; set; }
    }


    internal class Store
    {
        public int StoreId { get; set; }

        [Unicode(false)]
        [MaxLength(80)]
        public string Name { get; set; }
        public double Sales { get; set; }

    }

    internal class Sale
    {

        public int SaleId { get; set; }
        public double Product { get; set; }
        public string Customer { get; set; }
        public string Store { get; set; }
        public string data { get; set; }

    }
}
