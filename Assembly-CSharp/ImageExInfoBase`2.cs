//Type is in global namespace

public abstract class ImageExInfoBase : MonoBehaviour, ITexUvFilePackPathInfo, IChgImageSlice
{
	private class UITextData
	{
		public string id; //Field offset: 0x0
		public Text text; //Field offset: 0x0

		public UITextData() { }

		public void SetColor(TextType textType, int colorIdx, Color col) { }

		public void SetTextComponent(Component component, TextType textType) { }

	}

	[HideInInspector]
	[SerializeField]
	private string m_TexUvFilePackPath; //Field offset: 0x0
	[SerializeField]
	private List<ChgSliceData> m_ChgSliceDataList; //Field offset: 0x0
	private T2 m_Image; //Field offset: 0x0
	private Dictionary<String, HashSet`1<Int32>> m_ChgFontColorDataDic; //Field offset: 0x0
	private Dictionary<String, List`1<UITextData<T, T2>>> m_TextListDic; //Field offset: 0x0
	private List<T> m_SliceList; //Field offset: 0x0

	public List<ChgSliceData> ChgSliceDataList
	{
		 get { } //Length: 11
	}

	public T2 Image
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public List<T> SliceList
	{
		 get { } //Length: 11
	}

	public override string TexUvFilePackPath
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	protected ImageExInfoBase`2() { }

	public override void AddChgSliceData(ChgSliceData data) { }

	public override void Chg(int idx) { }

	public override void ChgFontColor(int idx) { }

	public void ChgImageColor(int idx) { }

	public abstract void ChgImageSlice(int idx) { }

	public override void ClearChgSliceDataList() { }

	public List<ChgSliceData> get_ChgSliceDataList() { }

	public T2 get_Image() { }

	public List<T> get_SliceList() { }

	public override string get_TexUvFilePackPath() { }

	public override ChgSliceData GetChgSliceData(int idx) { }

	public override int GetChgSliceDataNum() { }

	protected abstract T GetSliceData(TexUVFilePack pack, int idx, string texName) { }

	public override void InitChgSlice(List<TexUVFilePack> packs, IAlphaTexture image) { }

	public override void InitChgSlice(List<TexUVFilePack> packs) { }

	public void InitChgTextList() { }

	private void InitSliceList() { }

	private void MakeChgFontColorDataDic() { }

	public void set_Image(T2 value) { }

	public override void set_TexUvFilePackPath(string value) { }

	public override void SetChgSlicdData(int idx, ChgSliceData data) { }

	private void SettingTextData(Text text, UITextData<T, T2> textData, HashSet<Int32> textTypeHash) { }

}

