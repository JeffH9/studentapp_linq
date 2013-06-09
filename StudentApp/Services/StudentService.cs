using StudentApp.Models;
using StudentApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Services
{
    public class StudentService
    {
        private IUnitOfWork _uow;

        private IRepository<Student> _Student;

        public StudentService(IUnitOfWork uow)
        {
            _uow = uow;

            _Student = _uow.GetRepository<Student>();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _Student.GetAll();
        }

        public Student GetStudentByID(int id)
        {
            try
            {
                return _Student.GetAll().Where(s => s.id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Failure getting student", ex);
            }
        }

        public void DeleteStudentByID(int id)
        {
            try
            {
                Student model = _Student.GetAll().Where(s => s.id == id).SingleOrDefault();
                _Student.Delete(model);
                _uow.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("Failure deleting student", ex);
            }
        }
    }
}