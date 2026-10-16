namespace Heqet.RG;

public class ComboMessage : MonoBehaviour
{
	internal enum ComboType
	{
		Default = 0,
		FullCombo = 1,
		AllBrilliant = 2,
		FramePerfect = 3,
		Max = 4,
	}

	private const float INACTIVE_TIME = 2.8; //Field offset: 0x0
	[SerializeField]
	private List<TMP_Text> comboNumberList; //Field offset: 0x10
	[SerializeField]
	private List<GameObject> comboList; //Field offset: 0x14
	private int currentComboType; //Field offset: 0x18
	private float scaleDuration; //Field offset: 0x1C
	private float inactiveTime; //Field offset: 0x20
	private Sequence seq; //Field offset: 0x24
	private bool isHide; //Field offset: 0x28
	private bool play; //Field offset: 0x29
	private float scale; //Field offset: 0x2C

	public ComboMessage() { }

	[CompilerGenerated]
	private void <Play>b__16_0() { }

	private void Awake() { }

	public void Clear() { }

	private TMP_Text GetActivateCurrent() { }

	public void Play(int combo) { }

	public void SetHide(bool enable) { }

	public void SetScale(float value) { }

	public void Stop() { }

	private void Update() { }

}

