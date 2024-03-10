using UnrealBuildTool;

public class gaymeEditorTarget : TargetRules
{
	public gaymeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("gayme");
	}
}
