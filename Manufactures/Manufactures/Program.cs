using Manufactures.Data;
using Manufactures.Presentation;
using System;

namespace Manufactures
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductContext db = new ProductContext();
            db.Database.EnsureCreated();
            Display display = new Display();
        }
    }
}
