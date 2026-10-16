namespace Heqet.RG;

public class TapEffect : MonoBehaviour
{
	internal enum Types
	{
		Normal = 0,
		LongStart = 1,
		LongLoop = 2,
		LongEnd = 3,
		Semi = 4,
	}

	private static Int32[2] TapEffectSet; //Field offset: 0x0
	private static Int32[2] TouchEffectSet; //Field offset: 0x4
	private static Int32[2] TapEffectGroupIDToTapEffectSet; //Field offset: 0x8
	private EffectObjectBase normalEffect; //Field offset: 0x10
	private EffectObjectBase longStartEffect; //Field offset: 0x14
	private EffectObjectBase longLoopEffect; //Field offset: 0x18
	private EffectObjectBase longEndEffect; //Field offset: 0x1C
	private EffectObjectBase semiEffect; //Field offset: 0x20

	private static TapEffect() { }

	public TapEffect() { }

	private int GetEffectId(int group, int color, Types type) { }

	private int GetGroupIndex() { }

	private void InitEffect(EffectObjectBase effect, bool loop = false) { }

	public void Initialize(Lane lane) { }

	public void Play(Types type) { }

	public void Release(Lane lane) { }

	public void Stop() { }

}

