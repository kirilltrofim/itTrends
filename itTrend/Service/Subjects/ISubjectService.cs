using itTrend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Service.Subjects
{
    interface ISubjectService
    {
        List<Subject> List();
        void Create(Subject subject, List<Int32> list);
        Subject GetById(int id);
        void Update(int id, Subject subject, List<Int32> list);
        void Delete(int id);
        bool SubjectExists(int id);
        List<Educator> EducatorList();
    }
}
