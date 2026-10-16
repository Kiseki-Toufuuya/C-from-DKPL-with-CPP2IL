namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/Animation.h")]
public sealed class Animation : Behaviour, IEnumerable
{
	private sealed class Enumerator : IEnumerator
	{
		private Animation m_Outer; //Field offset: 0x8
		private int m_CurrentIndex; //Field offset: 0xC

		public override object Current
		{
			 get { } //Length: 109
		}

		internal Enumerator(Animation outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	[Obsolete("Use cullingType instead")]
	public bool animateOnlyIfVisible
	{
		[FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = True)]
		 get { } //Length: 98
		[FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = True)]
		 set { } //Length: 101
	}

	public bool animatePhysics
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public AnimationClip clip
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public AnimationCullingType cullingType
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool isPlaying
	{
		[NativeName("IsPlaying")]
		 get { } //Length: 98
	}

	public AnimationState Item
	{
		 get { } //Length: 16
	}

	public Bounds localBounds
	{
		[NativeName("GetLocalAABB")]
		 get { } //Length: 117
		[NativeName("SetLocalAABB")]
		 set { } //Length: 102
	}

	public bool playAutomatically
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public AnimationUpdateMode updateMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public WrapMode wrapMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Animation() { }

	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	public void AddClip(AnimationClip clip, string newName) { }

	[ExcludeFromDocs]
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	private static void AddClip_Injected(IntPtr _unity_self, IntPtr clip, ref ManagedSpanWrapper newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	[ExcludeFromDocs]
	public void Blend(string animation) { }

	[ExcludeFromDocs]
	public void Blend(string animation, float targetWeight) { }

	public void Blend(string animation, float targetWeight, float fadeLength) { }

	private static void Blend_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, float targetWeight, float fadeLength) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation, float fadeLength) { }

	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation) { }

	private static void CrossFade_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = True)]
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	private static AnimationState CrossFadeQueued_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = True)]
	public bool get_animateOnlyIfVisible() { }

	private static bool get_animateOnlyIfVisible_Injected(IntPtr _unity_self) { }

	public bool get_animatePhysics() { }

	private static bool get_animatePhysics_Injected(IntPtr _unity_self) { }

	public AnimationClip get_clip() { }

	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	public AnimationCullingType get_cullingType() { }

	private static AnimationCullingType get_cullingType_Injected(IntPtr _unity_self) { }

	[NativeName("IsPlaying")]
	public bool get_isPlaying() { }

	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	public AnimationState get_Item(string name) { }

	[NativeName("GetLocalAABB")]
	public Bounds get_localBounds() { }

	private static void get_localBounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	public bool get_playAutomatically() { }

	private static bool get_playAutomatically_Injected(IntPtr _unity_self) { }

	public AnimationUpdateMode get_updateMode() { }

	private static AnimationUpdateMode get_updateMode_Injected(IntPtr _unity_self) { }

	public WrapMode get_wrapMode() { }

	private static WrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	public AnimationClip GetClip(string name) { }

	public int GetClipCount() { }

	private static int GetClipCount_Injected(IntPtr _unity_self) { }

	public override IEnumerator GetEnumerator() { }

	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	internal AnimationState GetState(string name) { }

	private static AnimationState GetState_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	internal AnimationState GetStateAtIndex(int index) { }

	private static AnimationState GetStateAtIndex_Injected(IntPtr _unity_self, int index) { }

	[NativeName("GetAnimationStateCount")]
	internal int GetStateCount() { }

	private static int GetStateCount_Injected(IntPtr _unity_self) { }

	public bool IsPlaying(string name) { }

	private static bool IsPlaying_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public bool Play(PlayMode mode) { }

	[ExcludeFromDocs]
	public bool Play(string animation) { }

	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocs]
	public bool Play() { }

	[Obsolete("use PlayMode instead of AnimationPlayMode.")]
	public bool Play(AnimationPlayMode mode) { }

	[Obsolete("use PlayMode instead of AnimationPlayMode.")]
	public bool Play(string animation, AnimationPlayMode mode) { }

	private static bool Play_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, PlayMode mode) { }

	[NativeName("Play")]
	private bool PlayDefaultAnimation(PlayMode mode) { }

	private static bool PlayDefaultAnimation_Injected(IntPtr _unity_self, PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState PlayQueued(string animation) { }

	[ExcludeFromDocs]
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = True)]
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	private static AnimationState PlayQueued_Injected(IntPtr _unity_self, ref ManagedSpanWrapper animation, QueueMode queue, PlayMode mode) { }

	public void RemoveClip(AnimationClip clip) { }

	public void RemoveClip(string clipName) { }

	private static void RemoveClip_Injected(IntPtr _unity_self, IntPtr clip) { }

	[NativeName("RemoveClip")]
	private void RemoveClipNamed(string clipName) { }

	private static void RemoveClipNamed_Injected(IntPtr _unity_self, ref ManagedSpanWrapper clipName) { }

	public void Rewind(string name) { }

	public void Rewind() { }

	private static void Rewind_Injected(IntPtr _unity_self) { }

	[NativeName("Rewind")]
	private void RewindNamed(string name) { }

	private static void RewindNamed_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public void Sample() { }

	private static void Sample_Injected(IntPtr _unity_self) { }

	[FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = True)]
	public void set_animateOnlyIfVisible(bool value) { }

	private static void set_animateOnlyIfVisible_Injected(IntPtr _unity_self, bool value) { }

	public void set_animatePhysics(bool value) { }

	private static void set_animatePhysics_Injected(IntPtr _unity_self, bool value) { }

	public void set_clip(AnimationClip value) { }

	private static void set_clip_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_cullingType(AnimationCullingType value) { }

	private static void set_cullingType_Injected(IntPtr _unity_self, AnimationCullingType value) { }

	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	public void set_playAutomatically(bool value) { }

	private static void set_playAutomatically_Injected(IntPtr _unity_self, bool value) { }

	public void set_updateMode(AnimationUpdateMode value) { }

	private static void set_updateMode_Injected(IntPtr _unity_self, AnimationUpdateMode value) { }

	public void set_wrapMode(WrapMode value) { }

	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	public void Stop(string name) { }

	public void Stop() { }

	private static void Stop_Injected(IntPtr _unity_self) { }

	[NativeName("Stop")]
	private void StopNamed(string name) { }

	private static void StopNamed_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public void SyncLayer(int layer) { }

	private static void SyncLayer_Injected(IntPtr _unity_self, int layer) { }

}

