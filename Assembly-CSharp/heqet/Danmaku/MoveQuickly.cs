namespace Heqet.Danmaku;

[RequireComponent(typeof(STGGimmick))]
public class MoveQuickly : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public DanmakuStageData danmakuStageData; //Field offset: 0x8
		public PlayerController playerController; //Field offset: 0xC

		public <>c__DisplayClass4_0() { }

		internal void <Execute>b__0() { }

	}

	[SerializeField]
	private GameObject endPos; //Field offset: 0x10
	public bool Reverse; //Field offset: 0x14
	[SerializeField]
	private float moveTime; //Field offset: 0x18
	private bool use; //Field offset: 0x1C

	public MoveQuickly() { }

	public void Execute() { }

	public void OnTriggerEnter(Collider other) { }

	public void OnTriggerExit(Collider other) { }

	public void OnTriggerStay(Collider other) { }

}

