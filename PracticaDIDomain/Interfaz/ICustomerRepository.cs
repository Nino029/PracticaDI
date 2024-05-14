using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDIDomain.Interfaz
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
    }
}
