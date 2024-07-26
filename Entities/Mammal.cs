
/* <summary>
   Represents a Mammal entity with various properties for the mammal database.
   Author: Eduardo
   Last Modified: 26/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a Mammal entity
    public class Mammal
    {
        // Unique identifier for the Mammal
        // Primary key for the RiskCategory entity
        [Key]
        public int MammalID { get; set; }
        
        // Description of the mammal, with a maximum length of 1000 characters
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty; // to avoid NullReferenceException. 
        
        // Image URL or path associated with the mammal, with a maximum length of 120 characters
        [StringLength(120)]
        public string Image { get; set; } = string.Empty;
        
        // Common name of the mammal, required field with a maximum length of 50 characters
        // Display name for UI purposes
        [Required]
        [StringLength(50)]
        [Display(Name = "Common Name")]
        public string CommonName { get; set; } = string.Empty;
        
        // Scientific name of the mammal, required field with a maximum length of 50 characters
        [Required]
        [StringLength(50)]
        [Display(Name = "Scientific Name")]
        public string ScientificName { get; set; } = string.Empty;
        
        // Family classification of the mammal, with a maximum length of 50 characters
        [StringLength(50)]
        public string Family { get; set; } = string.Empty;
        
        // Description of the mammal's habitat, with a maximum length of 255 characters
        [StringLength(255)]
        public string Habitat { get; set; } = string.Empty;
        
        // Description of the mammal's diet, with a maximum length of 255 characters
        [StringLength(255)]
        public string Diet { get; set; } = string.Empty;
        
        // Origin of the mammal, with a maximum length of 100 characters
        [StringLength(100)]
        public string Origin { get; set; } = string.Empty;
        
        // Predators of the mammal, with a maximum length of 100 characters
        [StringLength(100)]
        public string Predators { get; set; } = string.Empty;
        
        // Description of what the mammal looks like, with a maximum length of 1000 characters
        [StringLength(1000)]
        [Display(Name = "Looks Like")]
        public string LooksLike { get; set; } = string.Empty;

        // Risk level for the mammal in England. This is nullable to handle cases where the risk level might not be applicable.
        [Range(1,7,ErrorMessage ="Please enter a value from 1 to 7")]
        public RiskLevel? England { get; set; }

        // Risk level for the mammal in Wales. This is nullable to handle cases where the risk level might not be applicable.
        [Range(1,7,ErrorMessage ="Please enter a value from 1 to 7")]
        public RiskLevel? Wales { get; set; }

        // Risk level for the mammal in Scotland. This is nullable to handle cases where the risk level might not be applicable.
        [Range(1,7,ErrorMessage ="Please enter a value from 1 to 7")]
        public RiskLevel? Scotland { get; set; }

        // Risk level for the mammal in Northern Ireland. This is nullable to handle cases where the risk level might not be applicable.
        // Display name for UI purposes
        [Display(Name = "Northern Ireland"), Range(1,7,ErrorMessage ="Please enter a value from 1 to 7")]
        public RiskLevel? NorthernIreland { get; set; }

    }
}
