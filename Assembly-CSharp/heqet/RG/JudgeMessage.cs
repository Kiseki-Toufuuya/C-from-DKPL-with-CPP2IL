namespace Heqet.RG;

public class JudgeMessage : MonoBehaviour
{
	private const float INACTIVE_TIME = 2.8; //Field offset: 0x0
	[SerializeField]
	private JudgeEffect[] judgeEffects; //Field offset: 0x10
	private bool isHide; //Field offset: 0x14
	private float inactiveTime; //Field offset: 0x18
	private float scale; //Field offset: 0x1C
	private bool enableHighAccuracy; //Field offset: 0x20

	public JudgeMessage() { }

	public void AllJudgeEffectInactive(int n = -1) { }

	public void PlayJudgeEffect(int judge) { }

	public void SetHide(bool enable) { }

	public void SetScale(float value) { }

	private void Start() { }

	private void Update() { }

}

