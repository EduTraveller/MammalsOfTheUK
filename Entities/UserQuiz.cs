
/* <summary>
   Represents a User Quiz association, linking users to quizzes they have taken.
   Author: Eduardo
   Last Modified: 25/07/2024
*/
using System;
using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a User Quiz association
    public class UserQuiz
    {
        // Unique identifier for the user
        // This ID links the quiz record to a specific user
        public int UserID { get; set; }

        // Unique identifier for the quiz
        // This ID identifies the specific quiz associated with the user
        public int QuizID { get; set; }
        
        // Date when the quiz was taken by the user
        // The [Required] attribute ensures this field must be provided
        // [Display] attribute provides a friendly name for UI presentation
        [Required]
        [Display(Name = "Date of Quiz")]
        public DateTime DateOfQuiz { get; set; }
    }
}