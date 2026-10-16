namespace Live2D.Cubism.Framework;

public sealed class CubismAutoEyeBlinkInput : MonoBehaviour
{
	private enum Phase
	{
		Idling = 0,
		ClosingEyes = 1,
		ClosedEyes = 2,
		OpeningEyes = 3,
	}

	[Range(1, 10)]
	[SerializeField]
	public float Mean; //Field offset: 0x10
	[Range(0.5, 5)]
	[SerializeField]
	public float MaximumDeviation; //Field offset: 0x14
	[Range(1, 20)]
	[SerializeField]
	public float Timescale; //Field offset: 0x18
	[CompilerGenerated]
	private CubismEyeBlinkController <Controller>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Phase <CurrentPhase>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <LastValue>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <UserTimeSeconds>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <StateStartTimeSeconds>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <ClosingSeconds>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <ClosedSeconds>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <OpeningSeconds>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <NextBlinkingTime>k__BackingField; //Field offset: 0x3C

	private float ClosedSeconds
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float ClosingSeconds
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private CubismEyeBlinkController Controller
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private Phase CurrentPhase
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private float LastValue
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float NextBlinkingTime
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float OpeningSeconds
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float StateStartTimeSeconds
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	private float UserTimeSeconds
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 18
	}

	public CubismAutoEyeBlinkInput() { }

	[CompilerGenerated]
	private float get_ClosedSeconds() { }

	[CompilerGenerated]
	private float get_ClosingSeconds() { }

	[CompilerGenerated]
	private CubismEyeBlinkController get_Controller() { }

	[CompilerGenerated]
	private Phase get_CurrentPhase() { }

	[CompilerGenerated]
	private float get_LastValue() { }

	[CompilerGenerated]
	private float get_NextBlinkingTime() { }

	[CompilerGenerated]
	private float get_OpeningSeconds() { }

	[CompilerGenerated]
	private float get_StateStartTimeSeconds() { }

	[CompilerGenerated]
	private float get_UserTimeSeconds() { }

	private void LateUpdate() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_ClosedSeconds(float value) { }

	[CompilerGenerated]
	private void set_ClosingSeconds(float value) { }

	[CompilerGenerated]
	private void set_Controller(CubismEyeBlinkController value) { }

	[CompilerGenerated]
	private void set_CurrentPhase(Phase value) { }

	[CompilerGenerated]
	private void set_LastValue(float value) { }

	[CompilerGenerated]
	private void set_NextBlinkingTime(float value) { }

	[CompilerGenerated]
	private void set_OpeningSeconds(float value) { }

	[CompilerGenerated]
	private void set_StateStartTimeSeconds(float value) { }

	[CompilerGenerated]
	private void set_UserTimeSeconds(float value) { }

	public void SetBlinkingSettings(float closing, float closed, float opening) { }

	private void Start() { }

	private void UpdateEyeBlink() { }

	private float UpdateEyeBlinkClosed() { }

	private float UpdateEyeBlinkClosing() { }

	private float UpdateEyeBlinkIdling() { }

	private float UpdateEyeBlinkOpening() { }

}

