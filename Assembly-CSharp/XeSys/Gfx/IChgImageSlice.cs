namespace XeSys.Gfx;

public interface IChgImageSlice
{

	public void AddChgSliceData(ChgSliceData data) { }

	public void Chg(int idx) { }

	public void ChgFontColor(int idx) { }

	public void ChgImageSlice(int idx) { }

	public void ClearChgSliceDataList() { }

	public ChgSliceData GetChgSliceData(int idx) { }

	public int GetChgSliceDataNum() { }

	public void InitChgSlice(List<TexUVFilePack> packs, IAlphaTexture image) { }

	public void InitChgSlice(List<TexUVFilePack> packs) { }

	public void SetChgSlicdData(int idx, ChgSliceData data) { }

}

