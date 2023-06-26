namespace Zbw.Carrent.CustomerManagement.Api.Models
{
    public record CustomerResponse(
        Guid Id,
        string CustomerNr,
        string Name,
        string? Address
    );
}
