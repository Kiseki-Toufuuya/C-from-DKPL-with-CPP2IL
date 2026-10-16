namespace Cinemachine;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineAlternativeInput.html")]
public class CinemachineInputProvider : MonoBehaviour, IInputAxisProvider
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public InputActionReference aRef; //Field offset: 0x8

		public <>c__DisplayClass7_0() { }

		internal bool <ResolveForPlayer>b__1(InputAction x) { }

	}

	private const int NUM_AXES = 3; //Field offset: 0x0
	[Tooltip("Leave this at -1 for single-player games.  For multi-player games, set this to be the player index, and the actions will be read from that player's controls")]
	public int PlayerIndex; //Field offset: 0x10
	[Tooltip("If set, Input Actions will be auto-enabled at start")]
	public bool AutoEnableInputs; //Field offset: 0x14
	[Tooltip("Vector2 action for XY movement")]
	public InputActionReference XYAxis; //Field offset: 0x18
	[Tooltip("Float action for Z movement")]
	public InputActionReference ZAxis; //Field offset: 0x1C
	private InputAction[] m_cachedActions; //Field offset: 0x20

	public CinemachineInputProvider() { }

	[CompilerGenerated]
	internal static InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(in InputUser user, InputActionReference aRef) { }

	public override float GetAxisValue(int axis) { }

	protected override void OnDisable() { }

	protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef) { }

}

