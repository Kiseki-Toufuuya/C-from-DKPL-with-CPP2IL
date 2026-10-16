namespace CriWare.CriMana.Detail;

public static class AutoResisterRendererResourceFactories
{
	[Preserve]
	[RendererResourceFactoryPriority(7050)]
	internal class RendererResourceFactoryH264Yuv : RendererResourceFactory
	{

		public RendererResourceFactoryH264Yuv() { }

		public virtual RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

		protected virtual void OnDisposeManaged() { }

		protected virtual void OnDisposeUnmanaged() { }

	}

	[Preserve]
	[RendererResourceFactoryPriority(10000)]
	internal class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory
	{

		public RendererResourceFactorySofdecPrimeYuvRawData() { }

		public virtual RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

		protected virtual void OnDisposeManaged() { }

		protected virtual void OnDisposeUnmanaged() { }

	}


	public static void InvokeAutoRegister() { }

}

