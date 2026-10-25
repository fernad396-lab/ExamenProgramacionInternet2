namespace Examen1FernandoEscobarr.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual CustomerProfile CustomerProfile { get; set; }
    }
}
