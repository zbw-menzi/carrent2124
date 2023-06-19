namespace Zbw.Carrent.Customer.Api
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }

        public string CustomerNr { get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

    }
}
