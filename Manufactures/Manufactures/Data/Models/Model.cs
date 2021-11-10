using System;
using System.Collections.Generic;
using System.Text;

namespace Manufactures.Data.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public int ManufacturerId { get; set; }
    }
}
