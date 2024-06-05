namespace GameProjectExperiment
{
    internal class Frame(Size size)
    {
        public Bitmap Image { get; set; } = new Bitmap(size.Width, size.Height);

        public void Draw(Sprite sprite, long deltaTime)
        {
            sprite.UpdateLocation(deltaTime);

            int xOffset = sprite.Location.XCoordinate - sprite.Image.Size.Width / 2;
            int yOffset = sprite.Location.YCoordinate - sprite.Image.Size.Height / 2;

            for (int y = 0; y < sprite.Image.Height; y++)
            {
                for (int x = 0; x < sprite.Image.Width; x++)
                {
                    Location pixelLocation = new(x + xOffset, y + yOffset);
                    
                    if (pixelLocation.XCoordinate < size.Width && pixelLocation.XCoordinate >= 0 && pixelLocation.YCoordinate < size.Height && pixelLocation.YCoordinate >= 0)
                    {
                        //TODO: handle transparrent pixels...
                        Image.SetPixel(pixelLocation.XCoordinate, pixelLocation.YCoordinate, sprite.Image.GetPixel(x, y));
                    }
                }
            }
        }

        public void Draw(List<Sprite> sprites, long deltaTime)
        {
            foreach(Sprite sprite in sprites)
            {
                Draw(sprite, deltaTime);
            }
        }

        public void Clear()
        {
            Image = new(Image.Width, Image.Height);
        }
    }
}
