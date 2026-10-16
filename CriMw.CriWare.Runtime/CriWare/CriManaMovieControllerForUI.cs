namespace CriWare;

[AddComponentMenu("CRIWARE/CriManaMovieControllerForUI")]
public class CriManaMovieControllerForUI : CriManaMovieMaterial
{
	public Graphic target; //Field offset: 0x60
	public bool useOriginalMaterial; //Field offset: 0x64
	private Material originalMaterial; //Field offset: 0x68

	public CriManaMovieControllerForUI() { }

	protected virtual void Awake() { }

	public virtual void CriInternalUpdate() { }

	protected virtual void OnMaterialAvailableChanged() { }

	public virtual void RenderTargetManualFinalize() { }

	public virtual bool RenderTargetManualSetup() { }

}

