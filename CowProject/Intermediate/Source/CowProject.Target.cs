using UnrealBuildTool;

public class CowProjectTarget : TargetRules
{
	public CowProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CowProject");
	}
}
