namespace XeSys.Gfx;

public class ScriptableLayout : ScriptableObject
{
	[SerializeField]
	private List<SerializableView> serializableViews; //Field offset: 0xC

	public int ViewsCount
	{
		 get { } //Length: 53
	}

	public ScriptableLayout() { }

	public void Deserialize(Layout layout) { }

	public int get_ViewsCount() { }

	public void Serialize(Layout layout) { }

}

