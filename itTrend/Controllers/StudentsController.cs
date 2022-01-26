using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using itTrend.Data;
using itTrend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using itTrend.Service.Students;

namespace itTrend.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var list = _studentService.List();

            var listViewModel = new List<StudentViewModel>();

            foreach (var item in list)
            {
                var student = new StudentViewModel()
                {
                    Id = item.Id,
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    Patronomic = item.Patronomic,
                    PhoneNumber = item.PhoneNumber,
                    Photo = item.Photo
                };
                listViewModel.Add(student);
            }
            return View(await Task.Run(() => listViewModel));
        }


        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentService.GetById((int)id);

            if (student == null)
            {
                return NotFound();
            }

            var studentViewModel = new StudentViewModel()
            {
                Id = student.Id,
                LastName = student.LastName,
                FirstName = student.FirstName,
                Patronomic = student.Patronomic,
                PhoneNumber = student.PhoneNumber,
                Photo = student.Photo
            };

            return View(await Task.Run(() => studentViewModel));
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel studentViewModel, IFormFile uploadFile)
        {
            if (ModelState.IsValid)
            {
                var student = new Student()
                {
                    Id = studentViewModel.Id,
                    LastName = studentViewModel.LastName,
                    FirstName = studentViewModel.FirstName,
                    Patronomic = studentViewModel.Patronomic,
                    PhoneNumber = studentViewModel.PhoneNumber,
                    Photo = studentViewModel.Photo
                };

                _studentService.Create(student, uploadFile);
                return RedirectToAction(await Task.Run(() => nameof(Index)));
            }
            return View(await Task.Run(() => studentViewModel));
        }

        // GET: Studnets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentService.GetById((int)id);
            if (student == null)
            {
                return NotFound();
            }

            var studentViewModel = new StudentViewModel()
            {
                Id = student.Id,
                LastName = student.LastName,
                FirstName = student.FirstName,
                Patronomic = student.Patronomic,
                PhoneNumber = student.PhoneNumber,
                Photo = student.Photo
            };

            return View(await Task.Run(() => studentViewModel));

        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentViewModel studentViewModel, IFormFile uploadFile)
        {
            if (id != studentViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _studentService.Update(id, studentViewModel, uploadFile);
                }
                catch (Exception ex)
                {
                    if (!StudentExists(studentViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(await Task.Run(() => nameof(Index)));
            }

            return View(await Task.Run(() => studentViewModel));
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _studentService.GetById((int)id);

            if (student == null)
            {
                return NotFound();
            }

            var studentViewModel = new StudentViewModel()
            {
                Id = student.Id,
                LastName = student.LastName,
                FirstName = student.FirstName,
                Patronomic = student.Patronomic,
                PhoneNumber = student.PhoneNumber,
                Photo = student.Photo
            };

            return View(await Task.Run(() => studentViewModel));

            //return View(await Task.Run(() => novost));
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction(await Task.Run(() => nameof(Index)));
        }

        private bool StudentExists(int id)
        {
            return _studentService.StudentExists(id);
        }
    }
}
