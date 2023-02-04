using System.Collections.Generic;

namespace LargeSystemsLab2.Models
{
    public class BasketModel
    {
        public string UserName { get; set; }
        public List<BasketItemModel> Items { get; set; } = new List<BasketItemModel>();
        public decimal TotalPrice { get; set; }
    }
}
