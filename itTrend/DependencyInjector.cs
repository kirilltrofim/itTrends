using itTrend.Service.Courses;
using itTrend.Service.Educators;
using itTrend.Service.Groups;
using itTrend.Service.Students;
using itTrend.Service.Subjects;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend
{
    public static class DependencyInjector
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {
           /* services.AddScoped(typeof(ICourseService), typeof(CourseService));
            services.AddScoped(typeof(IEducatorService), typeof(EducatorService));
            services.AddScoped(typeof(IGroupService), typeof(GroupService));*/
            services.AddScoped(typeof(IStudentService), typeof(StudentService));
            /*services.AddScoped(typeof(ISubjectService), typeof(SubjectService));*/
            return services;
        }
    }
}