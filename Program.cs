using System;
using Bullseye.Internal;
using McMaster.Extensions.CommandLineUtils;
using static Bullseye.Targets;
using static SimpleExec.Command;

namespace BullseyeMcMaster
{
    class Program
    {
        static void Main(string[] args) =>
            CommandLineApplication.Execute<Program>(args);

        [Option(ShortName = "sw", Description = "say what")]
        public string SayWhat { get; }

        public string[] RemainingArgs { get; }

        public void OnExecute()
        {
            Target("default", () => Run("echo", SayWhat));

            RunTargetsAndExit(RemainingArgs);
        }
    }
}
