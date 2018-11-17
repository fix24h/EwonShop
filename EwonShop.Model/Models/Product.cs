using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EwonShop.Model.Abstract;

namespace EwonShop.Model.Models
{
    [Table("Products")]
    public class Product:Auditable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        public string Image { get; set; }
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        public string Tags { get; set; }
        public int Quantity { get; set; }
        public decimal OriginalPrice { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}
