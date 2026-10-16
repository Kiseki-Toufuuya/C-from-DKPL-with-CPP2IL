namespace XeSys.Gfx;

public class SerializableView
{
	internal enum ViewType
	{
		AbsoluteLayout = 0,
		ImageView = 1,
		ImageButton = 2,
		TextView = 3,
		ScrollText = 4,
		EditText = 5,
		ScrollView = 6,
		ModelView = 7,
		AutoScrollView = 8,
		MaskView = 9,
		ScrollBar = 10,
	}

	private const int EX_STR_IDX = 2; //Field offset: 0x0
	private const int EX_FLT_IDX = 1; //Field offset: 0x0
	private const int EX_INT_IDX = 0; //Field offset: 0x0
	public int index; //Field offset: 0x8
	public ViewType viewType; //Field offset: 0xC
	public ViewFrameAnimation viewFrameAnim; //Field offset: 0x10
	public int parentIndex; //Field offset: 0x14
	public string id; //Field offset: 0x18
	public int idHash; //Field offset: 0x1C
	public string exId; //Field offset: 0x20
	public string animId; //Field offset: 0x24
	public ViewTransformData transformData; //Field offset: 0x28
	public EAlignH alignH; //Field offset: 0x2C
	public EAlignV alignV; //Field offset: 0x30
	public EBlendType blendType; //Field offset: 0x34
	public string label; //Field offset: 0x38
	public int tag; //Field offset: 0x3C
	public Color color; //Field offset: 0x40
	public Color currentColor; //Field offset: 0x50
	public bool enabled; //Field offset: 0x60
	public List<Int32> exInteger; //Field offset: 0x64
	public List<Single> exFloat; //Field offset: 0x68
	public List<String> exString; //Field offset: 0x6C
	private Int32[] popIndex; //Field offset: 0x70

	public SerializableView() { }

	public void AddEx(string s) { }

	private void AddEx(int i) { }

	public void AddEx(float f) { }

	public void AddEx(bool b) { }

	public int Deserialize(List<SerializableView> list, Layout layout) { }

	private int DeserializeChildren(List<SerializableView> list, AbsoluteLayout view, Layout layout) { }

	private void DeserializeImageView(ImageView view) { }

	private void DeserializeScrollView(ScrollView view) { }

	private void DeserializeTextView(TextView view) { }

	private void DeserializeViewBase(List<SerializableView> list, ViewBase view) { }

	public string PopEx(string s) { }

	public bool PopEx(bool b) { }

	public float PopEx(float f) { }

	private int PopEx(int i) { }

	private int PopEx() { }

	public void Serialize(List<SerializableView> list, MaskView view, int parent) { }

	public void Serialize(List<SerializableView> list, ScrollBar view, int parent) { }

	public void Serialize(List<SerializableView> list, ImageView view, int parent) { }

	public void Serialize(List<SerializableView> list, ImageButton view, int parent) { }

	public void Serialize(List<SerializableView> list, AbsoluteLayout view, int parent) { }

	public void Serialize(List<SerializableView> list, TextView view, int parent) { }

	public void Serialize(List<SerializableView> list, ScrollView view, int parent) { }

	public void SerializeChildren(List<SerializableView> list, AbsoluteLayout view) { }

	private void SerializeImageView(ImageView view) { }

	private void SerializeScrollView(ScrollView view) { }

	private void SerializeTextView(TextView view) { }

	private void SerializeViewBase(List<SerializableView> list, ViewBase view, int parent) { }

}

