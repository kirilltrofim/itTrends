using itTrend.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itTrend.Service.Students
{
    public interface IStudentService
    {
        List<Student> List();
        void Create(Student student, IFormFile uploadFile);
        Student GetById(int id);
        void Update(int id, StudentViewModel studentViewModel, IFormFile uploadFile);
        void Delete(int id);
        bool StudentExists(int id);
    }
}