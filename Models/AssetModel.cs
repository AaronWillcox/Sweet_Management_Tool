using System.ComponentModel.DataAnnotations;

namespace Sweet_Management_Tool.Models
{
    public class AssetModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Institution { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        public string InUseBy { get; set; }
    }
}
