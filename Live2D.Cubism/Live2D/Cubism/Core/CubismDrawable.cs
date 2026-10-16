namespace Live2D.Cubism.Core;

[CubismDontMoveOnReimport]
public sealed class CubismDrawable : MonoBehaviour
{
	[CompilerGenerated]
	private CubismUnmanagedDrawables <UnmanagedDrawables>k__BackingField; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int _unmanagedIndex; //Field offset: 0x14
	private Color _multiplyColor; //Field offset: 0x18
	public Color _screenColor; //Field offset: 0x28

	public bool BlendAdditive
	{
		 get { } //Length: 54
	}

	public string Id
	{
		 get { } //Length: 43
	}

	public Int32[] Indices
	{
		 get { } //Length: 185
	}

	public bool IsDoubleSided
	{
		 get { } //Length: 54
	}

	public bool IsInverted
	{
		 get { } //Length: 54
	}

	public bool IsMasked
	{
		 get { } //Length: 46
	}

	public CubismDrawable[] Masks
	{
		 get { } //Length: 300
	}

	public bool MultiplyBlend
	{
		 get { } //Length: 54
	}

	public Color MultiplyColor
	{
		 get { } //Length: 166
	}

	public int ParentPartIndex
	{
		 get { } //Length: 41
	}

	public Color ScreenColor
	{
		 get { } //Length: 166
	}

	public int TextureIndex
	{
		 get { } //Length: 41
	}

	private CubismUnmanagedDrawables UnmanagedDrawables
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	internal int UnmanagedIndex
	{
		internal get { } //Length: 11
		private set { } //Length: 14
	}

	public int UnmanagedParentIndex
	{
		 get { } //Length: 41
	}

	public Vector3[] VertexPositions
	{
		 get { } //Length: 281
	}

	public Vector2[] VertexUvs
	{
		 get { } //Length: 253
	}

	public CubismDrawable() { }

	internal static GameObject CreateDrawables(CubismUnmanagedModel unmanagedModel) { }

	public bool get_BlendAdditive() { }

	public string get_Id() { }

	public Int32[] get_Indices() { }

	public bool get_IsDoubleSided() { }

	public bool get_IsInverted() { }

	public bool get_IsMasked() { }

	public CubismDrawable[] get_Masks() { }

	public bool get_MultiplyBlend() { }

	public Color get_MultiplyColor() { }

	public int get_ParentPartIndex() { }

	public Color get_ScreenColor() { }

	public int get_TextureIndex() { }

	[CompilerGenerated]
	private CubismUnmanagedDrawables get_UnmanagedDrawables() { }

	internal int get_UnmanagedIndex() { }

	public int get_UnmanagedParentIndex() { }

	public Vector3[] get_VertexPositions() { }

	public Vector2[] get_VertexUvs() { }

	private void Reset(CubismUnmanagedModel unmanagedModel, int unmanagedIndex) { }

	internal void Revive(CubismUnmanagedModel unmanagedModel) { }

	[CompilerGenerated]
	private void set_UnmanagedDrawables(CubismUnmanagedDrawables value) { }

	private void set_UnmanagedIndex(int value) { }

}

