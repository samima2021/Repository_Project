using SCA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.DAL.Interfaces
{
   public interface IStudentRepository
    {
        void SaveStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        void DeleteStudent(int id);
        void UpdateStudent(Student student);
        void UpdateContext();
    }
}
