namespace Heqet.Danmaku;

public class BombGaugeDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public BombGaugeDisp <>4__this; //Field offset: 0x8
		public int index; //Field offset: 0xC
		public TweenCallback <>9__1; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal void <ApplyBombIcon>b__0() { }

		internal void <ApplyBombIcon>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public BombGaugeDisp <>4__this; //Field offset: 0x8
		public int i; //Field offset: 0xC
		public TweenCallback <>9__0; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal void <BombCD>b__0() { }

	}

	private const string BOMBS = "icons"; //Field offset: 0x0
	private const float CD_TIMES = 3; //Field offset: 0x0
	private const float BOMB_MIN_ZOOM = 1; //Field offset: 0x0
	private const float BOMB_MAX_ZOOM = 5; //Field offset: 0x0
	private DanmakuLayer m_DanmakuLayer; //Field offset: 0x114
	private List<GameObject> m_BombIcons; //Field offset: 0x118
	private List<Material> m_BombMaterial; //Field offset: 0x11C
	private int m_CurrBombNum; //Field offset: 0x120
	private bool m_IsCD; //Field offset: 0x124

	public BombGaugeDisp() { }

	public void AddBomb() { }

	private void ApplyBombIcon(bool isAdd) { }

	private void BombCD() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public void RemoveBomb() { }

	public void SetBomb(int num) { }

	protected virtual void UpdateDispMain() { }

}

