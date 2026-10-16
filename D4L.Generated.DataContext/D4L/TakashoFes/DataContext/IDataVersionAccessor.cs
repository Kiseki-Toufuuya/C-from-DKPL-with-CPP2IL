namespace D4L.TakashoFes.DataContext;

public interface IDataVersionAccessor : IFlatBuffersAccessor<DataVersion, DataVersionEntry, Int64>, IDaoAccessor<DataVersion, DataVersionEntry, Int64>
{

	public void BuildAllIndex() { }

}

