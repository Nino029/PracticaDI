using PracticaDIDomain.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDIDomain
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetById(id);
        }

   
    }
}
