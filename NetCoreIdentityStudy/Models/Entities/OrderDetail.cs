namespace NetCoreIdentityStudy.Models.Entities
{
    public class OrderDetail:BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
