namespace Heqet.RG;

public class SeekBarDisp : DispBase
{
	private const float MIN_VALUE = 0.05; //Field offset: 0x0
	private const float MAX_VALUE = 0.97; //Field offset: 0x0
	private MusicManager m_MusicManager; //Field offset: 0x114
	private Slider m_Slider; //Field offset: 0x118
	private bool m_IsKaguraLayer; //Field offset: 0x11C

	public SeekBarDisp() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	protected virtual void UpdateDispMain() { }

}

