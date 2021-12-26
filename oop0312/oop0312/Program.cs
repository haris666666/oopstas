using System;

namespace oop0312
{
    class Program
    {
        static void Main(string[] args)
        {
            Repair repair = new Repair();
            repair.AddMachine("Россия", 1986, "РосСтанок");
            repair.AddTypeRepair("Починка", "3 дня", 1000, " ");
            Console.WriteLine(repair.GetCountOfRepairs());
        }
    }
}
