namespace GameProjectExperiment
{
    internal class StaticSprite(Location location, Bitmap image) : Sprite(location, image)
    {
        public override void UpdateLocation(long deltaTime) {}
    }
}
