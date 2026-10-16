namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType::DoubleColon (2))]
public sealed class Gizmos
{

	public static Color color
	{
		 set { } //Length: 41
	}

	public static Matrix4x4 matrix
	{
		 set { } //Length: 41
	}

	[NativeThrows]
	public static void DrawCube(Vector3 center, Vector3 size) { }

	private static void DrawCube_Injected(in Vector3 center, in Vector3 size) { }

	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	private static void DrawLine_Injected(in Vector3 from, in Vector3 to) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh) { }

	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrows]
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	private static void DrawMesh_Injected(IntPtr mesh, int submeshIndex, in Vector3 position, in Quaternion rotation, in Vector3 scale) { }

	[NativeThrows]
	public static void DrawSphere(Vector3 center, float radius) { }

	private static void DrawSphere_Injected(in Vector3 center, float radius) { }

	[NativeThrows]
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	private static void DrawWireCube_Injected(in Vector3 center, in Vector3 size) { }

	[NativeThrows]
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	private static void DrawWireMesh_Injected(IntPtr mesh, int submeshIndex, in Vector3 position, in Quaternion rotation, in Vector3 scale) { }

	[NativeThrows]
	public static void DrawWireSphere(Vector3 center, float radius) { }

	private static void DrawWireSphere_Injected(in Vector3 center, float radius) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(in Color value) { }

	public static void set_matrix(Matrix4x4 value) { }

	private static void set_matrix_Injected(in Matrix4x4 value) { }

}

