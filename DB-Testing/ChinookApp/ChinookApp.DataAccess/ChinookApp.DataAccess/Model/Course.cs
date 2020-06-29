using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class Course
    {
        public int Id { get; set; }
        public string CourseNumber { get; set; }
        public string SectionNumber { get; set; }
    }
}
