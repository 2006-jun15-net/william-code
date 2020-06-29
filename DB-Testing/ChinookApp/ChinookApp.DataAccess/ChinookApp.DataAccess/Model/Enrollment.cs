using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
    }
}
