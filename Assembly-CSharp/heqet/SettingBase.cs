namespace Heqet;

public class SettingBase
{
	internal class SettingDataBuf
	{
		internal struct Param
		{
			public float speed; //Field offset: 0x0
			public float sudden; //Field offset: 0x4
			public float hidden; //Field offset: 0x8

		}

		public float speed; //Field offset: 0x8
		public float sudden; //Field offset: 0xC
		public float hidden; //Field offset: 0x10
		private float speedBuf; //Field offset: 0x14
		private float suddenBuf; //Field offset: 0x18
		private float hiddenBuf; //Field offset: 0x1C

		public SettingDataBuf() { }

		public bool CheckChangeValue() { }

		public void Reset() { }

		public void Reset(Param _param) { }

	}

	protected readonly int SPECIFIED_POSITION_MIM_X; //Field offset: 0x8
	protected readonly int SPECIFIED_POSITION_MAX_X; //Field offset: 0xC
	protected readonly int SPECIFIED_POSITION_MIM_Y; //Field offset: 0x10
	protected readonly int SPECIFIED_POSITION_MAX_Y; //Field offset: 0x14
	protected SettingDispBase m_DispBase; //Field offset: 0x18
	protected int m_TabId; //Field offset: 0x1C

	public int CurrentTab
	{
		 get { } //Length: 11
	}

	public SettingBase() { }

	protected float CalcDecimal(float _value, int _dec) { }

	public void ClearTabActive() { }

	public void Close() { }

	public float CulcSpeedForLevel(int _level) { }

	public float CulcSpeedRatio(float _speed) { }

	public int get_CurrentTab() { }

	public override int GetTabCount() { }

	public override void ImmediateClose() { }

	public override void ImmediateOpen() { }

	public void Open() { }

	public override void Reset(int _tab) { }

	public override void SetupDisp() { }

	public override void Update() { }

}

