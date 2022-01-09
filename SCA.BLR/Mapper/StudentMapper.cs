using SCA.BLR.Models;
using SCA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.BLR.Mapper
{
    public class StudentMapper
    {
        public Student DtoToModel(StudentDTO dto)
        {
            Student stu = new Student();
            stu.Id = dto.Id;
            stu.FirstName = dto.FirstName;
            stu.LastName = dto.LastName;
            stu.Email = dto.Email;
            stu.EmrollmentNo = dto.EmrollmentNo;
            stu.AddedDate = dto.AddedDate;
            stu.ModifiedDate = dto.ModifiedDate;
            stu.IPAddress = dto.IPAddress;
            return stu;

        }
        public StudentDTO ModelToDto(Student model)
        {
            StudentDTO dto = new StudentDTO();
            dto.Id = model.Id;
            dto.FirstName = model.FirstName;
            dto.LastName = model.LastName;
            dto.Name = model.FirstName + " " + model.LastName;
            dto.Email = model.Email;
            dto.EmrollmentNo = model.EmrollmentNo;
            dto.AddedDate = model.AddedDate;
            dto.ModifiedDate = model.ModifiedDate;
            dto.IPAddress = model.IPAddress;
            return dto;

        }

    }
}
