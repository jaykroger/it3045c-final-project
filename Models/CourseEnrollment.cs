using System.ComponentModel.DataAnnotations;

namespace IT3045C_Final_Project
{
    public class CourseEnrollment
    {
        [Key]
        public int? StudentID { get; set; }

        public string? CourseNumber { get; set; }

        public string? CourseName { get; set; }

        public string? Track { get; set; }

        public int? CreditHours { get; set; }
    }
}
