//Type is in global namespace

public class RawImageExInfo : ImageExInfoBase<TexUVData, RawImageEx>
{

	public RawImageExInfo() { }

	public virtual void ChgImageSlice(int idx) { }

	protected virtual TexUVData GetSliceData(TexUVFilePack pack, int idx, string texName) { }

}

