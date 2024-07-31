using IT3045C_Final_Project.Interfaces;

namespace IT3045C_Final_Project.Data
{
    public class CourseEnrollmentsContextDAO : ICourseEnrollmentsContextDAO
    {
        private CourseEnrollmentsContext _context;

        public CourseEnrollmentsContextDAO(CourseEnrollmentsContext context)
        {
            _context = context;
        }

        public List<CourseEnrollment> GetAllCourseEnrollments()
        {
            return _context.CourseEnrollments.ToList();
        }
    }
}
