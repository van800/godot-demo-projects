//#if TOOLS

using System;
using System.Linq;
using Godot;
using Environment = System.Environment;

namespace DodgeTheCreeps.Rider
{
    public class EntryPoint : Node2D
    {
        private AppDomain otherDomain;
        public override void _Ready()
        {
            var unitTestAssemblyPrefix = "--unit_test_assembly ";
            var unitTestArgsPrefix = "--unit_test_args ";

            var textNode = GetNode<RichTextLabel>("RichTextLabel");
            foreach (var arg in  OS.GetCmdlineArgs())
            {
                textNode.Text += Environment.NewLine + arg;
            }
            
            // var main = (Main)ResourceLoader.Load<PackedScene>("res://Main.tscn").Instance();
            // GD.Print(main.Name);
            
            if (OS.GetCmdlineArgs().Length <4)
                return;

            var unitTestAssembly = OS.GetCmdlineArgs()[1];
            var unitTestArgs = OS.GetCmdlineArgs()[3].Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            // https://docs.microsoft.com/en-us/dotnet/api/system.appdomain.executeassembly?view=netframework-4.7.2
             otherDomain = AppDomain.CreateDomain("otherDomain");
             otherDomain.ExecuteAssembly(unitTestAssembly, unitTestArgs);
            
            //AppDomain currentDomain = AppDomain.CurrentDomain;
            //currentDomain.ExecuteAssembly(unitTestAssembly, unitTestArgs);
        }

        protected override void Dispose(bool disposing)
        {
            AppDomain.Unload(otherDomain);
            base.Dispose(disposing);
        }

        public static readonly string EditorPathSettingName = "mono/editor/editor_path_optional";

        // private static string GetRiderPathFromSettings()
        // {
        //     // todo: check that it is really Rider
        //     
        //     var editorSettings = new EntryPoint().GetEditorInterface().GetEditorSettings();
        //     if (editorSettings.HasSetting(EditorPathSettingName))
        //         return (string)editorSettings.GetSetting(EditorPathSettingName);
        //     return null;
        // }
    }
}
//#endif
