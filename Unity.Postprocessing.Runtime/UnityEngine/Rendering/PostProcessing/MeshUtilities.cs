namespace UnityEngine.Rendering.PostProcessing;

internal static class MeshUtilities
{
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; //Field offset: 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; //Field offset: 0x4

	private static MeshUtilities() { }

	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

	internal static Mesh GetColliderMesh(Collider collider) { }

	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

}

