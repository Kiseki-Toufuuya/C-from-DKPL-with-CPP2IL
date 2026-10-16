namespace CriWare;

public static class CriAtomExCategory
{
	internal struct ReactAisacModulationParameter
	{
		private int _enableDecrementAisacModulationKey; //Field offset: 0x0
		public uint decrementAisacModulationKey; //Field offset: 0x4
		private int _enableIncrementAisacModulationKey; //Field offset: 0x8
		public uint incrementAisacModulationKey; //Field offset: 0xC

		public bool enableDecrementAisacModulationKey
		{
			 get { } //Length: 14
		}

		public bool enableIncrementAisacModulationKey
		{
			 get { } //Length: 15
		}

		public bool get_enableDecrementAisacModulationKey() { }

		public bool get_enableIncrementAisacModulationKey() { }

	}

	[Obsolete("Use CriWare.CriAtomEx.CurveType instead")]
	internal enum ReactDuckerCurveType
	{
		Linear = 0,
		Square = 1,
		SquareReverse = 2,
		SCurve = 3,
		FlatAtHalf = 4,
	}

	internal struct ReactDuckerParameter
	{
		internal struct AisacControl
		{
			public uint id; //Field offset: 0x0
			public float value; //Field offset: 0x4

		}

		internal struct Target
		{
			public Volume volume; //Field offset: 0x0
			public AisacControl aisacControl; //Field offset: 0x0

		}

		internal struct Volume
		{
			public float level; //Field offset: 0x0

		}

		public Target target; //Field offset: 0x0
		public ReactDuckerTargetType targetType; //Field offset: 0x8
		public ReactFadeParameter entry; //Field offset: 0xC
		public ReactFadeParameter exit; //Field offset: 0x18
		public ReactHoldType holdType; //Field offset: 0x24
		public ushort holdTimeMs; //Field offset: 0x28

	}

	internal enum ReactDuckerTargetType
	{
		Volume = 0,
		AisacControlValue = 1,
	}

	internal struct ReactFadeParameter
	{
		public CurveType curveType; //Field offset: 0x0
		public float curveStrength; //Field offset: 0x4
		public ushort fadeTimeMs; //Field offset: 0x8

	}

	internal enum ReactHoldType
	{
		WhilePlaying = 0,
		FixedTime = 1,
	}

	internal struct ReactParameter
	{
		internal struct Parameter
		{
			public ReactDuckerParameter ducker; //Field offset: 0x0
			public ReactAisacModulationParameter aisacModulation; //Field offset: 0x0

		}

		public Parameter parameter; //Field offset: 0x0
		public ReactType type; //Field offset: 0x2C
		public bool enablePausingCue; //Field offset: 0x30

	}

	internal enum ReactStatus
	{
		Stop = 0,
		FadeOut = 1,
		Hold = 2,
		FadeIn = 3,
		Error = 4,
	}

	internal enum ReactType
	{
		Ducker = 0,
		AisacModulationTrigger = 1,
	}


	public static void AttachAisac(string name, string globalAisacName) { }

	public static void AttachAisac(int id, string globalAisacName) { }

	private static void criAtomExCategory_AttachAisacById(int id, string global_aisac_name) { }

	private static void criAtomExCategory_AttachAisacByName(string name, string global_aisac_name) { }

	private static void criAtomExCategory_DetachAisacAllById(int id) { }

	private static void criAtomExCategory_DetachAisacAllByName(string name) { }

	private static void criAtomExCategory_DetachAisacById(int id, string global_aisac_name) { }

	private static void criAtomExCategory_DetachAisacByName(string name, string global_aisac_name) { }

	private static bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo) { }

	private static bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo) { }

	private static bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value) { }

	private static int criAtomExCategory_GetNumAttachedAisacsById(int id) { }

	private static int criAtomExCategory_GetNumAttachedAisacsByName(string name) { }

	private static int criAtomExCategory_GetNumCuePlayingCountById(int id) { }

	private static int criAtomExCategory_GetNumCuePlayingCountByName(string name) { }

	private static bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter) { }

	private static ReactStatus criAtomExCategory_GetReactStatus(string react_name) { }

	private static float criAtomExCategory_GetTotalVolumeById(int id) { }

	private static float criAtomExCategory_GetTotalVolumeByName(string name) { }

	private static float criAtomExCategory_GetVolumeById(int id) { }

	private static float criAtomExCategory_GetVolumeByName(string name) { }

	private static bool criAtomExCategory_IsMutedById(int id) { }

	private static bool criAtomExCategory_IsMutedByName(string name) { }

	private static bool criAtomExCategory_IsPausedById(int id) { }

	private static bool criAtomExCategory_IsPausedByName(string name) { }

	private static bool criAtomExCategory_IsSoloedById(int id) { }

	private static bool criAtomExCategory_IsSoloedByName(string name) { }

	private static void criAtomExCategory_MuteById(int id, bool mute) { }

	private static void criAtomExCategory_MuteByName(string name, bool mute) { }

	private static void criAtomExCategory_PauseById(int id, bool pause) { }

	private static void criAtomExCategory_PauseByName(string name, bool pause) { }

	private static bool criAtomExCategory_ResetAllAisacControlById(int category_id) { }

	private static bool criAtomExCategory_ResetAllAisacControlByName(string category_name) { }

	private static void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value) { }

	private static void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value) { }

	private static void criAtomExCategory_SetFadeInTimeById(int id, ushort ms) { }

	private static void criAtomExCategory_SetFadeInTimeByName(string name, ushort ms) { }

	private static void criAtomExCategory_SetFadeOutTimeById(int id, ushort ms) { }

	private static void criAtomExCategory_SetFadeOutTimeByName(string name, ushort ms) { }

	private static void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter) { }

	private static void criAtomExCategory_SetVolumeById(int id, float volume) { }

	private static void criAtomExCategory_SetVolumeByName(string name, float volume) { }

	private static void criAtomExCategory_SoloById(int id, bool solo, float volume) { }

	private static void criAtomExCategory_SoloByName(string name, bool solo, float volume) { }

	private static void criAtomExCategory_StopById(int id) { }

	private static void criAtomExCategory_StopByName(string name) { }

	private static void criAtomExCategory_StopWithoutReleaseTimeById(int id) { }

	private static void criAtomExCategory_StopWithoutReleaseTimeByName(string name) { }

	public static void DetachAisac(string name, string globalAisacName) { }

	public static void DetachAisac(int id, string globalAisacName) { }

	public static void DetachAisacAll(string name) { }

	public static void DetachAisacAll(int id) { }

	public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out AisacInfo aisacInfo) { }

	public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out AisacInfo aisacInfo) { }

	public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue) { }

	public static int GetNumAttachedAisacs(int id) { }

	public static int GetNumAttachedAisacs(string name) { }

	public static int GetNumCuePlayingCount(int id) { }

	public static int GetNumCuePlayingCount(string name) { }

	public static bool GetReactParameter(string name, out ReactParameter parameter) { }

	public static ReactStatus GetReactStatus(string reactName) { }

	public static float GetTotalVolume(string name) { }

	public static float GetTotalVolume(int id) { }

	public static float GetVolume(string name) { }

	public static float GetVolume(int id) { }

	public static bool IsMuted(int id) { }

	public static bool IsMuted(string name) { }

	public static bool IsPaused(string name) { }

	public static bool IsPaused(int id) { }

	public static bool IsSoloed(int id) { }

	public static bool IsSoloed(string name) { }

	public static void Mute(int id, bool mute) { }

	public static void Mute(string name, bool mute) { }

	public static void Pause(string name, bool pause) { }

	public static void Pause(int id, bool pause) { }

	public static bool ResetAllAisacControl(int id) { }

	public static bool ResetAllAisacControl(string name) { }

	[Obsolete("Use CriAtomExCategory.SetAisacControl")]
	public static void SetAisac(string name, string controlName, float value) { }

	[Obsolete("Use CriAtomExCategory.SetAisacControl")]
	public static void SetAisac(int id, int controlId, float value) { }

	public static void SetAisacControl(int id, int controlId, float value) { }

	public static void SetAisacControl(string name, string controlName, float value) { }

	public static void SetFadeInTime(int id, ushort ms) { }

	public static void SetFadeInTime(string name, ushort ms) { }

	public static void SetFadeOutTime(int id, ushort ms) { }

	public static void SetFadeOutTime(string name, ushort ms) { }

	public static void SetReactParameter(string name, ReactParameter parameter) { }

	public static void SetVolume(int id, float volume) { }

	public static void SetVolume(string name, float volume) { }

	public static void Solo(int id, bool solo, float muteVolume) { }

	public static void Solo(string name, bool solo, float muteVolume) { }

	public static void Stop(int id) { }

	public static void Stop(string name) { }

	public static void StopWithoutReleaseTime(int id) { }

	public static void StopWithoutReleaseTime(string name) { }

}

