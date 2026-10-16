namespace CriWare;

[AddComponentMenu("CRIWARE/CriManaMovieController")]
public class CriManaMovieController : CriManaMovieMaterial
{
	public Renderer target; //Field offset: 0x60
	public bool useOriginalMaterial; //Field offset: 0x64
	private Material originalMaterial; //Field offset: 0x68

	public CriManaMovieController() { }

	public virtual void CriInternalUpdate() { }

	protected virtual void OnMaterialAvailableChanged() { }

	public virtual void RenderTargetManualFinalize() { }

	public virtual bool RenderTargetManualSetup() { }

}

