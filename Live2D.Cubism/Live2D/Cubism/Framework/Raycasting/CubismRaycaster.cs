namespace Live2D.Cubism.Framework.Raycasting;

public sealed class CubismRaycaster : MonoBehaviour
{
	[CompilerGenerated]
	private CubismRenderer[] <Raycastables>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CubismRaycastablePrecision[] <RaycastablePrecisions>k__BackingField; //Field offset: 0x14

	private CubismRaycastablePrecision[] RaycastablePrecisions
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismRenderer[] Raycastables
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismRaycaster() { }

	[CompilerGenerated]
	private CubismRaycastablePrecision[] get_RaycastablePrecisions() { }

	[CompilerGenerated]
	private CubismRenderer[] get_Raycastables() { }

	private static bool LineExtentBoxIntersection(Bounds inBox, Vector3 start, Vector3 end, Vector3 extent, out Vector3 hitLocation, out Vector3 hitNormal, out float hitTime) { }

	public int Raycast(Vector3 origin, Vector3 direction, CubismRaycastHit[] result, float maximumDistance = 10000) { }

	public int Raycast(Ray ray, CubismRaycastHit[] result, float maximumDistance = 10000) { }

	private bool RaycastDrawable(Vector3 origin, Vector3 normalizedDirection, float length, CubismRaycastablePrecision precision, CubismRenderer renderer, out Vector3 hitPosition, out Vector3 hitNormal, out float hitTime) { }

	private bool RayIntersectMesh(Vector3 origin, Vector3 direction, float length, IReadOnlyList<Vector3> positions, Int32[] indices, out Vector3 hitPosition, out float hitTime) { }

	private bool RayIntersectTriangle(Vector3 origin, Vector3 direction, float length, Vector3 t0, Vector3 t1, Vector3 t2, out Vector3 hitPosition, out float hitTime) { }

	private void Refresh() { }

	[CompilerGenerated]
	private void set_RaycastablePrecisions(CubismRaycastablePrecision[] value) { }

	[CompilerGenerated]
	private void set_Raycastables(CubismRenderer[] value) { }

	private void Start() { }

}

