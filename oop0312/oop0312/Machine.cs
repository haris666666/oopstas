using System;
using System.Collections.Generic;
using System.Text;

namespace oop0312
{
    class Machine
    {
        private string _country;
        private int _yearOfIssue;
        private string _brand;
       // private int _countOfRepairs;

       // public Machine() { _countOfRepairs = 0; }
        public  Machine(string Country, int YearOfIssue, string Brand)
        {
            _country = Country;
            _yearOfIssue = YearOfIssue;
            _brand = Brand;
           // _countOfRepairs = CountOfRepairs;
        }

        public string GetCountry()
        {
            return _country;
        }
        public void SetCountry(string Country)
        {
            _country = Country;
        }

        public int GetYearOfIssue()
        {
            return _yearOfIssue;
        }
        public void SetYearOfissue(int YearOfIssue)
        {
            _yearOfIssue = YearOfIssue;
        }

        public string GetBrand()
        {
            return _brand;
        }
        public void SetBrand(string Brand)
        {
            _brand = Brand;
        }
    }
}
