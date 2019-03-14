using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    class Program
    {
     

        static void Main(string[] args)
        {

            Account account = new Account();
            account.Id = new Id();
            account.Sum = 1000;

            Account account2 = new Account();
            account2.Id = 10;
            account2.Sum = 1000;



            Console.ReadKey();

        }

      
        class Account
        {
            public object Id { get; set; }
            public int Sum { get; set; }
        }

        class Id { }
    }
}
