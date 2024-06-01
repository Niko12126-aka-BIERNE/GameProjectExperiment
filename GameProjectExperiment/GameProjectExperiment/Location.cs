using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class Location(int xCoordinate, int yCoordinate)
    {
        public int XCoordinate { get; set; } = xCoordinate;
        public int YCoordinate { get; set; } = yCoordinate;
    }
}
