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
       public StudentDTO ModelToDto(Student Model)
        {
            StudentDTO dto = new StudentDTO();
            dto.Id = Model.Id;
            dto.FirstName = Model.FirstName;
            dto.LastName = Model.LastName;
            dto.Email = Model.Email;
            dto.EmrollmentNo =Model.EmrollmentNo;
            dto.AddedDate = Model.AddedDate;
            dto.ModifiedDate = Model.ModifiedDate;
            dto.IPAddress = Model.IPAddress;
            return dto;
        }
        
    }
}
