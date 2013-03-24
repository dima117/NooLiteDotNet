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

            bool show_help = true;
            List<string> commands = new List<string> ();
            int repeat = 1;

            while (true)
            {
                var p = new OptionSet() {
                    { "c|command=", "the {NAME} of command to execute.", v => commands.Add (v) },
                    { "l|level=",  "the level of brightness {TIMES} for the command.\n" + "this must be an integer.", (int v) => repeat = v },
                    { "h|help",  "show this message and exit", v => show_help = v != null },
                };

                ParseParameters(args, ref p);

                if (show_help)
                {
                    ShowHelp(p);
                    show_help = false;
                    args = EnterCommand().Split(' ');
                    ParseParameters(args, ref p);
                }

                using (PC118Adapter adapter = new PC118Adapter())
                {

                    while (!adapter.OpenDevice())
                    {
                        System.Console.WriteLine("Can't connect to device");
                        EnterCommand();
                    }

                    foreach (string command in commands)
                    {
                        for (int i = 0; i < repeat; ++i)
                        {
                            try
                            {
                                Pc118Command cmd = (Pc118Command)System.Enum.Parse(typeof(Pc118Command), command, true);
                                adapter.SendCommand(cmd, (byte)0, (byte)0);
                                System.Console.WriteLine(string.Format("command {0} execute succeful", command));
                            }
                            catch (ArgumentException e)
                            {
                                System.Console.WriteLine(e.Message);
                            }
                        }
                    }

                    args = EnterCommand().Split(' ');
                    ParseParameters(args, ref p);
                }
            }
        }

        static void ShowHelp(OptionSet p)
        {
            System.Console.WriteLine("List of commands: \n");
            foreach (string command in PC118Commands.GetCommandsList())
            {
                System.Console.WriteLine(command);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Usage:");
            p.WriteOptionDescriptions(System.Console.Out);
        }

        static string EnterCommand()
        {           
            System.Console.Write("\nEnter command: ");
            return System.Console.ReadLine();
        }

        static void ParseParameters(string[] args, ref OptionSet p)
        {
            try 
                {
                    p.Parse(args);
                }
                catch (OptionException e) {
                    System.Console.Write ("greet: ");
                    System.Console.WriteLine (e.Message);
                    System.Console.WriteLine ("Try `greet --help' for more information.");
                    return;
                }
        }
	}
}
