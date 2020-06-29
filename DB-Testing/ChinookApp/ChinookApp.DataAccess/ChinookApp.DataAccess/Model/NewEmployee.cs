using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class NewEmployee
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }
        public int? DeptId { get; set; }
    }
}
