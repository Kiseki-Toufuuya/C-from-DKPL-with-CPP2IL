namespace XeApp.Game;

public class SafeAreaAdjuster : MonoBehaviour
{
	private RectTransform rectTrans; //Field offset: 0x10
	[SerializeField]
	private bool IsEdit; //Field offset: 0x14
	[CompilerGenerated]
	private bool <IsUseSafeAreaScaling>k__BackingField; //Field offset: 0x15
	private Vector2 prevOffsetMin; //Field offset: 0x18
	private Vector2 prevOffsetMax; //Field offset: 0x20
	private float prevLocalScale; //Field offset: 0x28

	public bool IsUseSafeAreaScaling
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public SafeAreaAdjuster() { }

	private void ApplyRectTransformt() { }

	[CompilerGenerated]
	public bool get_IsUseSafeAreaScaling() { }

	[CompilerGenerated]
	public void set_IsUseSafeAreaScaling(bool value) { }

	private void Start() { }

	private void Update() { }

}

