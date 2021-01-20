using System;
using System.Linq;
using Godot;
using Environment = System.Environment;
using Thread = System.Threading.Thread;

namespace RiderTestRunner
{
    public class Runner : Node
    {
        public override void _Ready()
        {
            var unitTestAssemblyPrefix = "--unit_test_assembly ";
            var unitTestArgsPrefix = "--unit_test_args ";

            var textNode = GetNode<RichTextLabel>("RichTextLabel");
            foreach (var arg in  OS.GetCmdlineArgs())
            {
                textNode.Text += Environment.NewLine + arg;
            }
            
            if (OS.GetCmdlineArgs().Length <4)
                return;

            var unitTestAssembly = OS.GetCmdlineArgs()[2];
            var unitTestArgs = OS.GetCmdlineArgs()[4].Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            // https://docs.microsoft.com/en-us/dotnet/api/system.appdomain.executeassembly?view=netframework-4.7.2
            AppDomain currentDomain = AppDomain.CurrentDomain;
            var thread = new Thread(() =>
            {
                currentDomain.ExecuteAssembly(unitTestAssembly, unitTestArgs);
            });
            thread.Start();

            WaitForThreadExit(thread);
        }

        private async void WaitForThreadExit(Thread thread)
        {
            while (thread.IsAlive)
            {
                await ToSignal(GetTree().CreateTimer(1), "timeout");
            }
        }
    }
}
