#if TOOLS
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Godot;
using File = System.IO.File;

namespace DodgeTheCreeps.addons.Rider
{
    [Tool]
    public class EntryPoint : EditorPlugin
    {
        public override void _Ready()
        {
            var riderPath = GetRiderPathFromSettings();
            var dllFile = "/home/ivan-shakhov/Work/godot-support/resharper/build/GodotEditor/bin/Debug/net461/JetBrains.Rider.Godot.Editor.Plugin.dll"; // todo: get relatively to riderPath
            //var bytes = File.ReadAllBytes(dllFile); 
            //var assembly = AppDomain.CurrentDomain.Load(bytes); // doesn't lock assembly on disk

            var assembly = AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(dllFile));

            // call EntryPoint in the assembly with reflection
            var type = assembly.GetType("JetBrains.Rider.Godot.Editor.EntryPoint");
            RuntimeHelpers.RunClassConstructor(type.TypeHandle);

            var solutionName = (string)ProjectSettings.GetSetting("application/config/name");
            // todo: set static RiderPath and SolutionName in the EntryPoint
        }

        public static readonly string EditorPathSettingName = "mono/editor/editor_path_optional";

        private static string GetRiderPathFromSettings()
        {
            // todo: check that it is really Rider
            
            var editorSettings = new EntryPoint().GetEditorInterface().GetEditorSettings();
            if (editorSettings.HasSetting(EditorPathSettingName))
                return (string)editorSettings.GetSetting(EditorPathSettingName);
            return null;
        }
    }
}
#endif
