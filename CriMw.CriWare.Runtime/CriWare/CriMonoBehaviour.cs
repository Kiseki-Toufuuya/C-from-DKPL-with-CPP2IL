namespace CriWare;

public abstract class CriMonoBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	private Guid <guid>k__BackingField; //Field offset: 0x10

	public private Guid guid
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public CriMonoBehaviour() { }

	public abstract void CriInternalLateUpdate() { }

	public abstract void CriInternalUpdate() { }

	[CompilerGenerated]
	public Guid get_guid() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	[CompilerGenerated]
	private void set_guid(Guid value) { }

}

