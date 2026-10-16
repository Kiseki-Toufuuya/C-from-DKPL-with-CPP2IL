namespace Cysharp.Threading.Tasks;

public interface ITriggerHandler
{

	public ITriggerHandler<T> Next
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ITriggerHandler<T> Prev
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ITriggerHandler<T> get_Next() { }

	public ITriggerHandler<T> get_Prev() { }

	public void OnCompleted() { }

	public void OnNext(T value) { }

	public void set_Next(ITriggerHandler<T> value) { }

	public void set_Prev(ITriggerHandler<T> value) { }

}

