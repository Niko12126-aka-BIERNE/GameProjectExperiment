using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class MovingBoundedSprite(Location location, Bitmap image, Size gameBox) : Sprite(location, image)
    {
        public override void UpdateLocation(long deltaTime)
        {
            UpdateHorizotalLocationWithConstraint(deltaTime);
            UpdateVerticalLocationWithConstraint(deltaTime);
        }

        private void UpdateVerticalLocationWithConstraint(long deltaTime)
        {
            if (InputHandler.VerticalDirection < 0)
            {
                if (Location.YCoordinate - Image.Height / 2 <= 0)
                {
                    return;
                }
            } 
            else if (InputHandler.VerticalDirection > 0)
            {
                if (Location.YCoordinate + Image.Height / 2 > gameBox.Height)
                {
                    return;
                }
            }

            Location.YCoordinate += (int)((double)deltaTime / 1000 * 200 * InputHandler.VerticalDirection);
        }

        private void UpdateHorizotalLocationWithConstraint(long deltaTime)
        {
            if (InputHandler.HorizontalDirection < 0)
            {
                if (Location.XCoordinate - Image.Width / 2 <= 0)
                {
                    return;
                }
            }
            else if (InputHandler.HorizontalDirection > 0)
            {
                if (Location.XCoordinate + Image.Width / 2 > gameBox.Width)
                {
                    return;
                }
            }

            Location.XCoordinate += (int)((double)deltaTime / 1000 * 200 * InputHandler.HorizontalDirection);
        }
    }
}
