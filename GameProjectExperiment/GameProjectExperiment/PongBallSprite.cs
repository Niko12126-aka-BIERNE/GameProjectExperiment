using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class PongBallSprite(Location location, Bitmap image, Size gameBox) : Sprite(location, image)
    {
        private int verticalDirection = -1;
        private int horizontalDirection = -1;
        private int speedBonus = 0;

        public override void UpdateLocation(long deltaTime)
        {
            if (Location.XCoordinate < 0)
            {
                throw new Exception("Right player wins!!!");
            }

            if (Location.XCoordinate >= gameBox.Width)
            {
                throw new Exception("Left player wins!!!");
            }

            if (ObjectCollisionHandler.ObjectCollidesWithGameBox(this, gameBox))
            {
                verticalDirection *= -1;
            }

            if (ObjectCollisionHandler.AnyObjectCollideWith(this))
            {
                horizontalDirection *= -1;
                speedBonus += 5;
            }

            Location.YCoordinate += (int)((double)deltaTime / 1000 * 50 * verticalDirection);
            Location.XCoordinate += (int)(((double)deltaTime / 1000 * 50 + speedBonus) * horizontalDirection);
        }
    }
}
