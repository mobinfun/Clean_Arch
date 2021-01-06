using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Model
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
