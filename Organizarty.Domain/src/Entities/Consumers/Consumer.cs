using Organizarty.Domain.Entities.Accounts;

namespace Organizarty.Domain.Entities.Consumers;

public class Consumer : Account
{
    public string Id { get; set; } = default!;

    public string Fullname { get; set; } = default!;

    public string? CPF { get; set; }

    public DateTime BirthDate { get; set; }
}
