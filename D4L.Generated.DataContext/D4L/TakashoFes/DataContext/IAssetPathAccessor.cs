namespace D4L.TakashoFes.DataContext;

public interface IAssetPathAccessor : IFlatBuffersAccessor<AssetPath, AssetPathEntry, Int64>, IDaoAccessor<AssetPath, AssetPathEntry, Int64>
{

	public void BuildAllIndex() { }

	public IEnumerable<AssetPathEntry> TryGetByAssetPath(string key) { }

	public IEnumerable<AssetPathEntry> TryGetByHashedPath(string key) { }

}

