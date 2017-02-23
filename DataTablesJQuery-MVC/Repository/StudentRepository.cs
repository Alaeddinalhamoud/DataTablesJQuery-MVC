using DataTablesJQuery_MVC.Models;
using DataTablesJQuery_MVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTablesJQuery_MVC.Repository
{
    public class StudentRepository : IStudent
    {
        

        List<Student> IStudent.GetStudent
        {
            get
            {
                List<Student> Students = new List<Student>() ;
               
                    Students.Add(new Student() { ID = 1, FirstName = "Alaeddin", LastName = "Alhamoud", City = "Aleppo" });
                    Students.Add(new Student() { ID = 2, FirstName = "Marianna", LastName = "Alhoud", City = "Aleppo" });
                    Students.Add(new Student() { ID = 3, FirstName = "Ahmed", LastName = "Alh", City = "Aleppo" });
                    Students.Add(new Student() { ID = 4, FirstName = "Ali", LastName = "Alhamoud", City = "London" });
                    Students.Add(new Student() { ID = 5, FirstName = "Hassan", LastName = "Alhamoud", City = "LA" });
                    Students.Add(new Student() { ID = 6, FirstName = "John", LastName = "king", City = "NY" });
                Students.Add(new Student() { ID = 7, FirstName = "Alaeddin", LastName = "Alhamoud", City = "Aleppo" });
                Students.Add(new Student() { ID = 8, FirstName = "Marianna", LastName = "Alhoud", City = "Aleppo" });
                Students.Add(new Student() { ID = 9, FirstName = "Ahmed", LastName = "Alh", City = "Aleppo" });
                Students.Add(new Student() { ID = 10, FirstName = "Ali", LastName = "Alhamoud", City = "London" });
                Students.Add(new Student() { ID = 11, FirstName = "Hassan", LastName = "Alhamoud", City = "LA" });
                Students.Add(new Student() { ID = 12, FirstName = "John", LastName = "king", City = "NY" });
                Students.Add(new Student() { ID = 13, FirstName = "Alaeddin", LastName = "Alhamoud", City = "Aleppo" });
                Students.Add(new Student() { ID = 14, FirstName = "Marianna", LastName = "Alhoud", City = "Aleppo" });
                Students.Add(new Student() { ID = 15, FirstName = "Ahmed", LastName = "Alh", City = "Aleppo" });
                Students.Add(new Student() { ID = 16, FirstName = "Ali", LastName = "Alhamoud", City = "London" });
                Students.Add(new Student() { ID = 17, FirstName = "Hassan", LastName = "Alhamoud", City = "LA" });
                Students.Add(new Student() { ID = 18, FirstName = "John", LastName = "king", City = "NY" });
                return Students;
            }
        }

      
      
    }
}