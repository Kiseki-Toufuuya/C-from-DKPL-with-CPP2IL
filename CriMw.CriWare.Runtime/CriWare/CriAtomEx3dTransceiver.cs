namespace CriWare;

public class CriAtomEx3dTransceiver : CriDisposable
{
	internal struct Config
	{
		public int reserved; //Field offset: 0x0

	}

	private static class UnsafeNativeMethods
	{

		internal static void criAtomEx3dTransceiver_AttachAisac(IntPtr ex_3d_transceiver, string global_aisac_name) { }

		internal static IntPtr criAtomEx3dTransceiver_Create(ref Config config, IntPtr work, int work_size) { }

		internal static void criAtomEx3dTransceiver_Destroy(IntPtr ex_3d_transceiver) { }

		internal static void criAtomEx3dTransceiver_DetachAisac(IntPtr ex_3d_transceiver, string global_aisac_name) { }

		internal static void criAtomEx3dTransceiver_Set3dRegionHn(IntPtr ex_3d_transceiver, IntPtr ex_3d_region) { }

		internal static void criAtomEx3dTransceiver_SetDistanceAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id) { }

		internal static void criAtomEx3dTransceiver_SetInputCrossFadeField(IntPtr ex_3d_transceiver, float direct_audio_radius, float crossfade_distance) { }

		internal static void criAtomEx3dTransceiver_SetInputOrientation(IntPtr ex_3d_transceiver, ref NativeVector front, ref NativeVector top) { }

		internal static void criAtomEx3dTransceiver_SetInputPosition(IntPtr ex_3d_transceiver, ref NativeVector position) { }

		internal static void criAtomEx3dTransceiver_SetListenerBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id) { }

		internal static void criAtomEx3dTransceiver_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id) { }

		internal static void criAtomEx3dTransceiver_SetMaxAngleAisacDelta(IntPtr ex_3d_transceiver, float max_delta) { }

		internal static void criAtomEx3dTransceiver_SetOutputConeParameter(IntPtr ex_3d_transceiver, float inside_angle, float outside_angle, float outside_volume) { }

		internal static void criAtomEx3dTransceiver_SetOutputInteriorPanField(IntPtr ex_3d_transceiver, float transceiver_radius, float interior_distance) { }

		internal static void criAtomEx3dTransceiver_SetOutputMinMaxAttenuationDistance(IntPtr ex_3d_transceiver, float min_attenuation_distance, float max_attenuation_distance) { }

		internal static void criAtomEx3dTransceiver_SetOutputOrientation(IntPtr ex_3d_transceiver, ref NativeVector front, ref NativeVector top) { }

		internal static void criAtomEx3dTransceiver_SetOutputPosition(IntPtr ex_3d_transceiver, ref NativeVector position) { }

		internal static void criAtomEx3dTransceiver_SetOutputVolume(IntPtr ex_3d_transceiver, float volume) { }

		internal static void criAtomEx3dTransceiver_SetTransceiverOutputBasedAzimuthAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id) { }

		internal static void criAtomEx3dTransceiver_SetTransceiverOutputBasedElevationAngleAisacControlId(IntPtr ex_3d_transceiver, ushort aisac_control_id) { }

		internal static void criAtomEx3dTransceiver_Update(IntPtr ex_3d_transceiver) { }

	}

	private IntPtr handle; //Field offset: 0x18

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public CriAtomEx3dTransceiver() { }

	public void AttachAisac(string globalAisacName) { }

	public void DetachAisac(string globalAisacName) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

	public void Set3dRegion(CriAtomEx3dRegion region3d) { }

	public void SetDistanceAisacControlId(ushort aisacControlId) { }

	public void SetInputCrossFadeField(float directAudioRadius, float crossfadeDistance) { }

	public void SetInputOrientation(Vector3 front, Vector3 top) { }

	public void SetInputPosition(Vector3 position) { }

	public void SetListenerBasedAzimuthAngleAisacControlId(ushort aisacControlId) { }

	public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) { }

	public void SetMaxAngleAisacDelta(float maxDelta) { }

	public void SetOutputConeParameter(float insideAngle, float outsideAngle, float outsideVolume) { }

	public void SetOutputInteriorPanField(float radius, float interiorDistance) { }

	public void SetOutputMinMaxDistance(float minDistance, float maxDistance) { }

	public void SetOutputOrientation(Vector3 front, Vector3 top) { }

	public void SetOutputPosition(Vector3 position) { }

	public void SetOutputVolume(float volume) { }

	public void SetTransceiverOutputBasedAzimuthAngleAisacControlId(ushort aisacControlId) { }

	public void SetTransceiverOutputBasedElevationAngleAisacControlId(ushort aisacControlId) { }

	public void Update() { }

}

