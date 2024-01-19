using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_5_GarbageCollector
{
    public class Novel : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Novel(string title, string author, string genre, int year) 
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void Info()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }

        ~Novel() 
        {
            Console.WriteLine($"The novel {Title} has been deleted");
        }
        
        public void Dispose()
        {
            Console.WriteLine($"The novel {Title} has been disposed");
        }
         
        
    }

   
}
