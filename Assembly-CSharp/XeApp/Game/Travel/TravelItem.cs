namespace XeApp.Game.Travel;

public class TravelItem : DispBase
{
	internal enum eResult
	{
		Good = 0,
		Great = 1,
		Perfect = 2,
	}


	public TravelItem() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void LateUpdate() { }

	public void SetItem(int id, int num, bool is_new) { }

	public void SetParent(GameObject obj, string s) { }

	public void SetResultItem(eResult a, int b, int c, int d) { }

	protected virtual void UpdateDispMain() { }

}

