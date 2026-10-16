namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
[TupleElementNames(new IL2CPP_TYPE_STRING[] {"data", "channels"})]
public sealed class AsyncAudioFilterReadTrigger : AsyncTriggerBase<ValueTuple`2<Single[], Int32>>
{

	public AsyncAudioFilterReadTrigger() { }

	public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler() { }

	public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler(CancellationToken cancellationToken) { }

	private void OnAudioFilterRead(Single[] data, int channels) { }

	public UniTask<ValueTuple`2<Single[], Int32>> OnAudioFilterReadAsync() { }

	public UniTask<ValueTuple`2<Single[], Int32>> OnAudioFilterReadAsync(CancellationToken cancellationToken) { }

}

