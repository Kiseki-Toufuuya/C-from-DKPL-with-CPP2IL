namespace XeSys.Gfx;

public class Layout
{
	private enum ViewType
	{
		AbsoluteLayout = 0,
		ImageView = 1,
		ImageButton = 2,
		TextView = 3,
		ScrollText = 4,
		EditText = 5,
		ScrollView = 6,
		AutoScrollView = 7,
		MaskView = 8,
	}

	private const string AbsoluteLayoutTag = "AL"; //Field offset: 0x0
	private const string textAtt = "tt"; //Field offset: 0x0
	private const string textColorAtt = "tC"; //Field offset: 0x0
	private const string gravityAtt = "gv"; //Field offset: 0x0
	private const string lineSpacingAtt = "lS"; //Field offset: 0x0
	private const string hintAtt = "ht"; //Field offset: 0x0
	private const string hintColorAtt = "tCH"; //Field offset: 0x0
	private const string linesAtt = "ls"; //Field offset: 0x0
	private const string barBaseScrAtt = "bBS"; //Field offset: 0x0
	private const string barScrAtt = "bS"; //Field offset: 0x0
	private const string scaleXAtt = "sX"; //Field offset: 0x0
	private const string scaleYAtt = "sY"; //Field offset: 0x0
	private const string rotAtt = "rt"; //Field offset: 0x0
	private const string blendTypeAtt = "bT"; //Field offset: 0x0
	private const string matrixAtt = "mtx"; //Field offset: 0x0
	private const string transformPointAtt = "tP"; //Field offset: 0x0
	private const string scrollDecRateAtt = "dR"; //Field offset: 0x0
	private const string baseXAtt = "bX"; //Field offset: 0x0
	private const string baseYAtt = "bY"; //Field offset: 0x0
	private const string isApplyColorAtt = "iAC"; //Field offset: 0x0
	private const string LabelAtt = "lb"; //Field offset: 0x0
	private const string FlipYAtt = "fY"; //Field offset: 0x0
	private const string textSizeAtt = "tS"; //Field offset: 0x0
	private const string colorAtt = "co"; //Field offset: 0x0
	private const string ImageViewTag = "IV"; //Field offset: 0x0
	private const string ImageButtonTag = "IB"; //Field offset: 0x0
	private const string TextViewTag = "TV"; //Field offset: 0x0
	private const string ScrollViewTag = "SV"; //Field offset: 0x0
	private const string MaskViewTag = "MV"; //Field offset: 0x0
	private const string FlipXAtt = "fX"; //Field offset: 0x0
	private const string idAtt = "id"; //Field offset: 0x0
	private const string exidAtt = "ei"; //Field offset: 0x0
	private const string animIdAtt = "ai"; //Field offset: 0x0
	private const string heightAtt = "lh"; //Field offset: 0x0
	private static Dictionary<String, ViewType> TagToViewTypeDic; //Field offset: 0x0
	private const string xAtt = "lx"; //Field offset: 0x0
	private const string yAtt = "ly"; //Field offset: 0x0
	private const string centerXAtt = "cx"; //Field offset: 0x0
	private const string centerYAtt = "cy"; //Field offset: 0x0
	private const string scaleTypeAtt = "sT"; //Field offset: 0x0
	private const string srcAtt = "sc"; //Field offset: 0x0
	private const string widthAtt = "lw"; //Field offset: 0x0
	private const string backgroundAtt = "bg"; //Field offset: 0x0
	private const string alignHAtt = "aH"; //Field offset: 0x0
	private const string alignVAtt = "aV"; //Field offset: 0x0
	private static int lineSpaceBase; //Field offset: 0x4
	private static EAlignH defaultAlignH; //Field offset: 0x8
	private static EAlignV defaultAlignV; //Field offset: 0xC
	private static Dictionary<String, EAlignH> AlignHStrToValDic; //Field offset: 0x10
	private static Dictionary<String, EAlignV> AlignVStrToValDic; //Field offset: 0x14
	private static Dictionary<String, EAlignV> gravityVStrToValDic; //Field offset: 0x18
	private FontInfo m_fontInfo; //Field offset: 0x8
	[CompilerGenerated]
	private bool <isLoaded>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private bool <isSubLayout>k__BackingField; //Field offset: 0xD
	private AbsoluteLayout m_Root; //Field offset: 0x10
	private Dictionary<String, String> m_TmpAttDic; //Field offset: 0x14

	public FontInfo fontInfo
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public private bool isLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool isSubLayout
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public AbsoluteLayout Root
	{
		 get { } //Length: 11
	}

	private Dictionary<String, String> TmpAttDic
	{
		private get { } //Length: 11
	}

	private static Layout() { }

	public Layout() { }

	public Layout(bool subLayout) { }

	private void AddXmlAttributeDic(XmlReader reader, Dictionary<String, String> dic) { }

	public void Clear() { }

	public void CopyTo(Layout layout) { }

	public Layout DeepClone() { }

	public ViewBase FindViewByExId(string exid) { }

	public ViewBase FindViewById(string id) { }

	public FontInfo get_fontInfo() { }

	[CompilerGenerated]
	public bool get_isLoaded() { }

	[CompilerGenerated]
	public bool get_isSubLayout() { }

	public AbsoluteLayout get_Root() { }

	private Dictionary<String, String> get_TmpAttDic() { }

	public static EAlignH GetAlignH(string str) { }

	public static EAlignV GetAlignV(string str) { }

	public void InitializeEmptyAnimationAll(bool force = false) { }

	public bool IsPlayingAll() { }

	public bool IsPlayingAllNotLoop() { }

	public void LoadFromBytes(Byte[] bytes) { }

	public void LoadFromString(string layoutText) { }

	private void ReadAbsoluteLayoutAtt(AbsoluteLayout abs, Dictionary<String, String> dic) { }

	private void ReadAbsoluteLayoutReader(AbsoluteLayout abs, XmlReader reader) { }

	private void ReadChildrenView(AbsoluteLayout abs, XmlReader reader) { }

	private void ReadCommonAtt(ViewBase view, Dictionary<String, String> dic) { }

	private void ReadImageButtonAtt(ImageButton imgbuton, Dictionary<String, String> dic) { }

	private void ReadImageButtonReader(ImageButton imgbuton, XmlReader reader) { }

	private void ReadImageViewAtt(ImageView imgview, Dictionary<String, String> dic) { }

	private void ReadImageViewReader(ImageView imgview, XmlReader reader) { }

	private void ReadMaskViewAtt(MaskView maskview, Dictionary<String, String> dic) { }

	private void ReadMaskViewReader(MaskView maskview, XmlReader reader) { }

	private void ReadScrollViewAtt(ScrollView scrollView, Dictionary<String, String> dic) { }

	private void ReadScrollViewReader(ScrollView scrollView, XmlReader reader) { }

	private void ReadTextViewAtt(TextView textView, Dictionary<String, String> dic) { }

	private void ReadTextViewReader(TextView textView, XmlReader reader) { }

	private void ReadXmlStringReader(string text) { }

	public void set_fontInfo(FontInfo value) { }

	[CompilerGenerated]
	private void set_isLoaded(bool value) { }

	[CompilerGenerated]
	private void set_isSubLayout(bool value) { }

	public void SettingAnimation(LayoutAnimation anim) { }

	public void SettingTexture(TexUVListManager texManager) { }

	public void StartAllAnim() { }

	public void StartAllAnimDecoLoop() { }

	public void StartAllAnimDecoOnce() { }

	public void StartAllAnimDefault() { }

	public void StartAllAnimGoStop(string startLabel, string endLabel) { }

	public void StartAllAnimGoStop(string startLabel) { }

	public void StartAllAnimGoStopFrame(int start, int end) { }

	public void StartAllAnimIn() { }

	public void StartAllAnimIn2() { }

	public void StartAllAnimInToOut() { }

	public void StartAllAnimLoop(string startLabel, string endLabel) { }

	public void StartAllAnimLoop(string startLabel) { }

	public void StartAllAnimLoopFrame(int start, int end) { }

	public void StartAllAnimOut() { }

	public void UpdateAll(Color color) { }

	public void UpdateAll() { }

	public void UpdateAllAnimation(float dt) { }

}

