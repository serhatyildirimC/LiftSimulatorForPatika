using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lift : IEntity
    {
        public int Id { get; set; }
        public int Floor { get; set; }
        public int MovingWay { get; set; }
        public bool OpenOrClose { get; set; }
    }
}
