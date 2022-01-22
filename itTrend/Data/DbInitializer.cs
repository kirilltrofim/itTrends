using itTrend.Models;
using System;
using System.Linq;

namespace itTrend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",Patronomic="Olivetto",PhoneNumber="456131661"},
            new Student{FirstName="Meredith",LastName="Alonso",Patronomic="Olivetto",PhoneNumber="46546746"},
            new Student{FirstName="Arturo",LastName="Anand",Patronomic="Olivetto",PhoneNumber="87678"},
            new Student{FirstName="Gytis",LastName="Barzdukas",Patronomic="Olivetto",PhoneNumber="+783753"},
            new Student{FirstName="Yan",LastName="Li",Patronomic="Olivetto",PhoneNumber="6786"},
            new Student{FirstName="Peggy",LastName="Justice",Patronomic="Olivetto",PhoneNumber="27863"},
            new Student{FirstName="Laura",LastName="Norman",Patronomic="Olivetto",PhoneNumber="879737"},
            new Student{FirstName="Nino",LastName="Olivetto",Patronomic="Olivetto",PhoneNumber="37837979373"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            var educators = new Educator[]
            {
            new Educator{FirstName="Alexander",LastName="Alexander",PhoneNumber="456131661"},
            new Educator{FirstName="Alonso",LastName="Alonso",PhoneNumber="45343324"},
            new Educator{FirstName="Anand",LastName="Anand",PhoneNumber="354324"},
            new Educator{FirstName="Barzdukas",LastName="Barzdukas",PhoneNumber="243787"},
            new Educator{FirstName="Li",LastName="Li",PhoneNumber="4564231"},
            new Educator{FirstName="Justice",LastName="Justice",PhoneNumber="5434567"},
            new Educator{FirstName="Norman",LastName="Norman",PhoneNumber="76765"},
            new Educator{FirstName="Olivetto",LastName="Olivetto",PhoneNumber="3778676"}
            };
            foreach (Educator e in educators)
            {
                context.Educators.Add(e);
            }
            context.SaveChanges();
            var groups = new Group[]
            {
            new Group{Number=123,StartYear=DateTime.Parse("2001-09-01"),specialization="asfg"},
            new Group{Number=465,StartYear=DateTime.Parse("2001-09-02"),specialization="saggq"},
            new Group{Number=242,StartYear=DateTime.Parse("2001-09-03"),specialization="wqga"},
            new Group{Number=467,StartYear=DateTime.Parse("2001-09-04"),specialization="fasfas"},
            new Group{Number=576,StartYear=DateTime.Parse("2001-09-05"),specialization="safsafa"},
            new Group{Number=247,StartYear=DateTime.Parse("2001-09-06"),specialization="asfsaf"},
            new Group{Number=637,StartYear=DateTime.Parse("2001-09-07"),specialization="xzvxzv"},
            new Group{Number=987,StartYear=DateTime.Parse("2001-09-08"),specialization="dfhwf"}
            };
            foreach (Group g in groups)
            {
                context.Groups.Add(g);
            }
            context.SaveChanges();
            var courses = new Course[]
            {
            new Course{Number=1},
            new Course{Number=2},
            new Course{Number=3},
            new Course{Number=4},
            new Course{Number=5}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();
            var subjects = new Subject[]
            {
            new Subject{Name="Высшая математика"},
            new Subject{Name="Русский"},
            new Subject{Name="Информатика"},
            new Subject{Name="ООП"}
            };
            foreach (Subject u in subjects)
            {
                context.Subjects.Add(u);
            }
            context.SaveChanges();



        }
    }
}