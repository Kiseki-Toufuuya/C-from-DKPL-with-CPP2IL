namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnMoveHandler
{

	public UniTask<AxisEventData> OnMoveAsync() { }

}

