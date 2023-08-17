using UnrealBuildTool;

public class ARApp5_1VersionTarget : TargetRules
{
	public ARApp5_1VersionTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ARApp5_1Version");
	}
}
