using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverComplete.Directions
{
    public interface IDirection
    {       
        public Position MoveForward(Position position);
        public string AsStringCommand();
        IDirection ToRight();
        IDirection ToLeft();
    }
}
