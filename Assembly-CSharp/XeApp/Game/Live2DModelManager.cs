namespace XeApp.Game;

public class Live2DModelManager
{
	public static Live2DModelManager instance; //Field offset: 0x0
	private List<Live2DModel> modelList; //Field offset: 0x8

	public Live2DModelManager() { }

	public void Create() { }

	public Live2DModel CreateModel(string modelPath, string animePath) { }

	public void EnableActiveModel(bool inEnable) { }

	public void RefreshFreeModel() { }

	public void ReleaseModel(Live2DModel model) { }

	public void Update() { }

}

