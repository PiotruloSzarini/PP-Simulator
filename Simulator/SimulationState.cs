using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimConsole
{
    public class SimulationState
    {
        public int MoveIndex { get; }
        public List<MappableState> MappableStates { get; }
        public SimulationState(int moveIndex, List<MappableState> mappableStates)
        {
            MoveIndex = moveIndex;
            MappableStates = mappableStates;
        }
    }
}