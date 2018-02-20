using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj8Teht2
{
    public interface ITransaction
    {
        string ShowTransaction();
        float GetAmount();
    }
}
