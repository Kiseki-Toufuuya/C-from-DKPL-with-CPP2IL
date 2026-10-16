namespace XeSys.uGUI;

public class uGUIInputControl : Singleton<uGUIInputControl>, IDisposable
{
	private List<RaycastResult> m_RaycastResultList; //Field offset: 0x8
	private int m_TouchMax; //Field offset: 0xC
	private bool m_DontUpdateFlg; //Field offset: 0x10

	public bool DontUpdateFlg
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int TouchMax
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uGUIInputControl() { }

	public override void Dispose() { }

	public bool get_DontUpdateFlg() { }

	public int get_TouchMax() { }

	public void set_DontUpdateFlg(bool value) { }

	public void set_TouchMax(int value) { }

	private void TouchUpdate() { }

	public void Update() { }

}

