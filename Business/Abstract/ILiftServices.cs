using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILiftServices
    {
        int call();
        int stop();
        int move();
        
    }
}
