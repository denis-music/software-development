using DLWMS.Core;
using DLWMS.Repository;
using DLWMS.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DLWMS.Test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void AddNewStudent()
        {

            var dbContext = DLWMSHelper.GetDLWMSDbContext();
            Repository<Student> repository = new Repository<Student>(dbContext);
            StudentService studentService = new StudentService(repository);

            string imeGuid = Guid.NewGuid().ToString();
            string prezimeGuid = Guid.NewGuid().ToString();


            Student newStudent = new Student() { Ime = imeGuid, Prezime = prezimeGuid };
            studentService.Add(newStudent);

            Student student = studentService.GetStudentByIme(imeGuid);

            Assert.IsNotNull(student);
            Assert.AreEqual(student.Prezime, prezimeGuid);
            

        }
    }
}
