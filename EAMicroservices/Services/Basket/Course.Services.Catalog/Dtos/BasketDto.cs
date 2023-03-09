using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services.Basket.Dtos
{
    public class BasketDto
    {
        public string UserId { get; set; }

        public string DiscountCode { get; set; }

        public int? DiscountRate { get; set; }
        public List<BasketItemDto> basketItems { get; set; }

        public decimal TotalPrice
        {
            get => basketItems.Sum(x => x.Price * x.Quantity);
        }
    }
}