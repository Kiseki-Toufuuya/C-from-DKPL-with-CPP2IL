namespace Cysharp.Threading.Tasks;

public interface IUniTaskSource : IUniTaskSource
{

	public T GetResult(short token) { }

}

