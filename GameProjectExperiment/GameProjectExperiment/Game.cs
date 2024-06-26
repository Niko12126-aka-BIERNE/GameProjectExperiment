﻿using System.Diagnostics;

namespace GameProjectExperiment
{
    internal class Game
    {
        public Stopwatch FrameDeltaTimer { get; private set; }
        public Size FrameSize { get; private set; }
        public Frame Frame { get; private set; }

        public static List<Sprite> sprites;

        public Game(Size frameSize)
        {
            FrameDeltaTimer = new();
            FrameSize = frameSize;
            Frame = new Frame(frameSize);

            sprites = [new MovingBoundedSprite(new Location(50, 100), new Bitmap("C:\\Users\\niko1\\OneDrive\\Pictures\\AddBTN.png"), frameSize), new MovingBoundedSprite(new Location(frameSize.Width - 50, 100), new Bitmap("C:\\Users\\niko1\\OneDrive\\Pictures\\AddBTN.png"), frameSize), new PongBallSprite(new Location(300, 100), new Bitmap("C:\\Users\\niko1\\OneDrive\\Pictures\\RemoveBTN.png"), frameSize)];

            FrameDeltaTimer.Start();
        }

        public Frame NextFrame()
        {
            long deltaFrameTime = FrameDeltaTimer.ElapsedMilliseconds;
            FrameDeltaTimer.Restart();

            Frame.Clear();
            Frame.Draw(sprites, deltaFrameTime);

            return Frame;
        }
    }
}
