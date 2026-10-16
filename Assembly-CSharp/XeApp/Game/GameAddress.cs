namespace XeApp.Game;

public class GameAddress : Singleton<GameAddress>, IDisposable
{

	public GameAddress() { }

	public override void Dispose() { }

	public string GetStorageRootPath() { }

	public string GetUguiLayoutFontPath() { }

	public string GetUguiLayoutPrefabPath() { }

	public string GetUguiLayoutTexpackPath() { }

}

