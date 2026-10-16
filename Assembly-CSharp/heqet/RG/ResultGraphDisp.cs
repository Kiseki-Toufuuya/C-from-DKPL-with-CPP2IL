namespace Heqet.RG;

public class ResultGraphDisp : DispBase
{
	private class AccuracyWavePointData
	{
		public float value; //Field offset: 0x8
		public List<GameObject> points; //Field offset: 0xC

		public AccuracyWavePointData() { }

		public void ActivatePoint() { }

	}

	private enum eLayerId
	{
		ROOT_GROOVE_BODY = 0,
		ROOT_ACCURACY_BODY = 1,
		ROOT_GROOVE_LINE = 2,
		ROOT_GROOVE_LINE_BEST = 3,
		ROOT_ACCURACY_LINE = 4,
		ROOT_ACCURACY_LINE_BEST = 5,
		BASE_GROOVE_LESS = 6,
		BASE_GROOVE_BORDER = 7,
		BASE_GROOVE_MORE = 8,
		BASE_GROOVE_BEST_LESS = 9,
		BASE_GROOVE_BEST_BORDER = 10,
		BASE_GROOVE_BEST_MORE = 11,
		BASE_ACCURACY = 12,
		BASE_ACCURACY_BEST = 13,
		ROOT_GROOVE_TEXT = 14,
		ROOT_ACCURACY_TEXT = 15,
		RATING_INFO = 16,
	}

	private class GrooveWavePointData
	{
		public float value; //Field offset: 0x8
		public List<GameObject> points; //Field offset: 0xC

		public GrooveWavePointData() { }

		public void ActivatePoint() { }

	}

	internal class SetupParam
	{
		public float time; //Field offset: 0x8
		public float value; //Field offset: 0xC

		public SetupParam() { }

	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		OpenWait = 2,
		CloseWait = 3,
		Close = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private Animator RootAnimator; //Field offset: 0x114
	private readonly int VERTUCAL_COUNT; //Field offset: 0x118
	private readonly int HORIZONAL_COUNT; //Field offset: 0x11C
	private readonly int GROOVE_BORDER; //Field offset: 0x120
	private readonly float POINT_SIZE; //Field offset: 0x124
	private UiState WindowState; //Field offset: 0x128
	private List<GrooveWavePointData> m_GrooveWavePointDatas; //Field offset: 0x12C
	private List<AccuracyWavePointData> m_AccuracyWavePointDatas; //Field offset: 0x130
	private List<GrooveWavePointData> m_GrooveWaveBestPointDatas; //Field offset: 0x134
	private List<AccuracyWavePointData> m_AccuracyWaveBestPointDatas; //Field offset: 0x138
	private GameObject m_BaseObjGrooveLess; //Field offset: 0x13C
	private GameObject m_BaseObjGrooveBorder; //Field offset: 0x140
	private GameObject m_BaseObjGrooveMore; //Field offset: 0x144
	private GameObject m_BaseObjGrooveLessBest; //Field offset: 0x148
	private GameObject m_BaseObjGrooveBorderBest; //Field offset: 0x14C
	private GameObject m_BaseObjGrooveMoreBest; //Field offset: 0x150
	private GameObject m_BaseObjAccuracy; //Field offset: 0x154
	private GameObject m_BaseObjAccuracyBest; //Field offset: 0x158
	private RatingInfo m_RatingInfoPanel; //Field offset: 0x15C

	private static ResultGraphDisp() { }

	public ResultGraphDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	private AccuracyWavePointData CreeteAccuracyWave(float _value, float _before, bool isBest) { }

	private GrooveWavePointData CreeteGrooveWave(float _value, float _before, bool isBest) { }

	private int CulcGroovePointY(float _value) { }

	public List<Single> GetAccuracyValue() { }

	public List<Single> GetGrooveValue() { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	private void SetupAccuracyWave(List<SetupParam> _params, bool isBest) { }

	public void SetupAccuracyWaveBest(List<SetupParam> _params) { }

	public void SetupAccuracyWaveCurrent(List<SetupParam> _params) { }

	private void SetupGrooveWave(List<SetupParam> _params, bool isBest) { }

	public void SetupGrooveWaveBest(List<SetupParam> _params) { }

	public void SetupGrooveWaveCurrent(List<SetupParam> _params) { }

	public void SetupRatingPanel(float rating, int totalNotes, int playCount, float tapRate, int maxCombo) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float time = 0) { }

	public void UpdateAccuracyWave(float _rate) { }

	public void UpdateBestAccuracyWave(float _rate) { }

	public void UpdateBestGrooveWave(float _rate) { }

	public void UpdateDispAccuracyWave() { }

	public void UpdateDispGrooveWave() { }

	protected virtual void UpdateDispMain() { }

	public void UpdateDispRatinPanel() { }

	public void UpdateGrooveWave(float _rate) { }

	private GameObject UpdateLineGrooveGraph(float _start, float _end, float _posX, GameObject _parent, bool isBest) { }

}

