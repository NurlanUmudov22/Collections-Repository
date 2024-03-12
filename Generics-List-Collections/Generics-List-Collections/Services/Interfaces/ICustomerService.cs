using Generics_List_Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_List_Collections.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetAllByAge(int age);
        int GetCount();

        List<Customer> OrderByAge(char c);
    }
}
