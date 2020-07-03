using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabeStore.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GameId { get; set; }

        //мб лучше связать GameId.Product.Price или GameName
        //public string GameName { get; set; }
        //public string Price { get; set; }
        public Product Product { get; set; }
        public DateTime BuyerTime { get; set; }


    }
}
