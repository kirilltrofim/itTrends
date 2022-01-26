using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using itTrend.Data;
using itTrend.Models;

namespace itTrend.Service.Students
{
    public class StudentService : IStudentService
    {
        private Context _context;
        IWebHostEnvironment _appEnvironment;

        public StudentService(Context context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public List<Student> List()
        {
            var students = _context.Students.AsQueryable();

            return students.ToList();
        }

        public Student GetById(int id)
        {
            var student = _context.Students.FirstOrDefault(m => m.Id == id);
            return student;
        }

        public void Create(Student student, IFormFile uploadFile)
        {
            _context.Add(student);
            if (uploadFile != null)
            {
                string path = "/Files/" + uploadFile.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    uploadFile.CopyTo(fileStream);
                }
                student.Photo = path;
            }
            _context.SaveChanges();
        }

        public void Update(int id, StudentViewModel studentViewModel, IFormFile uploadFile)
        {
            var student = _context.Students.FirstOrDefault(i => i.Id == id);

            student.Id = studentViewModel.Id;
            student.LastName = studentViewModel.LastName;
            student.FirstName = studentViewModel.FirstName;
            student.Patronomic = studentViewModel.Patronomic;
            student.PhoneNumber = studentViewModel.PhoneNumber;

            if (uploadFile != null)
            {
                string path = "/Files/" + uploadFile.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    uploadFile.CopyTo(fileStream);
                }
                student.Photo = path;
            }
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = GetById(id);
            _context.Remove(student);
            _context.SaveChanges();
        }

        public bool StudentExists(int id)
        {
            return _context.Students.Any(m => m.Id == id);
        }
    }
}
