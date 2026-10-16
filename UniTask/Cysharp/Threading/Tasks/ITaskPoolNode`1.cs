namespace Cysharp.Threading.Tasks;

public interface ITaskPoolNode
{

	public T NextNode
	{
		 get { } //Length: 0
	}

	public T get_NextNode() { }

}

