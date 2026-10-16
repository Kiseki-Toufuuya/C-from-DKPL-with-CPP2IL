namespace Heqet.Danmaku;

public abstract class DanmakuPlayableBehaviourBase : PlayableBehaviour
{
	public GameObject Owner; //Field offset: 0x8
	public Vector3 PositionOffset; //Field offset: 0xC
	[CompilerGenerated]
	private GameObject <GimmickObject>k__BackingField; //Field offset: 0x18

	public GameObject GimmickObject
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	protected DanmakuPlayableBehaviourBase() { }

	public abstract void CreateGimmickObject() { }

	public abstract void DestroyGimmickObject() { }

	[CompilerGenerated]
	public GameObject get_GimmickObject() { }

	public override void Prepare() { }

	public override void Process(FrameInfo info) { }

	[CompilerGenerated]
	protected void set_GimmickObject(GameObject value) { }

}

