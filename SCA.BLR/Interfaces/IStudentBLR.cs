using SCA.BLR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.BLR.Interfaces
{
    public interface IStudentBLR
    {
        void SaveStudent(StudentDTO studentVM);
        IEnumerable<StudentDTO> GetAllStudents();
        StudentDTO GetStudent(int id);
        void DeleteStudent(int id);

    }
}
