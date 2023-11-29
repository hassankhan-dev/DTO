using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        public string? CName { get; set; }
    }
}
 