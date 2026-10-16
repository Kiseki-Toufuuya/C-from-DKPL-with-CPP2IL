namespace XeApp.Core;

public class ScreenShotCapture : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CaptureSequence>d__79 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ScreenShotCapture <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <CaptureSequence>d__79(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum CaptureType
	{
		UGC = 0,
		PRESET_THUMBNAIL = 1,
	}

	[CompilerGenerated]
	private static ScreenShotCapture <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Camera <ExternalCamera>k__BackingField; //Field offset: 0x10
	private Camera m_captureCamera; //Field offset: 0x14
	private RenderTexture m_renderTexture; //Field offset: 0x18
	private Texture2D m_captureTexture; //Field offset: 0x1C
	private RenderTexture m_miniRenderTexture; //Field offset: 0x20
	private Texture2D m_miniCaptureTexture; //Field offset: 0x24
	[CompilerGenerated]
	private Action <OnStartSave>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Action <OnEndSave>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsCaptureNow>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsSaveNow>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private int <UGCImageListW>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <UGCImageListH>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <UGCThumbnailW>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <UGCThumbnailH>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <UGCImageTrimW>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <UGCImageTrimH>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <PresetThumbnailW>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private int <PresetThumbnailH>k__BackingField; //Field offset: 0x50
	public string SaveRootPath; //Field offset: 0x54
	private int imageW; //Field offset: 0x58
	private int imageH; //Field offset: 0x5C
	private int thumbnailW; //Field offset: 0x60
	private int thumbnailH; //Field offset: 0x64
	private PhotoContentValue m_photoContentValue; //Field offset: 0x68

	public Camera ExternalCamera
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private static ScreenShotCapture Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public private bool IsCaptureNow
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsSaveNow
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public Action OnEndSave
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action OnStartSave
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int PresetThumbnailH
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int PresetThumbnailW
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UGCImageListH
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UGCImageListW
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UGCImageTrimH
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UGCImageTrimW
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UGCThumbnailH
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int UGCThumbnailW
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public ScreenShotCapture() { }

	private void Awake() { }

	private Rect CalcCaptureTrimmingRect() { }

	[IteratorStateMachine(typeof(<CaptureSequence>d__79))]
	public IEnumerator CaptureSequence() { }

	public Byte[] CaptureThumbnail() { }

	public void Decrypt(int salt, Byte[] bytes) { }

	private void DoCapture() { }

	public void Encrypt(Byte[] bytes, int salt) { }

	public void EncryptJpeg(string baseDir, PhotoContentValue photoContentValue, string suffix, string newSuffix) { }

	public void ExitCaputreMode() { }

	private Camera FindTargetCamera() { }

	[CompilerGenerated]
	public Camera get_ExternalCamera() { }

	[CompilerGenerated]
	public static ScreenShotCapture get_Instance() { }

	[CompilerGenerated]
	public bool get_IsCaptureNow() { }

	[CompilerGenerated]
	public bool get_IsSaveNow() { }

	[CompilerGenerated]
	public Action get_OnEndSave() { }

	[CompilerGenerated]
	public Action get_OnStartSave() { }

	[CompilerGenerated]
	public int get_PresetThumbnailH() { }

	[CompilerGenerated]
	public int get_PresetThumbnailW() { }

	[CompilerGenerated]
	public int get_UGCImageListH() { }

	[CompilerGenerated]
	public int get_UGCImageListW() { }

	[CompilerGenerated]
	public int get_UGCImageTrimH() { }

	[CompilerGenerated]
	public int get_UGCImageTrimW() { }

	[CompilerGenerated]
	public int get_UGCThumbnailH() { }

	[CompilerGenerated]
	public int get_UGCThumbnailW() { }

	public int GetEncryptSalt() { }

	public string GetMyAlbumLocalContentPath(PhotoContentValue photoContentValue, string suffix) { }

	public List<PhotoContentValue> GetMyAlubumFiles() { }

	public void OnPushCaptureButton() { }

	private void SaveToStorage() { }

	[CompilerGenerated]
	public void set_ExternalCamera(Camera value) { }

	[CompilerGenerated]
	private static void set_Instance(ScreenShotCapture value) { }

	[CompilerGenerated]
	private void set_IsCaptureNow(bool value) { }

	[CompilerGenerated]
	private void set_IsSaveNow(bool value) { }

	[CompilerGenerated]
	public void set_OnEndSave(Action value) { }

	[CompilerGenerated]
	public void set_OnStartSave(Action value) { }

	[CompilerGenerated]
	public void set_PresetThumbnailH(int value) { }

	[CompilerGenerated]
	public void set_PresetThumbnailW(int value) { }

	[CompilerGenerated]
	public void set_UGCImageListH(int value) { }

	[CompilerGenerated]
	public void set_UGCImageListW(int value) { }

	[CompilerGenerated]
	public void set_UGCImageTrimH(int value) { }

	[CompilerGenerated]
	public void set_UGCImageTrimW(int value) { }

	[CompilerGenerated]
	public void set_UGCThumbnailH(int value) { }

	[CompilerGenerated]
	public void set_UGCThumbnailW(int value) { }

	public void SetCaptureType(CaptureType type) { }

}

