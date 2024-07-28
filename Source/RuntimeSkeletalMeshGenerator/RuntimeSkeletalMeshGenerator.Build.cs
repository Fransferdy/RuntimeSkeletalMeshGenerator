using UnrealBuildTool;

public class RuntimeSkeletalMeshGenerator : ModuleRules
{
	public RuntimeSkeletalMeshGenerator(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bUseUnity = false;
        PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"RenderCore",
				"RHI",
			});
	}
}
