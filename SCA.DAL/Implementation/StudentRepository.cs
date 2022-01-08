using Microsoft.EntityFrameworkCore;
using SCA.DAL.Interfaces;
using SCA.Data.Context;
using SCA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.DAL.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationContext _AppContext;
        private DbSet<Student> studentEntity;
        public StudentRepository(ApplicationContext context)
        {
            this._AppContext = context;
            studentEntity = _AppContext.Set<Student>();
        }
        public void DeleteStudent(int id)
        {
              Student student = GetStudent(id);
              studentEntity.Remove(student);
            
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentEntity.AsNoTracking().AsEnumerable();
        }

        public Student GetStudent(int id)
        {
           return studentEntity.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public void SaveStudent(Student student)
        {
            _AppContext.Entry(student).State = EntityState.Added;
        }

        

        public void UpdateStudent(Student student)
        {
            _AppContext.Entry(student).State = EntityState.Modified;
        }

        public void UpdateContext()
        {
            _AppContext.SaveChanges();
        }
    }
}
