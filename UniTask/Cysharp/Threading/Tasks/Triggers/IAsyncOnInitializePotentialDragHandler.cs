namespace Cysharp.Threading.Tasks.Triggers;

public interface IAsyncOnInitializePotentialDragHandler
{

	public UniTask<PointerEventData> OnInitializePotentialDragAsync() { }

}

