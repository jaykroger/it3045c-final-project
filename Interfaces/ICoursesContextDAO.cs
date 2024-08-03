using Microsoft.EntityFrameworkCore.Query.Internal;

namespace IT3045C_Final_Project.Data
{
    public interface ICoursesContextDAO
    {
        // CRUD operations for CourseEnrollments

        // Create
        int? AddCourse(Course course);

        // Read
        List<Course> GetCourseByID(int? id);

        // Update
        int? UpdateCourse(Course course);

        // Delete
        int? RemoveCourseByID(int id);
    }
}