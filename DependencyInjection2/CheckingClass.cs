using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2
{
    class CheckingClass
    {
        public IAccountInterface AccountType; //injection 

        ///<summary>
        ///this would be the same as 
        ///the constuctor in the checking class in the other project
        ///
        ///"public checking (Account acct)
        ///Account= acct"
        ///</summary>
    }
}
