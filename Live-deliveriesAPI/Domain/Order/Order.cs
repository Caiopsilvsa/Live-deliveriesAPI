// See https://aka.ms/new-console-template for more information
namespace Domain.Order;

public class Order
{
    public int Id { get; set; }
    public int OrderStatusId{ get; set; }
    public int? DeliveryManId { get; set; }
    public string Reference { get; set; }
    public DateTime DateCreated { get; set; }
    public decimal TotalValue { get; set; }

}
