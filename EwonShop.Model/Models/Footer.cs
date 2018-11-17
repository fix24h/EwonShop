using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EwonShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string id { set; get; }

        [Required]
        public string content { set; get; }
    }
}