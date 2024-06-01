using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal abstract class Sprite(Location location, Bitmap image)
    {
        public Location Location { get; private set; } = location;
        public Bitmap Image { get; private set; } = image;

        public abstract void UpdateLocation(long deltaTime);
    }
}
