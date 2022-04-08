using GuessGame.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame.Services
{
    internal class BoolCompareService : ICompareService<bool>
    {
        public int Compare(bool value1, bool value2)
        {
            if (!value1 && value2)
            {
                return -1;
            }

            if (!value2 && value1)
            {
                return 1;
            }

            return 0;
        }
    }
}
