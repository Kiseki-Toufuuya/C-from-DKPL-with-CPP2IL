namespace XeSys.Gfx;

public class MaterialManager : Singleton<MaterialManager>, IDisposable
{
	private class MaterialInfo : IDisposable
	{
		[CompilerGenerated]
		private Material <material>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private int <level>k__BackingField; //Field offset: 0xC

		public private int level
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public private Material material
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 27
		}

		public MaterialInfo(Shader shd, int currentLevel) { }

		public override void Dispose() { }

		[CompilerGenerated]
		public int get_level() { }

		[CompilerGenerated]
		public Material get_material() { }

		public int GetInstanceID() { }

		[CompilerGenerated]
		private void set_level(int value) { }

		[CompilerGenerated]
		private void set_material(Material value) { }

	}

	private Dictionary<Int32, MaterialInfo> mDic; //Field offset: 0x8
	private List<Dictionary`2<Int32, MaterialInfo>> mStackAllocTable; //Field offset: 0xC
	private int mStackLevel; //Field offset: 0x10

	public MaterialManager() { }

	public Material Alloc(string shaderName) { }

	public Material Alloc(Shader shd) { }

	[Conditional("XESYS_DEBUG")]
	public void DisplayDebugLog() { }

	public override void Dispose() { }

	public void Free(Material target) { }

	public void FreeAll() { }

	private Dictionary<Int32, MaterialInfo> GetStackDic(int level) { }

	public void Pop() { }

	public void Push() { }

}

