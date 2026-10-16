namespace CriWare;

public class CriAtomExAcb : CriDisposable
{
	private IntPtr handle; //Field offset: 0x18
	private GCHandle dataHandle; //Field offset: 0x1C

	public bool isAvailable
	{
		 get { } //Length: 15
	}

	public IntPtr nativeHandle
	{
		 get { } //Length: 11
	}

	internal CriAtomExAcb(IntPtr handle, Nullable<GCHandle> dataHandle) { }

	public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name) { }

	private static void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size) { }

	private static void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name) { }

	private static bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id) { }

	private static bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name) { }

	private static int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name) { }

	private static int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name) { }

	private static bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info) { }

	private static bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info) { }

	private static bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info) { }

	private static int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id) { }

	private static int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name) { }

	private static int criAtomExAcb_GetNumCues(IntPtr acb_hn) { }

	private static int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id) { }

	private static int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name) { }

	private static bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info) { }

	private static bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info) { }

	private static bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info) { }

	private static bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info) { }

	private static bool criAtomExAcb_IsAttachedAwbFile(IntPtr acbHn, string awbName) { }

	private static bool criAtomExAcb_IsReadyToRelease(IntPtr acb_hn) { }

	private static IntPtr criAtomExAcb_LoadAcbData(IntPtr acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size) { }

	private static IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size) { }

	private static void criAtomExAcb_Release(IntPtr acb_hn) { }

	private static void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id) { }

	private static void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name) { }

	public void Decrypt(ulong key, ulong nonce) { }

	public void DetachAwbFile(string awb_name) { }

	private void Dispose(bool disposing) { }

	public virtual void Dispose() { }

	public bool Exists(int cueId) { }

	public bool Exists(string cueName) { }

	protected virtual void Finalize() { }

	public bool get_isAvailable() { }

	public IntPtr get_nativeHandle() { }

	public int GetBlockIndex(string cueName, string blockName) { }

	public int GetBlockIndex(int cueId, string blockName) { }

	public bool GetCueInfo(string cueName, out CueInfo info) { }

	public bool GetCueInfo(int cueId, out CueInfo info) { }

	public bool GetCueInfoByIndex(int index, out CueInfo info) { }

	public CueInfo[] GetCueInfoList() { }

	public float GetLoadProgress() { }

	public int GetNumCuePlaying(string name) { }

	public int GetNumCuePlaying(int id) { }

	public int GetNumUsableAisacControls(int cueId) { }

	public int GetNumUsableAisacControls(string cueName) { }

	public bool GetUsableAisacControl(string cueName, int index, out AisacControlInfo info) { }

	public bool GetUsableAisacControl(int cueId, int index, out AisacControlInfo info) { }

	public AisacControlInfo[] GetUsableAisacControlList(string cueName) { }

	public AisacControlInfo[] GetUsableAisacControlList(int cueId) { }

	public bool GetWaveFormInfo(int cueId, out WaveformInfo info) { }

	public bool GetWaveFormInfo(string cueName, out WaveformInfo info) { }

	public bool IsAttachedAwbFile(string awbName) { }

	public bool IsReadyToRelease() { }

	public static CriAtomExAcb LoadAcbData(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath) { }

	public static CriAtomExAcb LoadAcbData(Byte[] acbData, CriFsBinder awbBinder, string awbPath) { }

	public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath) { }

	public void ResetCueTypeState(int cueId) { }

	public void ResetCueTypeState(string cueName) { }

}

