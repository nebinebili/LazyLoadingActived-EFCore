using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LazyLoadingCodeFirst.Models
{
    public abstract class BaseEntity 
    {
        public int Id { get; set; }
    }
}
