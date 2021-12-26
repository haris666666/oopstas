using System;
using System.Collections.Generic;
using System.Text;

namespace oop0312
{
    class TypeRepair
    {
        private string _name;
        private string _timeRepair;
        private int _price;
        private string _other; // примечания

        public TypeRepair(string Name, string TimeRepair, int Price, string Other)
        {
            _name = Name;
            _timeRepair = TimeRepair;
            _price = Price;
            _other = Other;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string Name)
        {
            _name = Name;
        }

        public string GetTimeRepair()
        {
            return _timeRepair;
        }
        public void SetTimeRepair(string TimeRepair)
        {
            _timeRepair = TimeRepair;
        }

        public int GetPrice()
        {
            return _price;
        }
        public void SetPrice(int Price)
        {
            _price = Price;
        }

        public string GetOther()
        {
            return _other;
        }
        public void SetOther(string Other)
        {
            _other = Other;
        }
    }
}
