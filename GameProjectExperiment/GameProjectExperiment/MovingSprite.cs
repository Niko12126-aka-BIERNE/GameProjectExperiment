﻿namespace GameProjectExperiment
{
    internal class MovingSprite(Location location, Bitmap image) : Sprite(location, image)
    {
        public override void UpdateLocation(long deltaTime)
        {
            Location.YCoordinate += (int)((double)deltaTime / 1000 * 200 * InputHandler.VerticalDirection);
            Location.XCoordinate += (int)((double)deltaTime / 1000 * 200 * InputHandler.HorizontalDirection);
        }
    }
}
