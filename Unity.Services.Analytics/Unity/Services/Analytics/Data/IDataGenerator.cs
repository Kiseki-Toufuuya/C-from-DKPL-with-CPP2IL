namespace Unity.Services.Analytics.Data;

internal interface IDataGenerator
{

	public void ClientDevice(string callingMethodIdentifier) { }

	public void GameEnded(string callingMethodIdentifier, SessionEndState quitState) { }

	public void GameRunning(string callingMethodIdentifier) { }

	public void GameStarted(string callingMethodIdentifier) { }

	public void NewPlayer(string callingMethodIdentifier) { }

	public void SdkStartup(string callingMethodIdentifier) { }

}

