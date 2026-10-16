namespace UnityEngine;

[RequiredByNativeCode]
internal struct AnimationEventBlittable : IDisposable
{
	[ThreadStatic]
	private static GCHandlePool s_handlePool; //Field offset: 0x80000000
	internal float m_Time; //Field offset: 0x0
	internal IntPtr m_FunctionName; //Field offset: 0x4
	internal IntPtr m_StringParameter; //Field offset: 0x8
	internal IntPtr m_ObjectReferenceParameter; //Field offset: 0xC
	internal float m_FloatParameter; //Field offset: 0x10
	internal int m_IntParameter; //Field offset: 0x14
	internal int m_MessageOptions; //Field offset: 0x18
	internal AnimationEventSource m_Source; //Field offset: 0x1C
	internal IntPtr m_StateSender; //Field offset: 0x20
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x24
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x48

	public override void Dispose() { }

	internal static void DisposeEvents(IntPtr animationEventBlittableArray, int size) { }

	[FreeFunction(Name = "AnimationClipBindings::FreeEventsInternal")]
	private static void FreeEventsInternal(IntPtr value) { }

	internal static AnimationEventBlittable FromAnimationEvent(AnimationEvent animationEvent) { }

	internal static void FromAnimationEvents(AnimationEvent[] animationEvents, AnimationEventBlittable* animationEventBlittables) { }

	[RequiredByNativeCode]
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	internal static AnimationEvent[] PointerToAnimationEvents(IntPtr animationEventBlittableArray, int size) { }

	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

}

