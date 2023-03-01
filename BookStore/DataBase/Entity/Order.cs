namespace BookStore.DataBase.Entity
{
    public class Order
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
