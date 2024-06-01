namespace GameProjectExperiment
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            game = new(new Size(1536, 864));
        }

        private void StartGameClicked(object sender, EventArgs e)
        {
            RunGame();
        }

        private void RunGame()
        {
            windowFrame.Image = game.NextFrame().Image;
        }
    }
}
