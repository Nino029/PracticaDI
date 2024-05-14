using PracticaDIDomain;
using PracticaDIDomain.Interfaz;

class Program
{
    static void Main(string[] args)
    {
        
        ICustomerRepository customerRepository = new CustomerRepository();

        
        CustomerService customerService = new CustomerService(customerRepository);

        
        Customer customer = customerService.GetCustomerById(123);

        Console.WriteLine("\n");
        Console.WriteLine("======CLIENTE:=======");
        Console.WriteLine($"ID: {customer.Id}, Nombre: {customer.Name}");
    }
}