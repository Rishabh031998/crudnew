using crudnew.Data;
using crudnew.Models;
using System.Collections.Generic;
using System.Linq;

namespace crudnew.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentContextDb _context;
        public StudentRepo(StudentContextDb _context)
        {
            this._context = _context;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            var d = _context.studentsInfo.ToList();
            return d;   
        }
    }
}
