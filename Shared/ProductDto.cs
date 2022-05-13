using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }  
    }
}
