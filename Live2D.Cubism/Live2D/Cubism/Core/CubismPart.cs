namespace Live2D.Cubism.Core;

[CubismDontMoveOnReimport]
public sealed class CubismPart : MonoBehaviour
{
	[CompilerGenerated]
	private CubismUnmanagedParts <UnmanagedParts>k__BackingField; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int _unmanagedIndex; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	public float Opacity; //Field offset: 0x18

	public string Id
	{
		 get { } //Length: 43
	}

	public private int UnmanagedIndex
	{
		 get { } //Length: 11
		private set { } //Length: 14
	}

	public int UnmanagedParentIndex
	{
		 get { } //Length: 47
	}

	private CubismUnmanagedParts UnmanagedParts
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismPart() { }

	internal static GameObject CreateParts(CubismUnmanagedModel unmanagedModel) { }

	public string get_Id() { }

	public int get_UnmanagedIndex() { }

	public int get_UnmanagedParentIndex() { }

	[CompilerGenerated]
	private CubismUnmanagedParts get_UnmanagedParts() { }

	private void Reset(CubismUnmanagedModel unmanagedModel, int unmanagedIndex) { }

	internal void Revive(CubismUnmanagedModel unmanagedModel) { }

	private void set_UnmanagedIndex(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedParts(CubismUnmanagedParts value) { }

}

