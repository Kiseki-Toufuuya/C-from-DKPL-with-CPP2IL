namespace XeSys.Gfx;

public class SpriteEffectManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<EffectSortData> <>9__29_0; //Field offset: 0x4
		public static Comparison<EffectSortData> <>9__29_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Update>b__29_0(EffectSortData e1, EffectSortData e2) { }

		internal int <Update>b__29_1(EffectSortData e1, EffectSortData e2) { }

	}

	public const int DefaultDrawPriority = 1000; //Field offset: 0x0
	private static SpriteEffectManager m_Instance; //Field offset: 0x0
	private EffectSettingData m_DefaultEffectSetting; //Field offset: 0x8
	private EffectSettingData[] m_EffectSettings; //Field offset: 0x14
	private int m_EffectTypeNum; //Field offset: 0x18
	private float m_DefaultPixelPerUnit; //Field offset: 0x1C
	private SpriteEffect[] m_SpriteEffects; //Field offset: 0x20
	private Int32[] m_SpritePrioritys; //Field offset: 0x24
	private EffectSortData[] m_EffectSortDatas; //Field offset: 0x28
	private Queue<Int32>[] m_AvailableEffectIdxs; //Field offset: 0x2C
	private SpriteEffectMaterialVal m_SpriteEffectMaterialVal; //Field offset: 0x30

	public float DefaultPixelPerUnit
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public int EffectTypeNum
	{
		 get { } //Length: 11
	}

	public static SpriteEffectManager Instance
	{
		 get { } //Length: 40
	}

	private SpriteEffectManager(int effectTypeNum, int effectMax) { }

	public static void Create(int effectTypeNum, int effectMax) { }

	public int CreateEffect(int type) { }

	public float get_DefaultPixelPerUnit() { }

	public int get_EffectTypeNum() { }

	public static SpriteEffectManager get_Instance() { }

	public SpriteEffect GetEffect(int id) { }

	public static void Release() { }

	public void set_DefaultPixelPerUnit(float value) { }

	public void SetEffectSettingDatas(EffectSettingData[] datas) { }

	public void SetPixelPerUnit(int id, float pixelPerUnit) { }

	public void SetPosition(int id, float x, float y, float z) { }

	public void SetPriority(int id, int prio) { }

	public void SetRotate(int id, float x, float y, float z) { }

	public void SetScale(int id, float x, float y, float z) { }

	public void Update(DynamicPolygonManager polymanager, float dt, Camera camera, bool isZsort) { }

}

