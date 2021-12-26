using System;
using System.Collections.Generic;
using System.Text;

namespace oop0312
{
    
    class Repair
    {
        private Machine _machine;
        private TypeRepair _typeRepair;
        private int _countOfRepairs = 0;
        private string _dataBeginning;
        private string _other;

        public Machine GetMachine()
        {
            return _machine;
        }
        public void AddMachine(string Country, int YearOfIssue, string Brand)
        {
            _machine = new Machine(Country, YearOfIssue, Brand);
        }

        public TypeRepair GetTypeRepair()
        {
            return _typeRepair;
        }
        public void AddTypeRepair(string Name, string TimeRepair, int Price, string Other)
        {
            _typeRepair = new TypeRepair(Name, TimeRepair, Price, Other);
            _countOfRepairs++;
        }

        public int GetCountOfRepairs() { return _countOfRepairs; }

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
