namespace Zbw.Carrent.CustomerManagement.Api.Models
{
    public record CustomerRequest(
        Guid Id,
        string Name,
        string Address,
        string FullName
    );
}
