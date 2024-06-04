using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectExperiment
{
    internal class ObjectCollisionHandler
    {
        public static bool ObjectCollidesWithGameBox(Sprite object1, Size gameBox)
        {
            if (object1.Location.XCoordinate - object1.Image.Width / 2 <= 0)
            {
                return true;
            }

            if (object1.Location.XCoordinate + object1.Image.Width / 2 >= gameBox.Width)
            {
                return true;
            }

            if (object1.Location.YCoordinate - object1.Image.Height / 2 <= 0)
            {
                return true;
            }

            if (object1.Location.YCoordinate + object1.Image.Height / 2 >= gameBox.Height)
            {
                return true;
            }

            return false;
        }

        public static bool AnyObjectCollideWith(Sprite object1)
        {
            foreach (Sprite object2 in Game.sprites)
            {
                if (object1 != object2)
                {
                    if (ObjectsCollide(object1, object2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ObjectsCollide(Sprite object1, Sprite object2)
        {
            int object1LeftBound = object1.Location.XCoordinate - object1.Image.Width / 2;
            int object1RightBound = object1.Location.XCoordinate + object1.Image.Width / 2;
            int object1TopBound = object1.Location.YCoordinate - object1.Image.Height / 2;
            int object1BotBound = object1.Location.YCoordinate + object1.Image.Height / 2;

            int object2LeftBound = object2.Location.XCoordinate - object2.Image.Width / 2;
            int object2RightBound = object2.Location.XCoordinate + object2.Image.Width / 2;
            int object2TopBound = object2.Location.YCoordinate - object2.Image.Height / 2;
            int object2BotBound = object2.Location.YCoordinate + object2.Image.Height / 2;

            if (object1LeftBound <= object2RightBound && object1LeftBound >= object2LeftBound)
            {
                if (object1TopBound >= object2TopBound && object1TopBound <= object2BotBound)
                {
                    return true;
                }

                if (object1BotBound >= object2TopBound && object1BotBound <= object2BotBound)
                {
                    return true;
                }
            }

            if (object1RightBound <= object2RightBound && object1RightBound >= object2LeftBound)
            {
                if (object1TopBound >= object2TopBound && object1TopBound <= object2BotBound)
                {
                    return true;
                }

                if (object1BotBound >= object2TopBound && object1BotBound <= object2BotBound)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
