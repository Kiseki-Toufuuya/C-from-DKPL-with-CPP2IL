namespace Heqet;

public class GalleryAchievementDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryAchievementDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Help = 1,
		Sort = 2,
		Search = 3,
		RewardInfo = 4,
		Max = 5,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		GetAllAchieve = 1,
		RewardAchieve = 2,
		Thumbnail = 3,
		Max = 4,
	}

	private enum eImageId
	{
		AchievementImage = 0,
		Max = 1,
	}

	private enum eTextId
	{
		AchievementText = 0,
		DescriptionText = 1,
		RewardText = 2,
		SortText = 3,
		FilterText = 4,
		CollectionText = 5,
		CollectionRateText = 6,
		NoHitText = 7,
		Max = 8,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryAchievementLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private String[] m_ImageList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	private RawImageEx m_AchievementImage; //Field offset: 0x124
	private AchievementAssetBunleLoader m_achievementLoader; //Field offset: 0x128
	private readonly int NOT_FOUND_ACHIEVE; //Field offset: 0x12C

	private static GalleryAchievementDisp() { }

	public GalleryAchievementDisp() { }

	[CompilerGenerated]
	private bool <Open>b__19_0() { }

	[CompilerGenerated]
	private void <TextAndImageDisplay>b__26_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <TextAndImageDisplay>b__26_1(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	public GameObject GetScrollRoot() { }

	public void HiddenText() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__19))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void RewardAchieveIsActive(int index) { }

	public void SetAchievementCollectionRate() { }

	public void SetTextAchievementData(int index) { }

	private void TextAndImageDisplay(AchievementModel model, bool name_flg, bool description_flg, bool reward_flg, bool image_flg) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateSortAndFilerDisp(bool isFilter, string sortName) { }

}

