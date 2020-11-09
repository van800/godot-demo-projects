using System;
using System.Linq;
using Godot;
using Environment = System.Environment;


namespace DodgeTheCreeps.Rider
{
    public class EntryPoint : Node2D
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

            var unitTestAssembly = OS.GetCmdlineArgs()[1];
            var unitTestArgs = OS.GetCmdlineArgs()[3].Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            // https://docs.microsoft.com/en-us/dotnet/api/system.appdomain.executeassembly?view=netframework-4.7.2
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.ExecuteAssembly(unitTestAssembly, unitTestArgs);
        }
    }
}
