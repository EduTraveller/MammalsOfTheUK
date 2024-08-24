
/* <summary>
   Represents an User entity with a unique identifier.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents an User entity
    public class User
    {
        // Unique identifier for the user
        // This ID is used to uniquely identify each user
        // Primary key for the RiskCategory entity
        [Key]
        public int UserID { get; set; }
    }
}