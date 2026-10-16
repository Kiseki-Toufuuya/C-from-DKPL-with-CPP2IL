namespace UnityEngine;

[NativeHeader("Modules/Physics/Public/PhysicsSceneHandle.h")]
[NativeHeader("Modules/Physics/PhysicsQuery.h")]
public struct PhysicsScene : IEquatable<PhysicsScene>
{
	private int m_index; //Field offset: 0x0
	private int m_version; //Field offset: 0x4

	public virtual bool Equals(object other) { }

	public override bool Equals(PhysicsScene other) { }

	internal static PhysicsScene GetDefaultScene() { }

	public virtual int GetHashCode() { }

	[FreeFunction("Physics::Raycast")]
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool Internal_Raycast_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[FreeFunction("Physics::RaycastNonAlloc")]
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static int Internal_RaycastNonAlloc_Injected(in PhysicsScene physicsScene, in Ray ray, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[FreeFunction("Physics::RaycastTest")]
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static bool Internal_RaycastTest_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[FreeFunction("Physics::SphereCastNonAlloc")]
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static int Internal_SphereCastNonAlloc_Injected(in PhysicsScene physicsScene, in Vector3 origin, float radius, in Vector3 direction, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool op_Equality(PhysicsScene lhs, PhysicsScene rhs) { }

	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[FreeFunction("Physics::OverlapSphereNonAlloc")]
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static int OverlapSphereNonAlloc_Internal_Injected(in PhysicsScene physicsScene, in Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	public virtual string ToString() { }

}

