namespace XeApp.Game;

public class GameEventScriptSelectInfo
{
	private List<String> m_SelectText; //Field offset: 0x8
	private int m_Result; //Field offset: 0xC
	private float m_Timer; //Field offset: 0x10
	private float m_Limit; //Field offset: 0x14
	private List<Int32> m_Point; //Field offset: 0x18

	public float Limit
	{
		 get { } //Length: 11
		 set { } //Length: 25
	}

	public List<Int32> Point
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public int Result
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public List<String> Text
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float Timer
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public bool TimeUp
	{
		 get { } //Length: 121
	}

	public GameEventScriptSelectInfo() { }

	public float get_Limit() { }

	public List<Int32> get_Point() { }

	public int get_Result() { }

	public List<String> get_Text() { }

	public float get_Timer() { }

	public bool get_TimeUp() { }

	public void set_Limit(float value) { }

	public void set_Point(List<Int32> value) { }

	public void set_Result(int value) { }

	public void set_Text(List<String> value) { }

	public void set_Timer(float value) { }

}

