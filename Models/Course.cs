using System.ComponentModel.DataAnnotations;

namespace IT3045C_Final_Project
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public string CourseNumber { get; set; }

        public string CourseName { get; set; }

        public string Track { get; set; }

        public int CreditHours { get; set; }
    }
}
