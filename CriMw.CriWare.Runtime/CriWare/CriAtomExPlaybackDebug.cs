namespace CriWare;

public static class CriAtomExPlaybackDebug
{

	private static int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value) { }

	private static int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value) { }

	private static int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value) { }

	private static int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value) { }

	private static int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value) { }

	public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value) { }

	public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value) { }

	public static bool GetParameter(CriAtomExPlayback playback, Parameter parameterId, out float value) { }

	public static bool GetParameter(CriAtomExPlayback playback, Parameter parameterId, out uint value) { }

	public static bool GetParameter(CriAtomExPlayback playback, Parameter parameterId, out int value) { }

}

