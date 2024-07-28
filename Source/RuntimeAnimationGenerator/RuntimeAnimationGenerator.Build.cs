using UnrealBuildTool;

public class RuntimeAnimationGenerator : ModuleRules
{
	public RuntimeAnimationGenerator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseUnity = false;
        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
			});
	}
}
