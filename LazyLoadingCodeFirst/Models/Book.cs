using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingCodeFirst.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }


        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
