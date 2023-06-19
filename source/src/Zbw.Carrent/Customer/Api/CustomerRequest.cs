namespace Zbw.Carrent.Customer.Api
{
    public record CustomerRequest(
        Guid Id,
        string Name,
        string Address
    );
}
