using itTrend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Service.Groups
{
    interface IGroupService
    {
        List<Group> List();
        void Create(Group group, List<Int32> list, List<Int32> list1);
        Group GetById(int id);
        void Update(int id, Group group, List<Int32> list, List<Int32> list1);
        void Delete(int id);
        bool GroupExists(int id);
        List<Educator> EducatorList();
        List<Course> CourseList();

    }
}
