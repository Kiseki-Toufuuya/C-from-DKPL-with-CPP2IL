namespace Heqet;

public class AutoSaveManager
{
	public static AutoSaveManager instance; //Field offset: 0x0
	private AutoSaveLayer m_currentLayer; //Field offset: 0x8

	public AutoSaveManager() { }

	public void Create() { }

	public void CreateLayer(int order_id = -1) { }

	public bool DoSave(bool isForce = false) { }

}

