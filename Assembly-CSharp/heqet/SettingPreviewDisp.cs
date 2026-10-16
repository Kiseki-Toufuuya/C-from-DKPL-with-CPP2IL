namespace Heqet;

public class SettingPreviewDisp : DispBase
{
	[CompilerGenerated]
	private struct <InitSettingPreview>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingPreviewDisp <>4__this; //Field offset: 0x8
		private string <prefabAssetBundleName>5__2; //Field offset: 0xC
		private string <imageAssetBundleName>5__3; //Field offset: 0x10
		private AssetBundleLoadAllAssetOperationBase <opePrefab>5__4; //Field offset: 0x14
		private AssetBundleLoadAllAssetOperationBase <opeImage>5__5; //Field offset: 0x18
		private SpriteAtlas <spriteatlas>5__6; //Field offset: 0x1C
		private Awaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string RAW_IMAGE = "raw_image"; //Field offset: 0x0
	private readonly float SUDDEN_MAX; //Field offset: 0x114
	private readonly float HIDDEN_MAX; //Field offset: 0x118
	private SettingPreview m_SettingPreview; //Field offset: 0x11C

	public SettingPreviewDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	[AsyncStateMachine(typeof(<InitSettingPreview>d__6))]
	private UniTaskVoid InitSettingPreview() { }

	protected virtual void LateUpdate() { }

	public void RefreshCenterLine(bool flg) { }

	public void RefreshComboMessagen(int _type, Vector2 _pos) { }

	public void RefreshFastSlowMessagen(int _type) { }

	public void RefreshHidden(float hidden) { }

	public void RefreshJudgeMessagen(int _type, Vector2 _pos) { }

	public void RefreshLaneBrightness(int _value) { }

	public void RefreshNoteSkin(int _type) { }

	public void RefreshSpeed(float speed) { }

	public void RefreshSudden(float sudden) { }

	public virtual void ReleaseAll() { }

	public void SetBpm(float _bpm) { }

	public virtual void SetDisp(bool enable) { }

	public void SetPosition(Vector2 _pos) { }

	public void SetScale(Vector2 _scale) { }

	public void Setup(SetupParam _param) { }

	protected virtual void UpdateDispMain() { }

	public virtual bool WaitResourceLoad() { }

}

