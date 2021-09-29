using EFFirstVSSingle.Context;
using EFFirstVSSingle.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFFirstVSSingle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var context = new AppDbContext();
            var studentsWithSameName = await context.Students
                                              .FirstOrDefaultAsync(s => s.Name == "taha");

            //var studentsWithSameName = await context.Students.AsNoTracking()
            //                                  .Where(s => s.Name == "Taha")
            //                                  .SingleOrDefaultAsync();

            Console.WriteLine(studentsWithSameName.StudentId);
        } 
        
        //static void Main(string[] args)
        //{
        //    var context = new AppDbContext();
        //    var studentsWithSameName =  context.Students.AsNoTracking()
        //                                      .Where(s => s.Name == "taha")
        //                                      .FirstOrDefault(s => s.Name == "taha");

        //    //var studentsWithSameName =  context.Students.AsNoTracking()
        //    //                                  .Where(s => s.Name == "Taha")
        //    //                                  .SingleOrDefault();

        //    Console.WriteLine(studentsWithSameName.StudentId);
        //}
    }
}
