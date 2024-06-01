using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class StaticSprite(Location location, Bitmap image) : Sprite(location, image)
    {
        public override void UpdateLocation(long deltaTime) {}
    }
}
