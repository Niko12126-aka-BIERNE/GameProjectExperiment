using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class FloatingSprite(Location location, Bitmap image, Size gameBox) : Sprite(location, image)
    {
        private int direction = -1;

        public override void UpdateLocation(long deltaTime)
        {
            if (CollidesWithGameBox() || ObjectCollisionHandler.AnyObjectCollideWith(this))
            {
                direction *= -1;
            }

            Location.YCoordinate += (int)((double)deltaTime / 1000 * 50 * direction);
        }

        public bool CollidesWithGameBox()
        {
            if (Location.XCoordinate - Image.Width / 2 <= 0)
            {
                return true;
            }

            if (Location.XCoordinate + Image.Width / 2 >= gameBox.Width)
            {
                return true;
            }

            if (Location.YCoordinate - Image.Height / 2 <= 0)
            {
                return true;
            }

            if (Location.YCoordinate + Image.Height / 2 >= gameBox.Height)
            {
                return true;
            }

            return false;
        }
    }
}
