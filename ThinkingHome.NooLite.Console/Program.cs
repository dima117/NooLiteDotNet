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
        static int verbosity;

		static void Main(string[] args)
		{
            bool show_help = false;
            List<string> commands = new List<string> ();
            int repeat = 1;

            var p = new OptionSet () {
                { "c|command=", "the {NAME} of command to execute.", v => commands.Add (v) },
                { "r|repeat=",  "the number of {TIMES} to repeat the command.\n" + "this must be an integer.", (int v) => repeat = v },
                { "v", "increase debug message verbosity", v => { if (v != null) ++verbosity; } },
                { "h|help",  "show this message and exit", 
                v => show_help = v != null },
            };

            List<string> extra;
            try 
            {
                extra = p.Parse (args);
            }
            catch (OptionException e) {
                System.Console.Write ("greet: ");
                System.Console.WriteLine (e.Message);
                System.Console.WriteLine ("Try `greet --help' for more information.");
                return;
            }

            if (show_help) {
                ShowHelp (p);
                System.Console.ReadLine();
            }

            string message;
            if (extra.Count > 0) {
                message = string.Join (" ", extra.ToArray ());
                Debug ("Using new message: {0}", message);
            }
            else {
                message = "Hello {0}!";
                Debug ("Using default message: {0}", message);
            }

            using (PC118Adapter adapter = new PC118Adapter())
            {
                adapter.OpenDevice();
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
                            throw new NotImplementedException();
                        }
                    }
                }
            }

            System.Console.ReadLine();
        }

        static void ShowHelp(OptionSet p)
        {
            System.Console.WriteLine("Usage: greet [OPTIONS]+ message");
            System.Console.WriteLine("Greet a list of individuals with an optional message.");
            System.Console.WriteLine("If no message is specified, a generic greeting is used.");
            System.Console.WriteLine();
            System.Console.WriteLine("Options:");
            p.WriteOptionDescriptions(System.Console.Out);
        }

        static void Debug(string format, params object[] args)
        {
            if (verbosity > 0)
            {
                System.Console.Write("# ");
                System.Console.WriteLine(format, args);
            }
        }
	}
}
