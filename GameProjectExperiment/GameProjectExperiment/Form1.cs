namespace GameProjectExperiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGameClicked(object sender, EventArgs e)
        {
            AddMovementKeysToInputHandler();
            timer.Start();
            RunGame();
        }

        private static void RunGame()
        {
            Thread thread = new(GameThread.GameLoop);
            thread.Start();
        }

        private void TimerTicked(object sender, EventArgs e)
        {
            if (GameThread.bmpLast is null)
            {
                return;
            }

            lock (GameThread.bmpLast)
            {
                windowFrame.Image?.Dispose();
                windowFrame.Image = (Bitmap)GameThread.bmpLast.Clone();
            }
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            InputHandler.InputSend(e.KeyCode, true);
        }

        private void FormKeyUp(object sender, KeyEventArgs e)
        {
            InputHandler.InputSend(e.KeyCode, false);
        }

        private static void AddMovementKeysToInputHandler()
        {
            InputHandler.AddKey(Keys.W, false, -1);
            InputHandler.AddKey(Keys.S, false, 1);
            InputHandler.AddKey(Keys.A, true, -1);
            InputHandler.AddKey(Keys.D, true, 1);
        }
    }
}
