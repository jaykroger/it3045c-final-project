namespace IT3045C_Final_Project.Data
{
    public interface ICourseEnrollmentsContextDAO
    {
        // CRUD operations for CourseEnrollments
        List<CourseEnrollment> GetAllCourseEnrollments();
    }
}