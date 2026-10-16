namespace UnityEngine.Playables;

[HelpURL("https://docs.unity3d.com/ScriptReference/Playables.PlayableDirector.html")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeHeader("Modules/Director/PlayableDirector.h")]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour, IExposedPropertyTable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PlayableDirector> played; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PlayableDirector> paused; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PlayableDirector> stopped; //Field offset: 0x14

	public double duration
	{
		 get { } //Length: 102
	}

	public DirectorWrapMode extrapolationMode
	{
		 get { } //Length: 98
	}

	public double initialTime
	{
		 set { } //Length: 111
	}

	public PlayableAsset playableAsset
	{
		 get { } //Length: 225
	}

	public PlayableGraph playableGraph
	{
		 get { } //Length: 121
	}

	public PlayState state
	{
		 get { } //Length: 98
	}

	public double time
	{
		 get { } //Length: 102
		 set { } //Length: 111
	}

	public PlayableDirector() { }

	[NativeThrows]
	public void Evaluate() { }

	private static void Evaluate_Injected(IntPtr _unity_self) { }

	public double get_duration() { }

	private static double get_duration_Injected(IntPtr _unity_self) { }

	public DirectorWrapMode get_extrapolationMode() { }

	public PlayableAsset get_playableAsset() { }

	public PlayableGraph get_playableGraph() { }

	public PlayState get_state() { }

	public double get_time() { }

	private static double get_time_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetBindingFor")]
	public object GetGenericBinding(object key) { }

	private static IntPtr GetGenericBinding_Injected(IntPtr _unity_self, IntPtr key) { }

	private PlayableGraph GetGraphHandle() { }

	private static void GetGraphHandle_Injected(IntPtr _unity_self, out PlayableGraph ret) { }

	private PlayState GetPlayState() { }

	private static PlayState GetPlayState_Injected(IntPtr _unity_self) { }

	public override object GetReferenceValue(PropertyName id, out bool idValid) { }

	private static IntPtr GetReferenceValue_Injected(IntPtr _unity_self, in PropertyName id, out bool idValid) { }

	private DirectorWrapMode GetWrapMode() { }

	private static DirectorWrapMode GetWrapMode_Injected(IntPtr _unity_self) { }

	private ScriptableObject Internal_GetPlayableAsset() { }

	private static IntPtr Internal_GetPlayableAsset_Injected(IntPtr _unity_self) { }

	[NativeThrows]
	private void Internal_SetGenericBinding(object key, object value) { }

	private static void Internal_SetGenericBinding_Injected(IntPtr _unity_self, IntPtr key, IntPtr value) { }

	public void Pause() { }

	private static void Pause_Injected(IntPtr _unity_self) { }

	internal void Play(FrameRate frameRate) { }

	[NativeThrows]
	public void Play() { }

	private static void Play_Injected(IntPtr _unity_self) { }

	[NativeThrows]
	private void PlayOnFrame(FrameRate frameRate) { }

	private static void PlayOnFrame_Injected(IntPtr _unity_self, in FrameRate frameRate) { }

	public void Resume() { }

	private static void Resume_Injected(IntPtr _unity_self) { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorStop() { }

	public void set_initialTime(double value) { }

	private static void set_initialTime_Injected(IntPtr _unity_self, double value) { }

	public void set_time(double value) { }

	private static void set_time_Injected(IntPtr _unity_self, double value) { }

	public void SetGenericBinding(object key, object value) { }

	public void Stop() { }

	private static void Stop_Injected(IntPtr _unity_self) { }

}

