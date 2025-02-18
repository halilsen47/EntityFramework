using System;
using OOP.EEFCore.ConsoleApp.DAL;
using OOP.EEFCore.ConsoleApp.Entities;

namespace OOP.EEFCore.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new BookAppDbContext();
            
            var category = _context.Categories.Where(c => c.CategoryId == 2)
                .SingleOrDefault();

           _context.Categories.Remove(category);
            _context.SaveChanges();

            Console.ReadKey();
        }
    }
}