using System;
using Godot;

namespace DodgeTheCreeps;

public partial class DemoNode: Node
{
    public void Test()
    {
        GD.Load<PackedScene>("");
        GD.Load<PackedScene>("res://");
        GD.Load<PackedScene>("res://Scenes/...");
        GD.Load<PackedScene>("res://Scenes/../...");
        // GD.Load<PackedScene>("res://../...") (-> no suggestions provided, path leads outside project directory)
        ResourceLoader.Load<PackedScene>("");
        GD.Load<AudioStream>("res://...");
        GD.Load<AudioStreamMP3>("res://...");
        // GD.Load<AudioStreamSample>("res://...")
        GD.Load<Script>("res://Res");
        GD.Load<CSharpScript>("res://...");
    }
}
