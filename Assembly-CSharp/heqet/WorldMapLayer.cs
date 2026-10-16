namespace Heqet;

public class WorldMapLayer : LayerBase
{
	[CompilerGenerated]
	private struct <CloseFooterMenu>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WorldMapLayer <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenFooterMenu>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WorldMapLayer <>4__this; //Field offset: 0xC
		public eMode mode; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private WorldMapHeaderDisp m_HeaderDisp; //Field offset: 0x58
	private WorldMapFooterDisp m_FooterDisp; //Field offset: 0x5C
	[CompilerGenerated]
	private Action <OnPressOpenStageList>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Action <OnPressWorldMap>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private Action <OnPressOpenSpotMenu>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Action <OnPressSelectButton>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private Action <OnPressHelpButton>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private SpotManager <SpotManager>k__BackingField; //Field offset: 0x74
	private List<SpotIconDisp> m_spot_icons; //Field offset: 0x78
	private StageInfoDisp m_stage_info; //Field offset: 0x7C
	private Dictionary<Int32, StageTreasureIconDisp> m_treasure_icons; //Field offset: 0x80
	private bool m_is_stage_info_disp; //Field offset: 0x84
	private float m_stage_info_delay; //Field offset: 0x88
	private bool m_is_footer_animation; //Field offset: 0x8C
	[CompilerGenerated]
	private Camera <SceneCamera>k__BackingField; //Field offset: 0x90

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public bool IsFooterAnimation
	{
		 get { } //Length: 14
	}

	public Action OnPressHelpButton
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action OnPressOpenSpotMenu
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action OnPressOpenStageList
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action OnPressSelectButton
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action OnPressWorldMap
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Camera SceneCamera
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private SpotManager SpotManager
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public WorldMapLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__53_0(int btn_id) { }

	[CompilerGenerated]
	private void <InitAll>b__53_1(int btn_id) { }

	[AsyncStateMachine(typeof(<CloseFooterMenu>d__59))]
	public UniTask CloseFooterMenu() { }

	private void CreateSpotIcons() { }

	private void CreateStageInfo() { }

	public void CreateTreasureIcons(SpotPoint targetSpot) { }

	public void DeleteTresureIcon(int stageDataId) { }

	public void DispSpotIcon(SpotPoint targetSpot) { }

	public void DispStageInfo(StagePoint targetStage, float delay = 0.5) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public bool get_IsFooterAnimation() { }

	[CompilerGenerated]
	public Action get_OnPressHelpButton() { }

	[CompilerGenerated]
	public Action get_OnPressOpenSpotMenu() { }

	[CompilerGenerated]
	public Action get_OnPressOpenStageList() { }

	[CompilerGenerated]
	public Action get_OnPressSelectButton() { }

	[CompilerGenerated]
	public Action get_OnPressWorldMap() { }

	[CompilerGenerated]
	private Camera get_SceneCamera() { }

	[CompilerGenerated]
	private SpotManager get_SpotManager() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	[AsyncStateMachine(typeof(<OpenFooterMenu>d__58))]
	public UniTask OpenFooterMenu(eMode mode) { }

	public virtual void OverDeleteLayer() { }

	public void ReleaseAllTreasureIcons() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_OnPressHelpButton(Action value) { }

	[CompilerGenerated]
	public void set_OnPressOpenSpotMenu(Action value) { }

	[CompilerGenerated]
	public void set_OnPressOpenStageList(Action value) { }

	[CompilerGenerated]
	public void set_OnPressSelectButton(Action value) { }

	[CompilerGenerated]
	public void set_OnPressWorldMap(Action value) { }

	[CompilerGenerated]
	public void set_SceneCamera(Camera value) { }

	[CompilerGenerated]
	public void set_SpotManager(SpotManager value) { }

	protected virtual void Update(bool is_active) { }

}

