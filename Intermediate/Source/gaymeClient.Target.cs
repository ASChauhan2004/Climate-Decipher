using UnrealBuildTool;

public class gaymeClientTarget : TargetRules
{
	public gaymeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("gayme");
	}
}
