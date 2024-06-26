﻿namespace GameProjectExperiment
{
    internal class FallingSprite(Location location, Bitmap image) : Sprite(location, image)
    {
        public override void UpdateLocation(long deltaTime)
        {
            Location.YCoordinate += (int)((double)deltaTime / 1000 * 10);
        }
    }
}
