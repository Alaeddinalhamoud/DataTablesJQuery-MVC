using DataTablesJQuery_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesJQuery_MVC.Service
{
  public  interface IStudent
    {
        List<Student> GetStudent { get; }
    }
}
