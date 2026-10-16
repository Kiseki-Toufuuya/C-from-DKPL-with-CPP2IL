namespace Cysharp.Threading.Tasks;

[Extension]
public static class UniTaskCancellationExtensions
{

	[Extension]
	public static CancellationToken GetCancellationTokenOnDestroy(MonoBehaviour monoBehaviour) { }

	[Extension]
	public static CancellationToken GetCancellationTokenOnDestroy(GameObject gameObject) { }

}

