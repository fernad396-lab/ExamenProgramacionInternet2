namespace Examen1FernandoEscobarr.Domain.Entities
{
    public class CustomerProfile
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

       
    }
}
