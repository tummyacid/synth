using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            IEnumerable<double> keys = AudioDriver.Keyboard.Values;


            ConsoleKeyInfo keyDown = Console.ReadKey();
            List<System.ConsoleKey> keyboard = new List<ConsoleKey> {
                { System.ConsoleKey.Z},
                { System.ConsoleKey.S},
                { System.ConsoleKey.X},
                { System.ConsoleKey.D},
                { System.ConsoleKey.C},
                { System.ConsoleKey.V}};

            while (keyDown.Key != System.ConsoleKey.Q)
            {
                if (keyboard.Contains(keyDown.Key))
                {
                    //keyboard[keyDown.Key].
                }
                switch (keyDown.Key)
                {
                    case System.ConsoleKey.Z:
                        AudioDriver.PlaySin(AudioDriver.Keyboard["A[3]"], 200);
                        break;
                    case System.ConsoleKey.S:
                        AudioDriver.PlaySin(keys.ToArray()[60], 200);
                        break;
                    case System.ConsoleKey.X:
                        foreach (double freq in keys)
                        {
                            AudioDriver.PlaySin(freq, 20);
                            Thread.Sleep(40);
                        }
                        break;
                    case System.ConsoleKey.W:
                        foreach (double freq in keys)
                        {
                            AudioDriver.PlaySin(keys.ToArray()[rand.Next(0, keys.Count())], 20);
                            Thread.Sleep(30);
                        }

                        break;
                }
                keyDown = Console.ReadKey();
            }
        }
    }
}
