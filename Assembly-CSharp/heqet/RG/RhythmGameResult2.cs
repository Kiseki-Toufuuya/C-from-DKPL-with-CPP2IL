namespace Heqet.RG;

public class RhythmGameResult2 : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__11_0; //Field offset: 0x4
		public static Func<NotesRecordData, Int32, <>f__AnonymousType0`2<NotesRecordData, Int32>> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal <>f__AnonymousType0<NotesRecordData, Int32> <ApplyResultData>b__14_0(NotesRecordData value, int index) { }

		internal void <Initialize>b__11_0(LayerBase layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public HeqetMusicModel _model; //Field offset: 0x8
		public Camera gameCamera; //Field offset: 0xC
		public RhythmGameResult2 <>4__this; //Field offset: 0x10
		public AutePlayResultData AutePlayResultData; //Field offset: 0x14

		public <>c__DisplayClass11_0() { }

		internal void <Initialize>b__1(LayerBase layer) { }

	}

	[SerializeField]
	private InGameType m_IngameType; //Field offset: 0x10
	private RythmGameResultLayer2 m_ResultLayer; //Field offset: 0x14
	private ViewMusicInfoLayer m_ViewMusicInfoLayer; //Field offset: 0x18
	private HeqetMusicModel m_MusicModel; //Field offset: 0x1C

	public bool IsRetry
	{
		 get { } //Length: 65
	}

	public RhythmGameResult2() { }

	private void AchievementCheck() { }

	public void AddPlayCount(HeqetMusicModel _model) { }

	private void ApplyResultData() { }

	public void ApplyStageRewardsAndCardExp() { }

	private AutePlayResultData CreateAutoPlayResultData() { }

	public bool get_IsRetry() { }

	public void Initialize(HeqetMusicModel _model, Camera gameCamera) { }

	private bool IsAutoPlay() { }

	public bool IsDestroy() { }

	public bool IsEnd() { }

	public bool IsReady() { }

	public void Open() { }

	public void Release() { }

}

