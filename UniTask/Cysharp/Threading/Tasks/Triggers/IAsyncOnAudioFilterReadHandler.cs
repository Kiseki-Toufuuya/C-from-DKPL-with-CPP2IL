namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnAudioFilterReadHandler
{

	public UniTask<ValueTuple`2<Single[], Int32>> OnAudioFilterReadAsync() { }

}

