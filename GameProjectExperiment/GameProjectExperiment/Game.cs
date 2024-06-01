using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class Game
    {
        public Stopwatch FrameDeltaTimer { get; private set; }
        public Size FrameSize { get; private set; }
        public Frame Frame { get; private set; }

        private List<Sprite> sprites;

        public Game(Size frameSize)
        {
            FrameDeltaTimer = new();
            FrameSize = frameSize;
            Frame = new Frame(frameSize);

            sprites = [new MovingSprite(new Location(100, 100), new Bitmap("C:\\Users\\niko1\\OneDrive\\Pictures\\AddBTN.png"))];

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
