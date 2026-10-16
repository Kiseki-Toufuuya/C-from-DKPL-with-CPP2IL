namespace XeSys;

public class DebugTextRenderer : MonoBehaviour
{
	internal enum Anchor
	{
		Free = 0,
		UpperLeft = 1,
		UpperRight = 2,
		LowerLeft = 3,
		LowerRight = 4,
		Count = 5,
	}

	private class TextInfo
	{
		public string text; //Field offset: 0x8
		public Anchor anchor; //Field offset: 0xC
		public Color color; //Field offset: 0x10
		public Vector2 position; //Field offset: 0x20
		public bool shadow; //Field offset: 0x28
		public Color shadowColor; //Field offset: 0x2C

		public TextInfo() { }

		public void Clear() { }

	}

	private static DebugTextRenderer mInstance; //Field offset: 0x0
	public static bool enable; //Field offset: 0x4
	public static Color textColor; //Field offset: 0x8
	public static bool shadow; //Field offset: 0x18
	public static Color shadowColor; //Field offset: 0x1C
	private List<TextInfo> mTextList; //Field offset: 0x10
	private int mRegisterCount; //Field offset: 0x14

	public static DebugTextRenderer Instance
	{
		 get { } //Length: 60
	}

	private static DebugTextRenderer() { }

	public DebugTextRenderer() { }

	private void Awake() { }

	public static GameObject Create(DebugTextRenderer prefab) { }

	public static DebugTextRenderer get_Instance() { }

	public void Print(string text, Anchor anchor, Color color) { }

	public void Print(string text, Vector2 position, Color color) { }

	private TextInfo RegisterTextInfo() { }

	private void Start() { }

	private void Update() { }

}

