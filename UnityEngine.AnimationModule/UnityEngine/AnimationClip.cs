namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion
{

	public bool empty
	{
		[NativeMethod("IsEmpty")]
		 get { } //Length: 98
	}

	public AnimationEvent[] events
	{
		 get { } //Length: 425
		 set { } //Length: 427
	}

	[NativeProperty("SampleRate", False, TargetType::Function (0))]
	public float frameRate
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool hasGenericRootTransform
	{
		[NativeMethod("HasGenericRootTransform")]
		 get { } //Length: 98
	}

	public bool hasMotionCurves
	{
		[NativeMethod("HasMotionCurves")]
		 get { } //Length: 98
	}

	public bool hasMotionFloatCurves
	{
		[NativeMethod("HasMotionFloatCurves")]
		 get { } //Length: 98
	}

	public bool hasRootCurves
	{
		[NativeMethod("HasRootCurves")]
		 get { } //Length: 98
	}

	internal bool hasRootMotion
	{
		[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
		internal get { } //Length: 98
	}

	public bool humanMotion
	{
		[NativeMethod("IsHumanMotion")]
		 get { } //Length: 98
	}

	public bool legacy
	{
		[NativeMethod("IsLegacy")]
		 get { } //Length: 98
		[NativeMethod("SetLegacy")]
		 set { } //Length: 101
	}

	[NativeProperty("Length", False, TargetType::Function (0))]
	public float length
	{
		 get { } //Length: 102
	}

	[NativeProperty("Bounds", False, TargetType::Function (0))]
	public Bounds localBounds
	{
		 get { } //Length: 117
		 set { } //Length: 102
	}

	[NativeProperty("StartTime", False, TargetType::Function (0))]
	internal float startTime
	{
		internal get { } //Length: 102
	}

	[NativeProperty("StopTime", False, TargetType::Function (0))]
	internal float stopTime
	{
		internal get { } //Length: 102
	}

	[NativeProperty("WrapMode", False, TargetType::Function (0))]
	public WrapMode wrapMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public AnimationClip() { }

	public void AddEvent(AnimationEvent evt) { }

	[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = True)]
	private void AddEventInternal(object evt) { }

	private static void AddEventInternal_Injected(IntPtr _unity_self, object evt) { }

	public void ClearCurves() { }

	private static void ClearCurves_Injected(IntPtr _unity_self) { }

	public void EnsureQuaternionContinuity() { }

	private static void EnsureQuaternionContinuity_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsEmpty")]
	public bool get_empty() { }

	private static bool get_empty_Injected(IntPtr _unity_self) { }

	public AnimationEvent[] get_events() { }

	public float get_frameRate() { }

	private static float get_frameRate_Injected(IntPtr _unity_self) { }

	[NativeMethod("HasGenericRootTransform")]
	public bool get_hasGenericRootTransform() { }

	private static bool get_hasGenericRootTransform_Injected(IntPtr _unity_self) { }

	[NativeMethod("HasMotionCurves")]
	public bool get_hasMotionCurves() { }

	private static bool get_hasMotionCurves_Injected(IntPtr _unity_self) { }

	[NativeMethod("HasMotionFloatCurves")]
	public bool get_hasMotionFloatCurves() { }

	private static bool get_hasMotionFloatCurves_Injected(IntPtr _unity_self) { }

	[NativeMethod("HasRootCurves")]
	public bool get_hasRootCurves() { }

	private static bool get_hasRootCurves_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	internal bool get_hasRootMotion() { }

	private static bool get_hasRootMotion_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsHumanMotion")]
	public bool get_humanMotion() { }

	private static bool get_humanMotion_Injected(IntPtr _unity_self) { }

	[NativeMethod("IsLegacy")]
	public bool get_legacy() { }

	private static bool get_legacy_Injected(IntPtr _unity_self) { }

	public float get_length() { }

	private static float get_length_Injected(IntPtr _unity_self) { }

	public Bounds get_localBounds() { }

	private static void get_localBounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	internal float get_startTime() { }

	private static float get_startTime_Injected(IntPtr _unity_self) { }

	internal float get_stopTime() { }

	private static float get_stopTime_Injected(IntPtr _unity_self) { }

	public WrapMode get_wrapMode() { }

	private static WrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = True)]
	private void GetEventsInternal(out IntPtr values, out int size) { }

	private static void GetEventsInternal_Injected(IntPtr _unity_self, out IntPtr values, out int size) { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	[FreeFunction]
	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	public void SampleAnimation(GameObject go, float time) { }

	private static void SampleAnimation_Injected(IntPtr go, IntPtr clip, float inTime, WrapMode wrapMode) { }

	public void set_events(AnimationEvent[] value) { }

	public void set_frameRate(float value) { }

	private static void set_frameRate_Injected(IntPtr _unity_self, float value) { }

	[NativeMethod("SetLegacy")]
	public void set_legacy(bool value) { }

	private static void set_legacy_Injected(IntPtr _unity_self, bool value) { }

	public void set_localBounds(Bounds value) { }

	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	public void set_wrapMode(WrapMode value) { }

	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	private static void SetCurve_Injected(IntPtr _unity_self, ref ManagedSpanWrapper relativePath, Type type, ref ManagedSpanWrapper propertyName, IntPtr curve) { }

	[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = True)]
	private void SetEventsInternal(Void* data, int length) { }

	private static void SetEventsInternal_Injected(IntPtr _unity_self, Void* data, int length) { }

}

