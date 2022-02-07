using UnrealBuildTool;

public class CastVRTarget : TargetRules
{
	public CastVRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CastVR");
	}
}
