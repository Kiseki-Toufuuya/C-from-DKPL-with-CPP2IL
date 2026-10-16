namespace XeApp.Game.Net;

public class StaminaCalculator
{
	private const int OVER_MAX_VALUE = 20; //Field offset: 0x0
	public const int MAX_VALUE = 10; //Field offset: 0x0
	private const int DEFAULT_HEAL_TIME = 400; //Field offset: 0x0
	private GuardLong savedTime; //Field offset: 0x8
	private GuardInt savedValue; //Field offset: 0x18
	private GuardInt maxValue; //Field offset: 0x20
	private GuardLong serverTime; //Field offset: 0x28
	public GuardIntArray healTimeTable; //Field offset: 0x38
	private int overMaxValue; //Field offset: 0x3C

	public long HealTime
	{
		 get { } //Length: 112
	}

	public int MaxValue
	{
		 get { } //Length: 73
		 set { } //Length: 69
	}

	public int OverMaxValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public long SavedTime
	{
		 get { } //Length: 73
		 set { } //Length: 48
	}

	public int SavedValue
	{
		 get { } //Length: 73
		 set { } //Length: 69
	}

	public long ServerTime
	{
		 get { } //Length: 73
		 set { } //Length: 48
	}

	public StaminaCalculator() { }

	public void Copy(StaminaCalculator src) { }

	[Conditional("GAME_DEBUG")]
	public void Dump(string place) { }

	public long get_HealTime() { }

	public int get_MaxValue() { }

	public int get_OverMaxValue() { }

	public long get_SavedTime() { }

	public int get_SavedValue() { }

	public long get_ServerTime() { }

	public int GetCurrentValue() { }

	public long GetMaxHealTime() { }

	public long GetNextStaminaHealTime() { }

	public int HealMaxTimeMinutes() { }

	public void LevelUp(int newMaxVal) { }

	public void set_MaxValue(int value) { }

	public void set_OverMaxValue(int value) { }

	public void set_SavedTime(long value) { }

	public void set_SavedValue(int value) { }

	public void set_ServerTime(long value) { }

	public bool TryConsume(int dec, bool test = true) { }

	public override bool TryHeal(int healValue, bool overLimit = true, bool test = true) { }

	public bool TryHealMax(bool overLimit = true, bool test = true) { }

}

