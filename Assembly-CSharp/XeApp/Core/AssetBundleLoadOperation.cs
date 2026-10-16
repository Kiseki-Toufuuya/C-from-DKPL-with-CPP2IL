namespace XeApp.Core;

public abstract class AssetBundleLoadOperation : IEnumerator
{
	[CompilerGenerated]
	private int <LoadRequestID>k__BackingField; //Field offset: 0x8

	public override object Current
	{
		 get { } //Length: 3
	}

	public int LoadRequestID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	protected AssetBundleLoadOperation() { }

	public override object get_Current() { }

	[CompilerGenerated]
	public int get_LoadRequestID() { }

	public abstract bool IsDone() { }

	public abstract bool IsError() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	[CompilerGenerated]
	public void set_LoadRequestID(int value) { }

	public abstract bool Update() { }

}

