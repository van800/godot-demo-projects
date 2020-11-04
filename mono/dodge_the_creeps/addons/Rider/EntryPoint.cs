#if TOOLS
using System;
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
            var dllFile = "/home/ivan-shakhov/Work/DefaultCompany/ClassLibrary9/ClassLibrary9/bin/Debug/net47/ClassLibrary9.dll"; // todo: get relatively to riderPath
            var bytes = File.ReadAllBytes(dllFile); 
            var assembly = AppDomain.CurrentDomain.Load(bytes); // doesn't lock assembly on disk
            
            // call EntryPoint in the assembly with reflection
            
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
