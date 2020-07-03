using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GabeStore.Models
{
    public class KeyForGame
    {


        public int Id { get; set; }
        public int GameId { get; set; }
        public Product Product { get; set; }
        public string Key { get; set; }
        public bool isActivated { get; set; }


    }
}
