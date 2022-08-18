using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    public static class SampleDate
    {
        public static Department[] departments =
        {
            new Department {Name = "cs" , Address = "alex"},
            new Department {Name = "it" , Address = "cairo" },
            new Department {Name = "is" , Address = "minia" },
            new Department {Name = "or" , Address ="assut" }
        };
        public static Subject[] subjects =
        {
            new Subject {Name = "programming" , Description = "development course"} ,
            new Subject {Name = "soft skills" , Description = "HR course"} ,
            new Subject {Name = "Language" , Description = "Language courses"}
        };

        public static Course[] courses =
        {
            new Course {Name = "C#" , Hours = 60 ,subject = subjects[0] , department = departments [0]  } ,
            new Course {Name = "C++" , Hours = 20 ,subject = subjects[0] , department = departments [0]  } ,
            new Course {Name = "linq" , Hours = 40 ,subject = subjects[1] , department = departments [1]  } ,
            new Course {Name = "EF" , Hours = 60 ,subject = subjects[2] , department = departments [2]  } ,
        };

        public static ArrayList GetCourses()
        {
            var list = new ArrayList(courses);
            list.Add("saber");
            return list;
        }

    }
}
