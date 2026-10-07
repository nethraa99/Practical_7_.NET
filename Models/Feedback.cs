using System.ComponentModel.DataAnnotations;

namespace Practical_7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enrollment No is required")]
        [Display(Name = "Enrollment No")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(200, ErrorMessage = "Comments cannot exceed 200 characters")]
        public string Comments { get; set; }
    }
}