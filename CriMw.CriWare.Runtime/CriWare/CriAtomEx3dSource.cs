namespace CriWare;

public class CriAtomEx3dSource : CriDisposable
{
	internal struct Config
	{
		public bool enableVoicePriorityDecay; //Field offset: 0x0
		public uint randomPositionListMaxLength; //Field offset: 0x4

		public Config(bool enableVoicePriorityDecay, uint randomPositionListMaxLength) { }

	}

	private uint currentRandomPositionListMaxLength; //Field offset: 0x18
	private IntPtr handle; //Field offset: 0x1C

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	public CriAtomEx3dSource(bool enableVoicePriorityDecay = false, uint randomPositionListMaxLength = 0) { }

	private static IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size) { }

	private static void criAtomEx3dSource_Destroy(IntPtr ex_3d_source) { }

	private static bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source) { }

	private static NativeVector criAtomEx3dSource_GetPosition(IntPtr ex_3d_source) { }

	private static bool criAtomEx3dSource_IsDestroyable(IntPtr ex_3d_source) { }

	private static void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source) { }

	private static void criAtomEx3dSource_Set3dRegionHn(IntPtr ex_3d_source, IntPtr ex_3d_region) { }

	private static void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag) { }

	private static void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref NativeVector cone_orient) { }

	private static void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume) { }

	private static void criAtomEx3dSource_SetDistanceAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id) { }

	private static void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor) { }

	private static void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance) { }

	private static void criAtomEx3dSource_SetListenerBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id) { }

	private static void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta) { }

	private static void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance) { }

	private static void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref NativeVector front, ref NativeVector top) { }

	private static void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref NativeVector position) { }

	private static void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, ref Randomize3dConfig config) { }

	private static void criAtomEx3dSource_SetRandomPositionConfig(IntPtr ex_3d_source, IntPtr config) { }

	private static void criAtomEx3dSource_SetRandomPositionList(IntPtr ex_3d_source, NativeVector[] position_list, uint length) { }

	private static void criAtomEx3dSource_SetSourceBasedElevationAngleAisacControlId(IntPtr ex_3d_source, ushort aisac_control_id) { }

	private static void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref NativeVector velocity) { }

	private static void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume) { }

	private static void criAtomEx3dSource_Update(IntPtr ex_3d_source) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public IntPtr get_nativeHandle() { }

	public bool GetAttenuationDistanceSetting() { }

	public NativeVector GetPosition() { }

	public bool IsDestroyable() { }

	public void ResetParameters() { }

	public void Set3dRegion(CriAtomEx3dRegion region3d) { }

	public void SetAttenuationDistanceSetting(bool flag) { }

	[Obsolete("Use CriAtomEx3dSource.SetOrientation(Vector3, Vector3) instead")]
	public void SetConeOrientation(float x, float y, float z) { }

	public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume) { }

	public void SetDistanceAisacControlId(ushort aisacControlId) { }

	public void SetDopplerFactor(float dopplerFactor) { }

	public void SetInteriorPanField(float sourceRadius, float interiorDistance) { }

	public void SetListenerBasedElevationAngleAisacControlId(ushort aisacControlId) { }

	public void SetMaxAngleAisacDelta(float maxDelta) { }

	public void SetMinMaxDistance(float minDistance, float maxDistance) { }

	public void SetOrientation(Vector3 front, Vector3 top) { }

	public void SetPosition(float x, float y, float z) { }

	public void SetRandomPositionConfig(Nullable<Randomize3dConfig> config) { }

	public void SetRandomPositionList(Vector3[] positionList) { }

	public void SetSourceBasedElevationAngleAisacControlId(ushort aisacControlId) { }

	public void SetVelocity(float x, float y, float z) { }

	public void SetVolume(float volume) { }

	public void Update() { }

}

