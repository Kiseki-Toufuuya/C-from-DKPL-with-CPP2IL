namespace CriWare.CriMana.Detail;

public abstract class RendererResourceFactory : IDisposable
{
	private static SortedList<Int32, RendererResourceFactory> factoryList; //Field offset: 0x0
	private bool disposed; //Field offset: 0x8

	private static RendererResourceFactory() { }

	protected RendererResourceFactory() { }

	public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

	public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	public static void DisposeAllFactories() { }

	protected virtual void Finalize() { }

	protected abstract void OnDisposeManaged() { }

	protected abstract void OnDisposeUnmanaged() { }

	public static void RegisterFactory(RendererResourceFactory factory, int priority) { }

}

