
/* <summary>
   Represents a Question entity with properties for the quiz system.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a Question entity
    public class Question
    {
        // Unique identifier for the question
        // Primary key for the RiskCategory entity
        [Key]
        public int QuestionID { get; set; }

        // Unique identifier for the quiz to which this question belongs
        public int QuizID { get; set; }
        
        // Text of the question, with a maximum length of 255 characters
        // Display name for UI purposes
        [StringLength(255)]
        [Display(Name = "Question Text")]
        public string QuestionText { get; set; } = string.Empty; // Initialize to avoid NullReferenceException. 
        
        // Text for option A, with a maximum length of 100 characters
        [StringLength(100)]
        [Display(Name = "Option A")]
        public string OptionA { get; set; } = string.Empty; 
        
        // Text for option B, with a maximum length of 100 characters
        [StringLength(100)]
        [Display(Name = "Option B")]
        public string OptionB { get; set; } = string.Empty; 
        
        // Text for option C, with a maximum length of 100 characters
        [StringLength(100)]
        [Display(Name = "Option C")]
        public string OptionC { get; set; } = string.Empty; 
        
        // Text for option D, with a maximum length of 100 characters
        [StringLength(100)]
        [Display(Name = "Option D")]
        public string OptionD { get; set; } = string.Empty; 
        
        // Text for the correct option, with a maximum length of 255 characters
        [StringLength(255)]
        [Display(Name = "Correct Option")]
        public string CorrectOption { get; set; } = string.Empty; 
    }
}