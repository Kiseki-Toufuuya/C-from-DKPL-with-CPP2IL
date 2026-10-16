namespace Heqet.RG;

public class FastSlowMessage : MonoBehaviour
{
	private const float INACTIVE_TIME = 2.8; //Field offset: 0x0
	[SerializeField]
	private FastSlowEffect[] effects; //Field offset: 0x10
	private bool isHide; //Field offset: 0x14
	private float inactiveTime; //Field offset: 0x18
	private float scale; //Field offset: 0x1C
	private bool showPerfect; //Field offset: 0x20

	public FastSlowMessage() { }

	public void AllEffectInactive(int n = -1) { }

	public void PlayEffect(int judge, float timeLag) { }

	public void SetHide(bool enable) { }

	public void SetScale(float value) { }

	private void Start() { }

	private void Update() { }

}

