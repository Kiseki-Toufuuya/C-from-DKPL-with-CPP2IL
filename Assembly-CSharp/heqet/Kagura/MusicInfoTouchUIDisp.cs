namespace Heqet.Kagura;

public class MusicInfoTouchUIDisp : DispBase
{
	private const string TITLE_TEXT = "music_title"; //Field offset: 0x0
	private const string BPM_TEXT = "music_bpm"; //Field offset: 0x0
	private const string ICON_EASY = "difficarity_easy"; //Field offset: 0x0
	private const string ICON_NORMAL = "difficarity_normal"; //Field offset: 0x0
	private const string ICON_HARD = "difficarity_hard"; //Field offset: 0x0
	private const string ICON_LUNATIC = "difficarity_lunatic"; //Field offset: 0x0
	private TextMeshProUGUI bpmText; //Field offset: 0x114
	private float prevBPM; //Field offset: 0x118

	public MusicInfoTouchUIDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	private void SetDifficarityIcon(int difficarity) { }

	public void UpdateBpm(float _bpm) { }

	protected virtual void UpdateDispMain() { }

}

