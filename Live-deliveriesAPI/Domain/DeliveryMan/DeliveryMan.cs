using Domain.Users;
using NpgsqlTypes;

namespace Domain.DeliveryMan;

public class DeliveryMan : Users.User
{
    public NpgsqlPoint Location { get; set; }    
    public string Localization { get; set; }
}
