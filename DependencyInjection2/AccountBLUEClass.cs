using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2
{
    class AccountBLUEClass : IAccountInterface
    {
        public string GetAccountType()
        {
            return "Blue Account";
        }
    }
}
