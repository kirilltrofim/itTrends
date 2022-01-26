using itTrend.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Service.Educators
{
    interface IEducatorService
    {
        List<Educator> List();
        void Create(Educator educator, IFormFile uploadFile, List<Int32> list, List<Int32> list1);
        Educator GetById(int id);
        void Update(int id, Educator educator, IFormFile uploadFile, List<Int32> list, List<Int32> list1);
        void Delete(int id);
        bool EducatorExists(int id);
        List<Group> GroupList();
        List<Subject> SubjectList();

    }
}
