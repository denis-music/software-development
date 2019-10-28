using DLWMS.Core;
using DLWMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DLWMS.Service
{


    public interface IStudentService
    {
        void Add(Student obj);
        void Update(Student obj);

        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetStudentsByGodinaStudija(int godina);
        Student GetStudentByIme(string ime);
    }
    public class StudentService : IStudentService
    {
        IRepository<Student> studentRepository;
        public StudentService(IRepository<Student> studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        public void Add(Student obj)
        {
            studentRepository.Add(obj);
        }

        public Student GetStudentByIme(string ime)
        {
            return studentRepository.GetAll().Where(x => x.Ime == ime).SingleOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentRepository.GetAll();
        }

        public IEnumerable<Student> GetStudentsByGodinaStudija(int godina)
        {
            return studentRepository.GetAll().ToList();//.Where(x=>x.godina==godina);
        }

        public void Update(Student obj)
        {
            studentRepository.Update(obj);
        }
    }
}
