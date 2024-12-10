using Simulator;
using Simulator.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimConsole
{
    public class MappableState
    {
        public IMappable Mappable { get; }
        public Point Position { get; }
        public MappableState(IMappable mappable, Point position)
        {
            Mappable = mappable;
            Position = position;
        }
    }
}