using itTrend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Service.Courses
{
    interface ICourseService
    {
        List<Course> List();
        void Create(Course course);
        Course GetById(int id);
        void Update(int id, Course course);
        void Delete(int id);
        bool CourseExists(int id);
    }
}
