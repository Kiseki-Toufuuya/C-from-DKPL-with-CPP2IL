namespace Heqet.Kagura;

public class KaguraGimmickMist : MonoBehaviour
{
	private Camera gameCamera; //Field offset: 0x10
	private bool initialized; //Field offset: 0x14
	private List<EffectObjectBase> effects; //Field offset: 0x18
	private Single[] durations; //Field offset: 0x1C
	private float duration; //Field offset: 0x20
	private int mistLevel; //Field offset: 0x24
	private float timer; //Field offset: 0x28

	public KaguraGimmickMist() { }

	public void Initialize() { }

	private void PlayEffect(float alpha) { }

	public void SetLevel(int lv) { }

	public void Terminate() { }

	public void Update() { }

}

