namespace XeApp.Game;

public class AdvItemBoardDisp : DispBase
{
	internal enum AnimeType
	{
		None = 0,
		In = 1,
		Out = 2,
	}

	private enum eLayerId
	{
		BASE_ROOT = 0,
		BASE_IMAGE = 1,
		BASE_NUM = 2,
		TEXT_NUM = 2,
	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		Close = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdvInfoBoardLayer m_Layer; //Field offset: 0x114
	private CanvasGroup m_RootAlpha; //Field offset: 0x118
	private RawImageEx m_Image; //Field offset: 0x11C
	private UiState State; //Field offset: 0x120
	private AnimeType m_type; //Field offset: 0x124
	private float ActionTime; //Field offset: 0x128
	private float CompleteTime; //Field offset: 0x12C

	private static AdvItemBoardDisp() { }

	public AdvItemBoardDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	private bool CulcActionRate(out float rate) { }

	protected virtual void InitUguiOther() { }

	public bool IsFadeEnd() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetActive(bool active) { }

	public void SetAlpha(float alpha) { }

	public void SetPosition(Vector3 pos) { }

	public void SetSprite(Sprite sprite) { }

	public void StartAnime(AnimeType type, int time) { }

	protected virtual void UpdateDispMain() { }

}

