using crudnew.Models;
using System.Collections.Generic;

namespace crudnew.Repository
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
    }
}
