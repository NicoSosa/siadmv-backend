using EmpanadUS.ServiceBase.DAL.Infrastructure.DataUnits;
using System;

namespace SiadMV.DataAccess.Models.SiadMVDb
{
    public class CartProduct : DataUnit<Guid>
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public Cart Cart { get; set; }
    }
}
