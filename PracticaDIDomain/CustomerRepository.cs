using PracticaDIDomain.Interfaz;

namespace PracticaDIDomain
{
   public  class CustomerRepository : ICustomerRepository
    {
        public Customer GetById(int id)
        {
            
            return new Customer { Id = id, Name = "Andy" };
        }
    }
}
