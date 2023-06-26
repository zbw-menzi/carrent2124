namespace Zbw.Carrent.CustomerManagement.Domain
{
    public class Customer
    {
        public Customer(string customerNr, string name)
        {
            Id = Guid.NewGuid();
            CustomerNr = customerNr;
            Name = name;
        }

        public Guid Id { get; }

        public string CustomerNr { get; }

        public string Name { get; }
    }
}
