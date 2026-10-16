namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	internal bool allowConstantClipSamplingOptimization
	{
		internal get { } //Length: 98
		internal set { } //Length: 101
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 120
	}

	public bool animatePhysics
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool applyRootMotion
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Avatar avatar
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public Transform avatarRoot
	{
		 get { } //Length: 120
	}

	public Vector3 bodyPosition
	{
		 get { } //Length: 171
		 set { } //Length: 136
	}

	internal Vector3 bodyPositionInternal
	{
		[NativeMethod("GetBodyPosition")]
		internal get { } //Length: 120
		[NativeMethod("SetBodyPosition")]
		internal set { } //Length: 102
	}

	public Quaternion bodyRotation
	{
		 get { } //Length: 147
		 set { } //Length: 123
	}

	internal Quaternion bodyRotationInternal
	{
		[NativeMethod("GetBodyRotation")]
		internal get { } //Length: 112
		[NativeMethod("SetBodyRotation")]
		internal set { } //Length: 102
	}

	public AnimatorCullingMode cullingMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Vector3 deltaPosition
	{
		 get { } //Length: 120
	}

	public Quaternion deltaRotation
	{
		 get { } //Length: 112
	}

	public float feetPivotActive
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool fireEvents
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float gravityWeight
	{
		 get { } //Length: 102
	}

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		 get { } //Length: 98
	}

	public bool hasRootMotion
	{
		[NativeMethod("HasRootMotion")]
		 get { } //Length: 98
	}

	public bool hasTransformHierarchy
	{
		 get { } //Length: 98
	}

	public float humanScale
	{
		 get { } //Length: 102
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		 get { } //Length: 98
	}

	public bool isInitialized
	{
		[NativeMethod("IsInitialized")]
		 get { } //Length: 98
	}

	public bool isMatchingTarget
	{
		[NativeMethod("IsMatchingTarget")]
		 get { } //Length: 98
	}

	public bool isOptimizable
	{
		[NativeMethod("IsOptimizable")]
		 get { } //Length: 98
	}

	internal bool isRootPositionOrRotationControlledByCurves
	{
		[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
		internal get { } //Length: 98
	}

	[Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", False)]
	public bool keepAnimatorControllerStateOnDisable
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool keepAnimatorStateOnDisable
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int layerCount
	{
		 get { } //Length: 98
	}

	public bool layersAffectMassCenter
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float leftFeetBottomHeight
	{
		 get { } //Length: 102
	}

	[Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
	public bool linearVelocityBlending
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool logWarnings
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int parameterCount
	{
		 get { } //Length: 98
	}

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public Vector3 pivotPosition
	{
		 get { } //Length: 120
	}

	public float pivotWeight
	{
		 get { } //Length: 102
	}

	public PlayableGraph playableGraph
	{
		 get { } //Length: 121
	}

	public float playbackTime
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public AnimatorRecorderMode recorderMode
	{
		 get { } //Length: 98
	}

	public float recorderStartTime
	{
		 get { } //Length: 102
		 set { } //Length: 3
	}

	public float recorderStopTime
	{
		 get { } //Length: 102
		 set { } //Length: 3
	}

	public float rightFeetBottomHeight
	{
		 get { } //Length: 102
	}

	public Vector3 rootPosition
	{
		[NativeMethod("GetAvatarPosition")]
		 get { } //Length: 120
		[NativeMethod("SetAvatarPosition")]
		 set { } //Length: 102
	}

	public Quaternion rootRotation
	{
		[NativeMethod("GetAvatarRotation")]
		 get { } //Length: 112
		[NativeMethod("SetAvatarRotation")]
		 set { } //Length: 102
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public float speed
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool stabilizeFeet
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeConditional("UNITY_EDITOR")]
	internal bool supportsOnAnimatorMove
	{
		[NativeMethod("SupportsOnAnimatorMove")]
		internal get { } //Length: 98
	}

	public Vector3 targetPosition
	{
		 get { } //Length: 120
	}

	public Quaternion targetRotation
	{
		 get { } //Length: 112
	}

	public AnimatorUpdateMode updateMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Vector3 velocity
	{
		 get { } //Length: 120
	}

	public bool writeDefaultValuesOnDisable
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Animator() { }

	public void ApplyBuiltinRootMotion() { }

	private static void ApplyBuiltinRootMotion_Injected(IntPtr _unity_self) { }

	private void CheckIfInIKPass() { }

	internal void ClearInternalControllerPlayable() { }

	private static void ClearInternalControllerPlayable_Injected(IntPtr _unity_self) { }

	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	private static void CrossFade_Injected(IntPtr _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	private static void CrossFadeInFixedTime_Injected(IntPtr _unity_self, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void EvaluateController() { }

	private void EvaluateController(float deltaTime) { }

	private static void EvaluateController_Injected(IntPtr _unity_self, float deltaTime) { }

	[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
	public void ForceStateNormalizedTime(float normalizedTime) { }

	internal bool get_allowConstantClipSamplingOptimization() { }

	private static bool get_allowConstantClipSamplingOptimization_Injected(IntPtr _unity_self) { }

	public Vector3 get_angularVelocity() { }

	private static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public bool get_animatePhysics() { }

	private static bool get_animatePhysics_Injected(IntPtr _unity_self) { }

	public bool get_applyRootMotion() { }

	private static bool get_applyRootMotion_Injected(IntPtr _unity_self) { }

	public Avatar get_avatar() { }

	private static IntPtr get_avatar_Injected(IntPtr _unity_self) { }

	public Transform get_avatarRoot() { }

	private static IntPtr get_avatarRoot_Injected(IntPtr _unity_self) { }

	public Vector3 get_bodyPosition() { }

	[NativeMethod("GetBodyPosition")]
	internal Vector3 get_bodyPositionInternal() { }

	private static void get_bodyPositionInternal_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_bodyRotation() { }

	[NativeMethod("GetBodyRotation")]
	internal Quaternion get_bodyRotationInternal() { }

	private static void get_bodyRotationInternal_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public AnimatorCullingMode get_cullingMode() { }

	private static AnimatorCullingMode get_cullingMode_Injected(IntPtr _unity_self) { }

	public Vector3 get_deltaPosition() { }

	private static void get_deltaPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_deltaRotation() { }

	private static void get_deltaRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public float get_feetPivotActive() { }

	private static float get_feetPivotActive_Injected(IntPtr _unity_self) { }

	public bool get_fireEvents() { }

	private static bool get_fireEvents_Injected(IntPtr _unity_self) { }

	public float get_gravityWeight() { }

	private static float get_gravityWeight_Injected(IntPtr _unity_self) { }

	[NativeMethod("HasBoundPlayables")]
	public bool get_hasBoundPlayables() { }

	private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self) { }

	[NativeMethod("HasRootMotion")]
	public bool get_hasRootMotion() { }

	private static bool get_hasRootMotion_Injected(IntPtr _unity_self) { }

	public bool get_hasTransformHierarchy() { }

	private static bool get_hasTransformHierarchy_Injected(IntPtr _unity_self) { }

	public float get_humanScale() { }

	private static float get_humanScale_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsHuman")]
	public bool get_isHuman() { }

	private static bool get_isHuman_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsInitialized")]
	public bool get_isInitialized() { }

	private static bool get_isInitialized_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsMatchingTarget")]
	public bool get_isMatchingTarget() { }

	private static bool get_isMatchingTarget_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsOptimizable")]
	public bool get_isOptimizable() { }

	private static bool get_isOptimizable_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsRootTranslationOrRotationControllerByCurves")]
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	private static bool get_isRootPositionOrRotationControlledByCurves_Injected(IntPtr _unity_self) { }

	public bool get_keepAnimatorControllerStateOnDisable() { }

	public bool get_keepAnimatorStateOnDisable() { }

	private static bool get_keepAnimatorStateOnDisable_Injected(IntPtr _unity_self) { }

	public int get_layerCount() { }

	private static int get_layerCount_Injected(IntPtr _unity_self) { }

	public bool get_layersAffectMassCenter() { }

	private static bool get_layersAffectMassCenter_Injected(IntPtr _unity_self) { }

	public float get_leftFeetBottomHeight() { }

	private static float get_leftFeetBottomHeight_Injected(IntPtr _unity_self) { }

	public bool get_linearVelocityBlending() { }

	private static bool get_linearVelocityBlending_Injected(IntPtr _unity_self) { }

	public bool get_logWarnings() { }

	private static bool get_logWarnings_Injected(IntPtr _unity_self) { }

	public int get_parameterCount() { }

	private static int get_parameterCount_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	public AnimatorControllerParameter[] get_parameters() { }

	private static AnimatorControllerParameter[] get_parameters_Injected(IntPtr _unity_self) { }

	public Vector3 get_pivotPosition() { }

	private static void get_pivotPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public float get_pivotWeight() { }

	private static float get_pivotWeight_Injected(IntPtr _unity_self) { }

	public PlayableGraph get_playableGraph() { }

	public float get_playbackTime() { }

	private static float get_playbackTime_Injected(IntPtr _unity_self) { }

	public AnimatorRecorderMode get_recorderMode() { }

	private static AnimatorRecorderMode get_recorderMode_Injected(IntPtr _unity_self) { }

	public float get_recorderStartTime() { }

	public float get_recorderStopTime() { }

	public float get_rightFeetBottomHeight() { }

	private static float get_rightFeetBottomHeight_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetAvatarPosition")]
	public Vector3 get_rootPosition() { }

	private static void get_rootPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[NativeMethod("GetAvatarRotation")]
	public Quaternion get_rootRotation() { }

	private static void get_rootRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self) { }

	public float get_speed() { }

	private static float get_speed_Injected(IntPtr _unity_self) { }

	public bool get_stabilizeFeet() { }

	private static bool get_stabilizeFeet_Injected(IntPtr _unity_self) { }

	[NativeMethod("SupportsOnAnimatorMove")]
	internal bool get_supportsOnAnimatorMove() { }

	private static bool get_supportsOnAnimatorMove_Injected(IntPtr _unity_self) { }

	public Vector3 get_targetPosition() { }

	private static void get_targetPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_targetRotation() { }

	private static void get_targetRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public AnimatorUpdateMode get_updateMode() { }

	private static AnimatorUpdateMode get_updateMode_Injected(IntPtr _unity_self) { }

	public Vector3 get_velocity() { }

	private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public bool get_writeDefaultValuesOnDisable() { }

	private static bool get_writeDefaultValuesOnDisable_Injected(IntPtr _unity_self) { }

	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	private static int GetAnimatorClipInfoCount_Injected(IntPtr _unity_self, int layerIndex, bool current) { }

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	private static void GetAnimatorClipInfoInternal_Injected(IntPtr _unity_self, int layerIndex, bool isCurrent, object clips) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	private static void GetAnimatorStateInfo_Injected(IntPtr _unity_self, int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[NativeConditional("UNITY_EDITOR")]
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	private static void GetAnimatorStateName_Injected(IntPtr _unity_self, int layerIndex, bool current, out ManagedSpanWrapper ret) { }

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	private static void GetAnimatorTransitionInfo_Injected(IntPtr _unity_self, int layerIndex, out AnimatorTransitionInfo info) { }

	private ScriptableObject GetBehaviour(Type type) { }

	public T GetBehaviour() { }

	private static IntPtr GetBehaviour_Injected(IntPtr _unity_self, Type type) { }

	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	public T[] GetBehaviours() { }

	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod("GetBoneTransform")]
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	private static IntPtr GetBoneTransformInternal_Injected(IntPtr _unity_self, int humanBoneId) { }

	public bool GetBool(int id) { }

	public bool GetBool(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	private bool GetBoolID(int id) { }

	private static bool GetBoolID_Injected(IntPtr _unity_self, int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	private bool GetBoolString(string name) { }

	private static bool GetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = True)]
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	private static AnimatorClipInfo[] GetCurrentAnimatorClipInfo_Injected(IntPtr _unity_self, int layerIndex) { }

	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetCurrentGraph", HasExplicitThis = True)]
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	private static void GetCurrentGraph_Injected(IntPtr _unity_self, ref PlayableGraph graph) { }

	[NativeConditional("UNITY_EDITOR")]
	internal string GetCurrentStateName(int layerIndex) { }

	public float GetFloat(int id) { }

	public float GetFloat(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	private float GetFloatID(int id) { }

	private static float GetFloatID_Injected(IntPtr _unity_self, int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	private float GetFloatString(string name) { }

	private static float GetFloatString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	private static void GetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, out Vector3 ret) { }

	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	private static void GetGoalRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, out Quaternion ret) { }

	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	private static float GetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal) { }

	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	private static float GetGoalWeightRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal) { }

	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	private static void GetHintPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, out Vector3 ret) { }

	private float GetHintWeightPosition(AvatarIKHint hint) { }

	private static float GetHintWeightPosition_Injected(IntPtr _unity_self, AvatarIKHint hint) { }

	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	public int GetInteger(int id) { }

	public int GetInteger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	private int GetIntegerID(int id) { }

	private static int GetIntegerID_Injected(IntPtr _unity_self, int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = True)]
	private int GetIntegerString(string name) { }

	private static int GetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public int GetLayerIndex(string layerName) { }

	private static int GetLayerIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper layerName) { }

	public string GetLayerName(int layerIndex) { }

	private static void GetLayerName_Injected(IntPtr _unity_self, int layerIndex, out ManagedSpanWrapper ret) { }

	public float GetLayerWeight(int layerIndex) { }

	private static float GetLayerWeight_Injected(IntPtr _unity_self, int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = True)]
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	private static AnimatorClipInfo[] GetNextAnimatorClipInfo_Injected(IntPtr _unity_self, int layerIndex) { }

	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[NativeConditional("UNITY_EDITOR")]
	internal string GetNextStateName(int layerIndex) { }

	public AnimatorControllerParameter GetParameter(int index) { }

	[FreeFunction(Name = "AnimatorBindings::GetParameterInternal", HasExplicitThis = True)]
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	private static AnimatorControllerParameter GetParameterInternal_Injected(IntPtr _unity_self, int index) { }

	[Obsolete("GetQuaternion is deprecated.")]
	public Quaternion GetQuaternion(string name) { }

	[Obsolete("GetQuaternion is deprecated.")]
	public Quaternion GetQuaternion(int id) { }

	private float GetRecorderStartTime() { }

	private static float GetRecorderStartTime_Injected(IntPtr _unity_self) { }

	private float GetRecorderStopTime() { }

	private static float GetRecorderStopTime_Injected(IntPtr _unity_self) { }

	internal string GetStats() { }

	private static void GetStats_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Obsolete("GetVector is deprecated.")]
	public Vector3 GetVector(int id) { }

	[Obsolete("GetVector is deprecated.")]
	public Vector3 GetVector(string name) { }

	public bool HasState(int layerIndex, int stateID) { }

	private static bool HasState_Injected(IntPtr _unity_self, int layerIndex, int stateID) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = True)]
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	private static ScriptableObject[] InternalGetBehaviours_Injected(IntPtr _unity_self, Type type) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehavioursByKey", HasExplicitThis = True)]
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	private static ScriptableObject[] InternalGetBehavioursByKey_Injected(IntPtr _unity_self, int fullPathHash, int layerIndex, Type type) { }

	public void InterruptMatchTarget(bool completeMatch) { }

	public void InterruptMatchTarget() { }

	private static void InterruptMatchTarget_Injected(IntPtr _unity_self, bool completeMatch) { }

	internal bool IsBoneTransform(Transform transform) { }

	private static bool IsBoneTransform_Injected(IntPtr _unity_self, IntPtr transform) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", True)]
	public bool IsControlled(Transform transform) { }

	private bool IsInIKPass() { }

	private static bool IsInIKPass_Injected(IntPtr _unity_self) { }

	public bool IsInTransition(int layerIndex) { }

	private static bool IsInTransition_Injected(IntPtr _unity_self, int layerIndex) { }

	public bool IsParameterControlledByCurve(int id) { }

	public bool IsParameterControlledByCurve(string name) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	private bool IsParameterControlledByCurveID(int id) { }

	private static bool IsParameterControlledByCurveID_Injected(IntPtr _unity_self, int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = True)]
	private bool IsParameterControlledByCurveString(string name) { }

	private static bool IsParameterControlledByCurveString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	private static void MatchTarget_Injected(IntPtr _unity_self, in Vector3 matchPosition, in Quaternion matchRotation, int targetBodyPart, in MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void OnCullingModeChanged() { }

	private static void OnCullingModeChanged_Injected(IntPtr _unity_self) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void OnUpdateModeChanged() { }

	private static void OnUpdateModeChanged_Injected(IntPtr _unity_self) { }

	public void Play(string stateName) { }

	public void Play(string stateName, int layer) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	public void Play(int stateNameHash, int layer) { }

	public void Play(int stateNameHash) { }

	private static void Play_Injected(IntPtr _unity_self, int stateNameHash, int layer, float normalizedTime) { }

	public void PlayInFixedTime(int stateNameHash, int layer) { }

	public void PlayInFixedTime(int stateNameHash) { }

	public void PlayInFixedTime(string stateName, int layer) { }

	public void PlayInFixedTime(string stateName) { }

	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	private static void PlayInFixedTime_Injected(IntPtr _unity_self, int stateNameHash, int layer, float fixedTime) { }

	private void Rebind(bool writeDefaultValues) { }

	public void Rebind() { }

	private static void Rebind_Injected(IntPtr _unity_self, bool writeDefaultValues) { }

	public void ResetTrigger(int id) { }

	public void ResetTrigger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	private void ResetTriggerID(int id) { }

	private static void ResetTriggerID_Injected(IntPtr _unity_self, int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	private void ResetTriggerString(string name) { }

	private static void ResetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	internal string ResolveHash(int hash) { }

	private static void ResolveHash_Injected(IntPtr _unity_self, int hash, out ManagedSpanWrapper ret) { }

	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	private static void set_allowConstantClipSamplingOptimization_Injected(IntPtr _unity_self, bool value) { }

	public void set_animatePhysics(bool value) { }

	private static void set_animatePhysics_Injected(IntPtr _unity_self, bool value) { }

	public void set_applyRootMotion(bool value) { }

	private static void set_applyRootMotion_Injected(IntPtr _unity_self, bool value) { }

	public void set_avatar(Avatar value) { }

	private static void set_avatar_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_bodyPosition(Vector3 value) { }

	[NativeMethod("SetBodyPosition")]
	internal void set_bodyPositionInternal(Vector3 value) { }

	private static void set_bodyPositionInternal_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_bodyRotation(Quaternion value) { }

	[NativeMethod("SetBodyRotation")]
	internal void set_bodyRotationInternal(Quaternion value) { }

	private static void set_bodyRotationInternal_Injected(IntPtr _unity_self, in Quaternion value) { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	private static void set_cullingMode_Injected(IntPtr _unity_self, AnimatorCullingMode value) { }

	public void set_feetPivotActive(float value) { }

	private static void set_feetPivotActive_Injected(IntPtr _unity_self, float value) { }

	public void set_fireEvents(bool value) { }

	private static void set_fireEvents_Injected(IntPtr _unity_self, bool value) { }

	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	public void set_keepAnimatorStateOnDisable(bool value) { }

	private static void set_keepAnimatorStateOnDisable_Injected(IntPtr _unity_self, bool value) { }

	public void set_layersAffectMassCenter(bool value) { }

	private static void set_layersAffectMassCenter_Injected(IntPtr _unity_self, bool value) { }

	public void set_linearVelocityBlending(bool value) { }

	private static void set_linearVelocityBlending_Injected(IntPtr _unity_self, bool value) { }

	public void set_logWarnings(bool value) { }

	private static void set_logWarnings_Injected(IntPtr _unity_self, bool value) { }

	public void set_playbackTime(float value) { }

	private static void set_playbackTime_Injected(IntPtr _unity_self, float value) { }

	public void set_recorderStartTime(float value) { }

	public void set_recorderStopTime(float value) { }

	[NativeMethod("SetAvatarPosition")]
	public void set_rootPosition(Vector3 value) { }

	private static void set_rootPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	[NativeMethod("SetAvatarRotation")]
	public void set_rootRotation(Quaternion value) { }

	private static void set_rootRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_speed(float value) { }

	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	public void set_stabilizeFeet(bool value) { }

	private static void set_stabilizeFeet_Injected(IntPtr _unity_self, bool value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	private static void set_updateMode_Injected(IntPtr _unity_self, AnimatorUpdateMode value) { }

	public void set_writeDefaultValuesOnDisable(bool value) { }

	private static void set_writeDefaultValuesOnDisable_Injected(IntPtr _unity_self, bool value) { }

	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethod("SetBoneLocalRotation")]
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	private static void SetBoneLocalRotationInternal_Injected(IntPtr _unity_self, int humanBoneId, in Quaternion rotation) { }

	public void SetBool(int id, bool value) { }

	public void SetBool(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	private void SetBoolID(int id, bool value) { }

	private static void SetBoolID_Injected(IntPtr _unity_self, int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	private void SetBoolString(string name, bool value) { }

	private static void SetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, bool value) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	public void SetFloat(string name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	private void SetFloatID(int id, float value) { }

	private static void SetFloatID_Injected(IntPtr _unity_self, int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = True)]
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	private static void SetFloatIDDamp_Injected(IntPtr _unity_self, int id, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	private void SetFloatString(string name, float value) { }

	private static void SetFloatString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = True)]
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	private static void SetFloatStringDamp_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value, float dampTime, float deltaTime) { }

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	private static void SetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, in Vector3 goalPosition) { }

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	private static void SetGoalRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, in Quaternion goalRotation) { }

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	private static void SetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value) { }

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	private static void SetGoalWeightRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value) { }

	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	private static void SetHintPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, in Vector3 hintPosition) { }

	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	private static void SetHintWeightPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, float value) { }

	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	public void SetInteger(int id, int value) { }

	public void SetInteger(string name, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	private void SetIntegerID(int id, int value) { }

	private static void SetIntegerID_Injected(IntPtr _unity_self, int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	private void SetIntegerString(string name, int value) { }

	private static void SetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int value) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	private static void SetLayerWeight_Injected(IntPtr _unity_self, int layerIndex, float weight) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethod("SetLookAtPosition")]
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	private static void SetLookAtPositionInternal_Injected(IntPtr _unity_self, in Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	[NativeMethod("SetLookAtWeight")]
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	private static void SetLookAtWeightInternal_Injected(IntPtr _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[Obsolete("SetQuaternion is deprecated.")]
	public void SetQuaternion(int id, Quaternion value) { }

	[Obsolete("SetQuaternion is deprecated.")]
	public void SetQuaternion(string name, Quaternion value) { }

	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	private static void SetTarget_Injected(IntPtr _unity_self, AvatarTarget targetIndex, float targetNormalizedTime) { }

	public void SetTrigger(string name) { }

	public void SetTrigger(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	private void SetTriggerID(int id) { }

	private static void SetTriggerID_Injected(IntPtr _unity_self, int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	private void SetTriggerString(string name) { }

	private static void SetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Obsolete("SetVector is deprecated.")]
	public void SetVector(int id, Vector3 value) { }

	[Obsolete("SetVector is deprecated.")]
	public void SetVector(string name, Vector3 value) { }

	public void StartPlayback() { }

	private static void StartPlayback_Injected(IntPtr _unity_self) { }

	public void StartRecording(int frameCount) { }

	private static void StartRecording_Injected(IntPtr _unity_self, int frameCount) { }

	public void StopPlayback() { }

	private static void StopPlayback_Injected(IntPtr _unity_self) { }

	public void StopRecording() { }

	private static void StopRecording_Injected(IntPtr _unity_self) { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	public static int StringToHash(string name) { }

	private static int StringToHash_Injected(ref ManagedSpanWrapper name) { }

	[NativeMethod("UpdateWithDelta")]
	public void Update(float deltaTime) { }

	private static void Update_Injected(IntPtr _unity_self, float deltaTime) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void WriteDefaultPose() { }

	private static void WriteDefaultPose_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = True)]
	public void WriteDefaultValues() { }

	private static void WriteDefaultValues_Injected(IntPtr _unity_self) { }

}

