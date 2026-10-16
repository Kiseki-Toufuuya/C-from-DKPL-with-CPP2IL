namespace Heqet.Kagura;

public class KaguraGimmickVenomMist : MonoBehaviour
{
	private Camera gameCamera; //Field offset: 0x10
	private bool initialized; //Field offset: 0x14
	private List<EffectObjectBase> effects; //Field offset: 0x18
	private float timer; //Field offset: 0x1C

	public KaguraGimmickVenomMist() { }

	public void Initialize() { }

	private void PlayEffect(float alpha) { }

	public void Terminate() { }

	public void Update() { }

}

