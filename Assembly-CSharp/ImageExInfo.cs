//Type is in global namespace

public class ImageExInfo : ImageExInfoBase<Sprite, ImageEx>
{

	public ImageExInfo() { }

	public virtual void ChgImageSlice(int idx) { }

	protected virtual Sprite GetSliceData(TexUVFilePack pack, int idx, string texName) { }

}

