using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMarket.Model
{
    public class Fish
    {
        private int _price = 0;
        public int Price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
            }
        }
    }
}
