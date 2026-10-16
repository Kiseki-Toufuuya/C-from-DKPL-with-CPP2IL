namespace XeApp.Game.Net;

public interface IFileProvider
{

	public LoadContext LoadRequest(string name, Action<LoadContext> onSuccess, Action<LoadContext> onError) { }

}

