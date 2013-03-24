using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NDesk.Options;

namespace ThinkingHome.NooLite.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = string.Empty;
            byte? channel = null;
            byte level = 100;

            var p = new OptionSet() {
                { "a|action=", "the {NAME} of action to execute. (On, Off, SetLevel, Switch, Bind, Unbind)", v => action = v },                
                { "c|channel=", "the number of {CHANNEL} for the command. This must be between 0 to 7.", (byte v) => channel = v },
                { "l|level=",  "the {LEVEL} of brightness for the command. This must be an byte.", (byte v) => level = v },                    
            };

            try
            {
                p.Parse(args);

                if (!channel.HasValue)
                {
                    throw new Exception("The action has no value");
                }

                using (var adapter = new Pc118Adapter())
                {
                    if (adapter.OpenDevice())
                    {
                        Pc118Command cmd = (Pc118Command)System.Enum.Parse(typeof(Pc118Command), action, true);
                        adapter.SendCommand(cmd, channel.Value, level);
                        System.Console.WriteLine(string.Format("command {0} execute succeful", action));
                    }
                    else
                    {
                        System.Console.WriteLine("Can't connect to device");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("\nUsage:\n");
                p.WriteOptionDescriptions(System.Console.Out);
            }
        }

        static string EnterCommand()
        {
            System.Console.Write("\nEnter command: ");
            return System.Console.ReadLine();
        }
    }
}
