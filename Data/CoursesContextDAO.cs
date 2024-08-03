using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Data
{
    public class CoursesContextDAO : ICoursesContextDAO
    {
        private CoursesContext _context;

        public CoursesContextDAO(CoursesContext context)
        {
            _context = context;
        }





        // Reads all records from the database
        public List<Course> GetAllCourses()
        {
            return _context.Courses.OrderBy(x => x.ID).ToList();
        }



        // Read records from the database based on a given ID
        public List<Course> GetCourseByID(int? id)
        {
            if (id == null || id == 0)
            {
                return _context.Courses.OrderBy(ce => ce.ID).Take(5).ToList();
            }
            else
            {
                return _context.Courses.Where(ce => ce.ID == id).ToList();
            }
        }



        // Create a new record in the database
        public int? AddCourse(Course course)
        {
            var courses =  _context.Courses.Where(x  => x.CourseNumber.Equals(course.CourseNumber) && x.CourseName.Equals(course.CourseName)).FirstOrDefault();

            if (courses != null) 
            {
                return null;
            }

            try
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }



        // Update an existing record in the database
        public int? UpdateCourse(Course course)
        {
            var existingCourse = _context.Courses.Find(course.ID);

            if (existingCourse == null)
            {
                return null; // If record not found in database, return null
            }

            // Update the record with new data
            existingCourse.CourseNumber = course.CourseNumber; 
            existingCourse.CourseName = course.CourseName;
            existingCourse.Track = course.Track;
            existingCourse.CreditHours = course.CreditHours;

            try
            {
                _context.Courses.Update(existingCourse);
                _context.SaveChanges();
                return 1; // If successfully updated, return 1
            }
            catch (Exception)
            {
                return 0; // If an error occured during update, return 0
            }
        }



        // Remove a record from the database based on a given ID
        public int? RemoveCourseByID(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null) 
            {
                return null; // If record not found in database, return null
            } 
            else
            {
                try
                {
                    _context.Courses.Remove(course);
                    _context.SaveChanges();
                    return 1; // If successfully removed, return 1
                }
                catch (Exception)
                {
                    return 0;  // If an error occured during removal, return 0
                }
            }
        }
    }
}
