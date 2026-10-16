namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

[CustomTrackedObject(typeof(MeshFilter), False)]
[DisplayName("Mesh Filter", null)]
public class TrackedMeshFilter : TrackedObject
{
	private const string k_MeshProperty = "m_Mesh"; //Field offset: 0x0
	private AsyncOperationHandle<Mesh> m_CurrentOperation; //Field offset: 0x14

	public TrackedMeshFilter() { }

	public virtual AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	public virtual bool CanTrackProperty(string propertyPath) { }

	private void MeshOperationCompleted(AsyncOperationHandle<Mesh> assetOp) { }

	private void SetMesh(Mesh mesh) { }

}

