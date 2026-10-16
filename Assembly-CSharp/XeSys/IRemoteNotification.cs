namespace XeSys;

public interface IRemoteNotification
{

	public string GetToken() { }

	public bool HasToken() { }

	public void Initialize() { }

	public bool IsInitialized() { }

	public void Register() { }

	public void Unregister() { }

}

