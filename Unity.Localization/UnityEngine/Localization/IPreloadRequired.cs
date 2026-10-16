namespace UnityEngine.Localization;

public interface IPreloadRequired
{

	public AsyncOperationHandle PreloadOperation
	{
		 get { } //Length: 0
	}

	public AsyncOperationHandle get_PreloadOperation() { }

}

