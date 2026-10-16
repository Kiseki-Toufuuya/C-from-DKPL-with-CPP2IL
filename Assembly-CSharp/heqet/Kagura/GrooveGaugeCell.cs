namespace Heqet.Kagura;

[RequireComponent(typeof(AtlasImage))]
public class GrooveGaugeCell : MonoBehaviour
{
	private readonly Vector3 MOVE_OFFSET; //Field offset: 0x10
	private PlayType m_PlayType; //Field offset: 0x1C
	private Image m_Image; //Field offset: 0x20
	private Vector3 m_StartPos; //Field offset: 0x24
	private Vector3 m_TargetPos; //Field offset: 0x30
	private float m_Time; //Field offset: 0x3C

	public GrooveGaugeCell() { }

	public void Hide() { }

	public void Init() { }

	public void MoveIn() { }

	public void MoveOut() { }

	public void Show() { }

	public void ZoomIn() { }

	public void ZoomOut() { }

}

