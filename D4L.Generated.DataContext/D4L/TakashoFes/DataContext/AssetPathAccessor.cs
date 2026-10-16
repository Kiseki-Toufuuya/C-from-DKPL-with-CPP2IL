namespace D4L.TakashoFes.DataContext;

public sealed class AssetPathAccessor : FlatBuffersAccessorBase<AssetPath, AssetPathEntry, Int64>, IAssetPathAccessor, IFlatBuffersAccessor<AssetPath, AssetPathEntry, Int64>, IDaoAccessor<AssetPath, AssetPathEntry, Int64>
{
	private Dictionary<String, Int64[]> _AssetPathIndex; //Field offset: 0x14
	private Dictionary<String, Int64[]> _HashedPathIndex; //Field offset: 0x18

	public AssetPathAccessor() { }

	public override void BuildAllIndex() { }

	private void BuildAssetPathIndex() { }

	private void BuildHashedPathIndex() { }

	protected virtual AssetPath Parse(Byte[] source) { }

	public override IEnumerable<AssetPathEntry> TryGetByAssetPath(string key) { }

	public override IEnumerable<AssetPathEntry> TryGetByHashedPath(string key) { }

}

