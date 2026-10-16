namespace CriWare;

public abstract class CriDisposable : IDisposable
{
	public Guid guid; //Field offset: 0x8

	public CriDisposable() { }

	public abstract void Dispose() { }

}

