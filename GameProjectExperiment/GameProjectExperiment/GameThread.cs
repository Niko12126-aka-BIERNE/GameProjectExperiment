using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProjectExperiment
{
    internal class GameThread
    {
        public static Bitmap bmpLast;

        public static void GameLoop()
        {
            double maxFPS = 10;
            double minFramePeriodMsec = 1000d / maxFPS;

            Game game = new(new Size(1536, 864));

            bmpLast = (Bitmap)game.Frame.Image.Clone();

            while (true)
            {
                lock (bmpLast)
                {
                    bmpLast.Dispose();
                    bmpLast = (Bitmap)game.NextFrame().Image.Clone();
                }

                Thread.Sleep((int)minFramePeriodMsec);
            }
        }
    }
}
