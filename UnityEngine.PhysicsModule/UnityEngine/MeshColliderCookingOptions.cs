namespace UnityEngine;

[Flags]
public enum MeshColliderCookingOptions
{
	None = 0,
	InflateConvexMesh = 1,
	CookForFasterSimulation = 2,
	EnableMeshCleaning = 4,
	WeldColocatedVertices = 8,
	UseFastMidphase = 16,
}

