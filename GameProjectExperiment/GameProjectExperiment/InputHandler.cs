namespace GameProjectExperiment
{
    internal class InputHandler
    {
        private static readonly Dictionary<Keys, (bool isHorizontal, bool isDown, int direction)> keyState = [];

        public static int HorizontalDirection { get; set; } = 0;
        public static int VerticalDirection { get; set; } = 0;

        public static void InputSend(Keys key, bool isDown)
        {
            (bool isHorizontal, bool isDown, int direction) currKeyState = keyState[key];

            if (currKeyState.isDown == isDown)
            {
                return;
            }

            keyState[key] = (currKeyState.isHorizontal, isDown, currKeyState.direction);

            if (currKeyState.isHorizontal)
            {
                HorizontalDirection += isDown ? currKeyState.direction : -currKeyState.direction;
            }
            else
            {
                VerticalDirection += isDown ? currKeyState.direction : -currKeyState.direction;
            }
        }

        public static void AddKey(Keys key, bool isHorizontal, int direction)
        {
            keyState.Add(key, (isHorizontal, false, direction));
        }
    }
}
