namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheet
{
	[CompilerGenerated]
	private MaterialPropertyBlock <properties>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Material <material>k__BackingField; //Field offset: 0xC

	internal Material material
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private MaterialPropertyBlock properties
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	internal PropertySheet(Material material) { }

	public void ClearKeywords() { }

	public void DisableKeyword(string keyword) { }

	public void EnableKeyword(string keyword) { }

	[CompilerGenerated]
	internal Material get_material() { }

	[CompilerGenerated]
	public MaterialPropertyBlock get_properties() { }

	internal void Release() { }

	[CompilerGenerated]
	private void set_material(Material value) { }

	[CompilerGenerated]
	private void set_properties(MaterialPropertyBlock value) { }

}

