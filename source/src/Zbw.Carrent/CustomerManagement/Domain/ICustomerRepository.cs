namespace Zbw.Carrent.CustomerManagement.Domain
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();

        Customer Get(Guid id);

        void Add(Customer customer);

        void Remove(Customer customer);

        void Remove(Guid id);
    }
}
