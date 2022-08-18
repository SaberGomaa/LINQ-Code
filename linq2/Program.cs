using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linq2;

namespace linq1
{
    internal class program
    {
        static string GetName(Course crs)
        {
            return crs.Name;
        }
        static int GetHours(Course crs)
        {
            return crs.Hours;
        }
        static void Main(string[] args)
        {

            // if Func return result one by one it works defferd
            // if Func return result in the end, one time it works eager
            #region LINQ in action
            //IEnumerable<Course> courses = SampleDate.courses.Filter(c => c.Hours > 30);

            //foreach (Course c in courses)
            //{
            //    Console.WriteLine($"CourseName : {c.Name} \t  Hours : {c.Hours} \t DepName : {c.department.Name}");
            //}

            //IEnumerable<string> names = SampleDate.courses.Choose(GetName);
            //IEnumerable<int> hours = SampleDate.courses.Choose(GetHours);
            //IEnumerable<string> hs = courses.Choose(c => c.department.Name);
            #endregion
            #region piplining
            //piplining
            //IEnumerable<string> names = SampleDate.courses.Filter(c => c.Hours > 30).Choose(GetName);

            // return any num of variable using anonymous object

            //var query= SampleDate.courses.Filter(c => c.Hours > 30).Choose(c => new {c.Hours , c.Name , c.department.Address } );
            #endregion
            // where and select are deferrd execution
            #region Query Types
            //query operator
            //var query = 
            //    SampleDate.courses.Where(c => c.Hours > 20)
            //    .Select(c => new {c.Hours , c.Name , c.department.Address });


            ////query expression
            //var Query = from c in SampleDate.courses
            //            where c.Hours > 20 
            //            select new {c.Hours , c.Name , c.department.Address};
            #endregion
            #region Agrregate Functions 
            //var q =
            //      SampleDate.courses.Where(c => c.Hours > 20 || c.Name == "C++")
            //      .Select(c => new { c.Name, c.Hours, c.department.Address }).Take(2);

            //var q1 =
            //  SampleDate.courses.Where(c => c.Hours > 20 || c.Name == "C++")
            //  .Select(c => new { c.Name, c.Hours, c.department.Address }).Skip(2);

            ////count eager execution
            //Console.WriteLine(SampleDate.courses.Count());
            //Console.WriteLine(SampleDate.courses.Where(c => c.Hours > 30).Count());
            //Console.WriteLine(SampleDate.courses.Sum(c => c.Hours));
            //Console.WriteLine(SampleDate.courses.Average(c => c.Hours));

            // Course course = SampleDate.courses.Max(); //throw exception. Must implement Icomparable ...  
            #endregion
            #region First & Last 

            Course cr = SampleDate.courses.Where(c => c.Hours >= 20).FirstOrDefault(); //First
            Course crs = SampleDate.courses.Where(c => c.Hours >= 20).LastOrDefault(); //Last


            #endregion
            //Console.WriteLine(cr.Hours);
            #region sub Query
            //var qr =
            //       from sub in SampleDate.subjects
            //       select new
            //       {
            //           sub.Name,
            //           crs =
            //               from c in SampleDate.courses
            //               where c.subject.Name == sub.Name
            //               select c
            //       };

            //foreach (var r in qr)
            //{
            //    Console.WriteLine($"Subject Name : {r.Name} \t totalHours : {r.crs.Sum(c => c.Hours)}");
            //    foreach (var c in r.crs)
            //    {
            //        Console.WriteLine($"{c.Name} Hours : {c.Hours}");
            //    }
            //    Console.WriteLine("---------------------------");
            //} 
            #endregion

            #region OrderBy
            //var query =
            //     from cs in SampleDate.courses
            //     where cs.Hours >= 20
            //     orderby cs.department.Name, cs.Hours
            //     select new { cs.Name, cs.Hours, depName = cs.department.Name };

            //var query1 =
            //    (from cs in SampleDate.courses
            //     where cs.Hours >= 20
            //     select new { cs.Name, cs.Hours, depName = cs.department.Name }).OrderByDescending(c => c.Hours).ThenBy(c => c.Name);

            #endregion

            #region eager execution
            //var query =
            //       (from c in SampleDate.courses
            //        where c.Hours >= 20
            //        select new { c.Name, c.Hours, depName = c.department.Name }).OrderByDescending(c => c.Hours).ToList(); 
            #endregion

            #region GroupBy
            //var query =
            //    from crs1 in SampleDate.courses
            //    group crs1 by crs1.subject;

            //foreach (var grp in query)
            //{
            //    Console.WriteLine($"CName {grp.Key.Name} totalHours {grp.Sum(c=> c.Hours)}" );

            //    foreach (var i in grp)
            //    {
            //        Console.WriteLine($"CName {i.Name} \t Hours {i.Hours}");
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            //var query =
            //   from crs1 in SampleDate.courses
            //   group crs1 by crs1.subject into grp
            //   let totalHours = grp.Sum(c => c.Hours) // let only in  query expression
            //   where totalHours > 50
            //   select new { grp.Key.Name, cources = grp , TotalHours = totalHours };

            //foreach (var grp in query)
            //{
            //    Console.WriteLine($"CName {grp.Name} totalHours {grp.TotalHours}");

            //    foreach (var i in grp.cources)
            //    {
            //        Console.WriteLine($"CName {i.Name} \t Hours {i.Hours}");
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            #endregion



        }

    }
}