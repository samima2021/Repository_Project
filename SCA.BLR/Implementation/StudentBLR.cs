using SCA.BLR.Interfaces;
using SCA.BLR.Mapper;
using SCA.BLR.Models;
using SCA.DAL.Interfaces;
using SCA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.BLR.Implementation
{
    public class StudentBLR : IStudentBLR
    {
        private readonly IStudentRepository _studentRepo;
        private readonly StudentMapper _studentMapper;
        public StudentBLR(IStudentRepository studentRepo)
        {
            this._studentRepo = studentRepo;

        }
        public void DeleteStudent(int id)
        {
            _studentRepo.DeleteStudent(id);
            _studentRepo.UpdateContext();
        }

        public IEnumerable<StudentDTO> GetAllStudents()
        {
            var studentlist = _studentRepo.GetAllStudents();
            var studentlistOutput = studentlist.Select(x =>
            {
                return _studentMapper.ModelToDto(x);
            });
            return studentlistOutput;
        }

        public StudentDTO GetStudent(int id)
        {
            Student student = _studentRepo.GetStudent(id);
            StudentDTO studentOutput = _studentMapper.ModelToDto(student);
            return studentOutput;
        }

        public void SaveStudent(StudentDTO studentVM)
        {
            Student stu =_studentMapper.DtoToModel(studentVM);
            if (studentVM.Id > 0)
            {
                _studentRepo.UpdateStudent(stu);
            }
            else
            {
                _studentRepo.SaveStudent(stu);
            }
            _studentRepo.UpdateContext();
        }
    }
}
