using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingClass chkact = new CheckingClass();
            chkact.AccountType = new AccountWIntClass();
            Console.WriteLine(chkact.AccountType.GetAccountType());

            CheckingClass red = new CheckingClass();
            red.AccountType = new AccountREDClass();
            CheckingClass blue = new CheckingClass();
            blue.AccountType = new AccountBLUEClass();

            Console.WriteLine(red.AccountType.GetAccountType());
            Console.WriteLine(blue.AccountType.GetAccountType());
        }
    }
}
