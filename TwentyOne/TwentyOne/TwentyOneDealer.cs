using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _card = new List<Card>();

        public List<Card> Hand { get { return _card; } set { _card = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
