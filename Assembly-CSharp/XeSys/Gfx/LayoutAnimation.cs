namespace XeSys.Gfx;

public class LayoutAnimation
{
	private enum ECtrlType
	{
		frameIdx = 0,
		time = 1,
		x = 2,
		xn = 3,
		xp = 4,
		y = 5,
		yn = 6,
		yp = 7,
		rot = 8,
		scaleX = 9,
		scaleY = 10,
		rp = 11,
		ro = 12,
		gp = 13,
		go = 14,
		bp = 15,
		bo = 16,
		ap = 17,
		ao = 18,
		src = 19,
		none = 20,
	}

	private enum ETagType
	{
		LayoutAnim = 0,
		Layer = 1,
		Frame = 2,
		Label = 3,
		CtrlType = 4,
		CtrlPoint = 5,
		TimeMap = 6,
		CustomTimeMap = 7,
	}

	private const string LayoutAnimTag = "LA"; //Field offset: 0x0
	private const string CtrlTypeXNStr = "XN"; //Field offset: 0x0
	private const string CtrlTypeXPStr = "XP"; //Field offset: 0x0
	private const string CtrlTypeYStr = "Y"; //Field offset: 0x0
	private const string CtrlTypeYNStr = "YN"; //Field offset: 0x0
	private const string CtrlTypeYPStr = "YP"; //Field offset: 0x0
	private const string CtrlTypeRotStr = "Rot"; //Field offset: 0x0
	private const string CtrlTypeScaleXStr = "ScaleX"; //Field offset: 0x0
	private const string CtrlTypeScaleYStr = "ScaleY"; //Field offset: 0x0
	private const string CtrlTypeRpStr = "Rp"; //Field offset: 0x0
	private const string CtrlTypeXStr = "X"; //Field offset: 0x0
	private const string CtrlTypeRoStr = "Ro"; //Field offset: 0x0
	private const string CtrlTypeGoStr = "Go"; //Field offset: 0x0
	private const string CtrlTypeBpStr = "Bp"; //Field offset: 0x0
	private const string CtrlTypeBoStr = "Bo"; //Field offset: 0x0
	private const string CtrlTypeApStr = "Ap"; //Field offset: 0x0
	private const string CtrlTypeAoStr = "Ao"; //Field offset: 0x0
	private const string CtrlTypeSrcStr = "Src"; //Field offset: 0x0
	private static Dictionary<String, ETagType> TagToTypeDic; //Field offset: 0x0
	private const int LabelLabelElmIdx = 0; //Field offset: 0x0
	private const int LabelFrameElmIdx = 1; //Field offset: 0x0
	private const string CtrlTypeGpStr = "Gp"; //Field offset: 0x0
	private const int CustomTimeMapElmPrevIdx = 2; //Field offset: 0x0
	private const int CustomTimeMapElmNum = 3; //Field offset: 0x0
	private const int CustomTimeMapElmPointIdx = 0; //Field offset: 0x0
	private const string idAtt = "id"; //Field offset: 0x0
	private const string FrameRateAtt = "FR"; //Field offset: 0x0
	private const string LayerTag = "La"; //Field offset: 0x0
	private const string AlignHAtt = "aH"; //Field offset: 0x0
	private const string AlignVAtt = "aV"; //Field offset: 0x0
	private const string FrameNumAtt = "FN"; //Field offset: 0x0
	private const string ParentAtt = "Pa"; //Field offset: 0x0
	private const string FrameTag = "Fr"; //Field offset: 0x0
	private const string LabelTag = "Lb"; //Field offset: 0x0
	private const int CustomTimeMapElmNextIdx = 1; //Field offset: 0x0
	private const string CtrlPointTag = "CP"; //Field offset: 0x0
	private const string CtrlTypeTag = "CT"; //Field offset: 0x0
	private const string CustomTimeMapTag = "CTM"; //Field offset: 0x0
	private const string QuadraticElmStr = "Q"; //Field offset: 0x0
	private const string CustomElmStr = "C"; //Field offset: 0x0
	private const int TimeMapElmStartIdx = 0; //Field offset: 0x0
	private const int TimeMapElmEndIdx = 1; //Field offset: 0x0
	private const int TimeMapElmTypeIdx = 2; //Field offset: 0x0
	private const int TimeMapElmStrengthIdx = 3; //Field offset: 0x0
	private const int TimeMapElmNumIdx = 4; //Field offset: 0x0
	private const int TimeMapElmNum = 5; //Field offset: 0x0
	private const string TimeMapTag = "TM"; //Field offset: 0x0
	private static Dictionary<String, ECtrlType> TypeSetDic; //Field offset: 0x4
	private static float DefaultFrameSec; //Field offset: 0x8
	private float m_FrameSec; //Field offset: 0x8
	private Dictionary<String, ViewFrameAnimation> m_AnimLayers; //Field offset: 0xC
	private Dictionary<String, String> m_TmpAttDic; //Field offset: 0x10

	public Dictionary<String, ViewFrameAnimation> AnimLayers
	{
		 get { } //Length: 11
	}

	public float FrameSec
	{
		 get { } //Length: 11
	}

	private Dictionary<String, String> TmpAttDic
	{
		private get { } //Length: 11
	}

	private static LayoutAnimation() { }

	public LayoutAnimation() { }

	private void AddXmlAttributeDic(XmlReader reader, Dictionary<String, String> dic) { }

	private void Claer() { }

	public Dictionary<String, ViewFrameAnimation> get_AnimLayers() { }

	public float get_FrameSec() { }

	private Dictionary<String, String> get_TmpAttDic() { }

	public void LoadFromBytes(Byte[] bytes, float frameSec) { }

	public void LoadFromBytes(Byte[] bytes) { }

	private FrameData[] ParseCtrlPoint(string val, List<ECtrlType> typeList) { }

	private void ParseTimeMap(ViewFrameAnimation animData, string timemapListStr) { }

	private void ReadCtrlPointReader(ViewFrameAnimation animData, XmlReader reader, List<ECtrlType> typeList, Dictionary<Int32, String> labelList) { }

	private void ReadCtrlTypeReader(List<ECtrlType> typeList, XmlReader reader) { }

	private void ReadFrameReader(ViewFrameAnimation animData, XmlReader reader, Dictionary<Int32, String> labelList) { }

	private void ReadLabelReader(Dictionary<Int32, String> labelList, XmlReader reader) { }

	private string ReadLayerReader(out ViewFrameAnimation animData, XmlReader reader, Dictionary<Int32, String> labelList) { }

	private void ReadLayoutAnimReader(XmlReader reader) { }

	private void ReadTimeMapReader(ViewFrameAnimation animData, XmlReader reader) { }

	public void ReadXmlStringReader(string text, float frameSec) { }

	public void ReadXmlStringReader(string text) { }

}

