namespace CriWare;

public class CriAtomExTween : CriDisposable
{
	private struct Config
	{
		internal struct Target
		{
			public Parameter parameterId; //Field offset: 0x0
			public uint aisacIds; //Field offset: 0x0

		}

		public Target target; //Field offset: 0x0
		public ParameterType parameterType; //Field offset: 0x4

	}

	internal enum ParameterType
	{
		Basic = 0,
		Aisac = 1,
	}

	private IntPtr handle; //Field offset: 0x18

	public bool IsActive
	{
		 get { } //Length: 107
	}

	internal IntPtr nativeHandle
	{
		internal get { } //Length: 11
	}

	public float Value
	{
		 get { } //Length: 106
	}

	public CriAtomExTween() { }

	public CriAtomExTween(Parameter parameterId) { }

	public CriAtomExTween(uint aisacId) { }

	public CriAtomExTween(ParameterType parameterType, uint targetId) { }

	private static IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size) { }

	private static void criAtomExTween_Destroy(IntPtr tween) { }

	private static float criAtomExTween_GetValue(IntPtr tween) { }

	private static bool criAtomExTween_IsActive(IntPtr tween) { }

	private static void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value) { }

	private static void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value) { }

	private static void criAtomExTween_Reset(IntPtr tween) { }

	private static void criAtomExTween_Stop(IntPtr tween) { }

	public virtual void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public bool get_IsActive() { }

	internal IntPtr get_nativeHandle() { }

	public float get_Value() { }

	public void MoveFrom(ushort durationMs, float value) { }

	public void MoveTo(ushort durationMs, float value) { }

	public void Reset() { }

	public void Stop() { }

}

