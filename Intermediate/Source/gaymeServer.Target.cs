using UnrealBuildTool;

public class gaymeServerTarget : TargetRules
{
	public gaymeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("gayme");
	}
}
