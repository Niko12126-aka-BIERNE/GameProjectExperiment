namespace GameProjectExperiment
{
    internal class FloatingSprite(Location location, Bitmap image, Size gameBox) : Sprite(location, image)
    {
        private int direction = -1;

        public override void UpdateLocation(long deltaTime)
        {
            if (ObjectCollisionHandler.ObjectCollidesWithGameBox(this, gameBox) || ObjectCollisionHandler.AnyObjectCollideWith(this))
            {
                direction *= -1;
            }

            Location.YCoordinate += (int)((double)deltaTime / 1000 * 50 * direction);
        }
    }
}
