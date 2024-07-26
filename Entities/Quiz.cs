
/* <summary>
   Represents a Quiz entity with a unique identifier.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a Quiz entity
    public class Quiz
    {
        // Unique identifier for the Quiz
        // This ID is used to uniquely identify each quiz instance
        // Primary key for the RiskCategory entity
        [Key]
        public int QuizID { get; set; }

        // Unique identifier for the mammal. This ID links the risk category to a specific mammal.
        public int MammalID { get; set; }

        // Description of the quiz question, with a maximum length of 255 characters
        [StringLength(255)]
        public string Description { get; set; } = string.Empty; // to avoid NullReferenceException. 
    }
}