using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.Data.Models
{
  public class Student :BaseEntity
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Email { get; set; }   
        public string EmrollmentNo { get; set; }
    }
}
