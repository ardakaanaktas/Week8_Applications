namespace BasicMVC.Models
{
    public class CustomerOrderViewModel
    {
        public Customer customer { get; set; }
        public List<Order> orders { get; set; }
    }
}
