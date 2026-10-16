namespace UnityEngine;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[NativeHeader("Configuration/UnityConfigure.h")]
[RequiredByNativeCode]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer; //Field offset: 0x8
		private int currentIndex; //Field offset: 0xC

		public override object Current
		{
			 get { } //Length: 129
		}

		internal Enumerator(Transform outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	public int childCount
	{
		[NativeMethod("GetChildrenCount")]
		 get { } //Length: 96
	}

	[NativeConditional("UNITY_EDITOR")]
	internal bool constrainProportionsScale
	{
		internal get { } //Length: 96
		internal set { } //Length: 99
	}

	public Vector3 eulerAngles
	{
		 get { } //Length: 170
		 set { } //Length: 184
	}

	public Vector3 forward
	{
		 get { } //Length: 238
		 set { } //Length: 146
	}

	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged
	{
		 get { } //Length: 96
		 set { } //Length: 99
	}

	public int hierarchyCapacity
	{
		 get { } //Length: 96
		 set { } //Length: 99
	}

	public int hierarchyCount
	{
		 get { } //Length: 96
	}

	public Vector3 localEulerAngles
	{
		 get { } //Length: 170
		 set { } //Length: 184
	}

	public Vector3 localPosition
	{
		 get { } //Length: 118
		 set { } //Length: 100
	}

	public Quaternion localRotation
	{
		 get { } //Length: 110
		 set { } //Length: 100
	}

	public Vector3 localScale
	{
		 get { } //Length: 118
		 set { } //Length: 100
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 117
	}

	public Vector3 lossyScale
	{
		[NativeMethod("GetWorldScaleLossy")]
		 get { } //Length: 118
	}

	public Transform parent
	{
		 get { } //Length: 118
		 set { } //Length: 252
	}

	internal Transform parentInternal
	{
		internal get { } //Length: 118
		internal set { } //Length: 145
	}

	public Vector3 position
	{
		 get { } //Length: 118
		 set { } //Length: 100
	}

	public Vector3 right
	{
		 get { } //Length: 238
		 set { } //Length: 203
	}

	public Transform root
	{
		 get { } //Length: 118
	}

	public Quaternion rotation
	{
		 get { } //Length: 110
		 set { } //Length: 100
	}

	[NativeConditional("UNITY_EDITOR")]
	internal RotationOrder rotationOrder
	{
		internal get { } //Length: 96
		internal set { } //Length: 99
	}

	public Vector3 up
	{
		 get { } //Length: 238
		 set { } //Length: 203
	}

	public Matrix4x4 worldToLocalMatrix
	{
		 get { } //Length: 117
	}

	protected Transform() { }

	[FreeFunction("DetachChildren", HasExplicitThis = True)]
	public void DetachChildren() { }

	private static void DetachChildren_Injected(IntPtr _unity_self) { }

	public Transform Find(string n) { }

	[Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", False)]
	public Transform FindChild(string n) { }

	[FreeFunction(HasExplicitThis = True)]
	private Transform FindRelativeTransformWithPath(string path, bool isActiveOnly) { }

	private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ref ManagedSpanWrapper path, bool isActiveOnly) { }

	[NativeMethod("GetChildrenCount")]
	public int get_childCount() { }

	private static int get_childCount_Injected(IntPtr _unity_self) { }

	internal bool get_constrainProportionsScale() { }

	public Vector3 get_eulerAngles() { }

	public Vector3 get_forward() { }

	public bool get_hasChanged() { }

	private static bool get_hasChanged_Injected(IntPtr _unity_self) { }

	public int get_hierarchyCapacity() { }

	public int get_hierarchyCount() { }

	public Vector3 get_localEulerAngles() { }

	public Vector3 get_localPosition() { }

	private static void get_localPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_localRotation() { }

	private static void get_localRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public Vector3 get_localScale() { }

	private static void get_localScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[NativeMethod("GetWorldScaleLossy")]
	public Vector3 get_lossyScale() { }

	private static void get_lossyScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Transform get_parent() { }

	internal Transform get_parentInternal() { }

	public Vector3 get_position() { }

	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Vector3 get_right() { }

	public Transform get_root() { }

	public Quaternion get_rotation() { }

	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	internal RotationOrder get_rotationOrder() { }

	public Vector3 get_up() { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	public Transform GetChild(int index) { }

	private static IntPtr GetChild_Injected(IntPtr _unity_self, int index) { }

	[NativeMethod("GetChildrenCount")]
	[Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", False)]
	public int GetChildCount() { }

	private static int GetChildCount_Injected(IntPtr _unity_self) { }

	public override IEnumerator GetEnumerator() { }

	internal Vector3 GetLocalEulerAngles(RotationOrder order) { }

	private static void GetLocalEulerAngles_Injected(IntPtr _unity_self, RotationOrder order, out Vector3 ret) { }

	public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation) { }

	private static void GetLocalPositionAndRotation_Injected(IntPtr _unity_self, out Vector3 localPosition, out Quaternion localRotation) { }

	private Transform GetParent() { }

	private static IntPtr GetParent_Injected(IntPtr _unity_self) { }

	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation) { }

	private static void GetPositionAndRotation_Injected(IntPtr _unity_self, out Vector3 position, out Quaternion rotation) { }

	private Transform GetRoot() { }

	private static IntPtr GetRoot_Injected(IntPtr _unity_self) { }

	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("GetRotationOrder")]
	internal int GetRotationOrderInternal() { }

	private static int GetRotationOrderInternal_Injected(IntPtr _unity_self) { }

	public int GetSiblingIndex() { }

	private static int GetSiblingIndex_Injected(IntPtr _unity_self) { }

	[FreeFunction("GetHierarchyCapacity", HasExplicitThis = True)]
	private int internal_getHierarchyCapacity() { }

	private static int internal_getHierarchyCapacity_Injected(IntPtr _unity_self) { }

	[FreeFunction("GetHierarchyCount", HasExplicitThis = True)]
	private int internal_getHierarchyCount() { }

	private static int internal_getHierarchyCount_Injected(IntPtr _unity_self) { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	private static void Internal_LookAt_Injected(IntPtr _unity_self, in Vector3 worldPosition, in Vector3 worldUp) { }

	[FreeFunction("SetHierarchyCapacity", HasExplicitThis = True)]
	private void internal_setHierarchyCapacity(int value) { }

	private static void internal_setHierarchyCapacity_Injected(IntPtr _unity_self, int value) { }

	public Vector3 InverseTransformDirection(Vector3 direction) { }

	public Vector3 InverseTransformDirection(float x, float y, float z) { }

	private static void InverseTransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	public void InverseTransformDirections(Span<Vector3> directions) { }

	public void InverseTransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	[NativeMethod(Name = "InverseTransformDirections")]
	internal void InverseTransformDirectionsInternal(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	private static void InverseTransformDirectionsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper directions, ref ManagedSpanWrapper transformedDirections) { }

	public Vector3 InverseTransformPoint(float x, float y, float z) { }

	public Vector3 InverseTransformPoint(Vector3 position) { }

	private static void InverseTransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public void InverseTransformPoints(Span<Vector3> positions) { }

	public void InverseTransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	[NativeMethod(Name = "InverseTransformPoints")]
	internal void InverseTransformPointsInternal(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	private static void InverseTransformPointsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions, ref ManagedSpanWrapper transformedPositions) { }

	public Vector3 InverseTransformVector(Vector3 vector) { }

	public Vector3 InverseTransformVector(float x, float y, float z) { }

	private static void InverseTransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	public void InverseTransformVectors(Span<Vector3> vectors) { }

	public void InverseTransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	[NativeMethod(Name = "InverseTransformVectors")]
	internal void InverseTransformVectorsInternal(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	private static void InverseTransformVectorsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper vectors, ref ManagedSpanWrapper transformedVectors) { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	public bool IsChildOf(Transform parent) { }

	private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent) { }

	[NativeConditional("UNITY_EDITOR")]
	private bool IsConstrainProportionsScale() { }

	private static bool IsConstrainProportionsScale_Injected(IntPtr _unity_self) { }

	[FreeFunction("IsNonUniformScaleTransform", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	internal bool IsNonUniformScaleTransform() { }

	private static bool IsNonUniformScaleTransform_Injected(IntPtr _unity_self) { }

	public void LookAt(Transform target, Vector3 worldUp) { }

	public void LookAt(Transform target) { }

	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	public void LookAt(Vector3 worldPosition) { }

	[NativeMethod("MoveAfterSiblingInternal")]
	internal void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty) { }

	private static void MoveAfterSibling_Injected(IntPtr _unity_self, IntPtr transform, bool notifyEditorAndMarkDirty) { }

	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	public void Rotate(Vector3 axis, float angle) { }

	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo) { }

	public void Rotate(Vector3 eulers) { }

	public void Rotate(Vector3 eulers, Space relativeTo) { }

	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[Obsolete("warning use Transform.Rotate instead.")]
	public void RotateAround(Vector3 axis, float angle) { }

	private static void RotateAround_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	[NativeMethod("RotateAround")]
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	private static void RotateAroundInternal_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	[Obsolete("warning use Transform.Rotate instead.")]
	public void RotateAroundLocal(Vector3 axis, float angle) { }

	private static void RotateAroundLocal_Injected(IntPtr _unity_self, in Vector3 axis, float angle) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void SendTransformChangedScale() { }

	private static void SendTransformChangedScale_Injected(IntPtr _unity_self) { }

	internal void set_constrainProportionsScale(bool value) { }

	public void set_eulerAngles(Vector3 value) { }

	public void set_forward(Vector3 value) { }

	public void set_hasChanged(bool value) { }

	private static void set_hasChanged_Injected(IntPtr _unity_self, bool value) { }

	public void set_hierarchyCapacity(int value) { }

	public void set_localEulerAngles(Vector3 value) { }

	public void set_localPosition(Vector3 value) { }

	private static void set_localPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	private static void set_localRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	public void set_localScale(Vector3 value) { }

	private static void set_localScale_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_parent(Transform value) { }

	internal void set_parentInternal(Transform value) { }

	public void set_position(Vector3 value) { }

	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_right(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	internal void set_rotationOrder(RotationOrder value) { }

	public void set_up(Vector3 value) { }

	public void SetAsFirstSibling() { }

	private static void SetAsFirstSibling_Injected(IntPtr _unity_self) { }

	public void SetAsLastSibling() { }

	private static void SetAsLastSibling_Injected(IntPtr _unity_self) { }

	[NativeConditional("UNITY_EDITOR")]
	private void SetConstrainProportionsScale(bool isLinked) { }

	private static void SetConstrainProportionsScale_Injected(IntPtr _unity_self, bool isLinked) { }

	internal void SetLocalEulerAngles(Vector3 euler, RotationOrder order) { }

	private static void SetLocalEulerAngles_Injected(IntPtr _unity_self, in Vector3 euler, RotationOrder order) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void SetLocalEulerHint(Vector3 euler) { }

	private static void SetLocalEulerHint_Injected(IntPtr _unity_self, in Vector3 euler) { }

	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	private static void SetLocalPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 localPosition, in Quaternion localRotation) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	public void SetParent(Transform parent, bool worldPositionStays) { }

	public void SetParent(Transform p) { }

	private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays) { }

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	private static void SetPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	[NativeConditional("UNITY_EDITOR")]
	[NativeMethod("SetRotationOrder")]
	internal void SetRotationOrderInternal(RotationOrder rotationOrder) { }

	private static void SetRotationOrderInternal_Injected(IntPtr _unity_self, RotationOrder rotationOrder) { }

	public void SetSiblingIndex(int index) { }

	private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index) { }

	public Vector3 TransformDirection(Vector3 direction) { }

	public Vector3 TransformDirection(float x, float y, float z) { }

	private static void TransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	public void TransformDirections(Span<Vector3> directions) { }

	public void TransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	[NativeMethod(Name = "TransformDirections")]
	internal void TransformDirectionsInternal(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections) { }

	private static void TransformDirectionsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper directions, ref ManagedSpanWrapper transformedDirections) { }

	public Vector3 TransformPoint(float x, float y, float z) { }

	public Vector3 TransformPoint(Vector3 position) { }

	private static void TransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public void TransformPoints(Span<Vector3> positions) { }

	public void TransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	[NativeMethod(Name = "TransformPoints")]
	internal void TransformPointsInternal(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions) { }

	private static void TransformPointsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions, ref ManagedSpanWrapper transformedPositions) { }

	public Vector3 TransformVector(float x, float y, float z) { }

	public Vector3 TransformVector(Vector3 vector) { }

	private static void TransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	public void TransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	public void TransformVectors(Span<Vector3> vectors) { }

	[NativeMethod(Name = "TransformVectors")]
	internal void TransformVectorsInternal(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors) { }

	private static void TransformVectorsInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper vectors, ref ManagedSpanWrapper transformedVectors) { }

	public void Translate(float x, float y, float z, Space relativeTo) { }

	public void Translate(float x, float y, float z) { }

	public void Translate(Vector3 translation, Transform relativeTo) { }

	public void Translate(Vector3 translation, Space relativeTo) { }

	public void Translate(Vector3 translation) { }

	public void Translate(float x, float y, float z, Transform relativeTo) { }

}

