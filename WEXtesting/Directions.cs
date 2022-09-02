using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEXtesting
{
    public class Directions
    {
        string[] directions = new string[] { "NORTH", "SOUTH", "EAST", "WEST" };
        string[] plan = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };

        public static string[] DirReduc(string[] arr)
        {
            List<string> removed = new List<string>();
            List<string> result = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!removed.Where(x => x == arr[i]).Any())
                {
                    if (AreOpposite(arr[i], arr[i + 1]))
                    {
                        removed.Add(arr[i]);
                        removed.Add(arr[i + 1]);
                    }

                    if (AreEquals(arr[i], arr[i + 1]) && !removed.Any(c => c.Contains(arr[i])))
                    {
                        result.Add(arr[i]);
                    }
                }
            }

            return result.ToArray();
        }


        public static bool AreOpposite(string directionX, string directionY)
        {
            if (directionX.Contains("NORTH") && directionY.Contains("SOUTH")
                || directionX.Contains("SOUTH") && directionY.Contains("NORTH"))
            {
                return true;
            }

            if (directionX.Contains("WEST") && directionY.Contains("EAST")
                || directionX.Contains("EAST") && directionY.Contains("WEST"))
            {
                return true;
            }

            return false;
        }

        public static bool AreEquals(string directionX, string directionY)
        {
            if (directionX == directionY)
            {
                return true;
            }

            return false;
        }

    }
}
