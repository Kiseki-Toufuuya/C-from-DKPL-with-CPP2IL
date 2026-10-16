namespace D4L.TakashoFes.DataContext;

public sealed class DataVersionAccessor : FlatBuffersAccessorBase<DataVersion, DataVersionEntry, Int64>, IDataVersionAccessor, IFlatBuffersAccessor<DataVersion, DataVersionEntry, Int64>, IDaoAccessor<DataVersion, DataVersionEntry, Int64>
{

	public DataVersionAccessor() { }

	public override void BuildAllIndex() { }

	protected virtual DataVersion Parse(Byte[] source) { }

}

