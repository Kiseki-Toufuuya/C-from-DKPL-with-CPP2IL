namespace D4L.TakashoFes.DataContext;

public sealed class MusicProductAccessor : FlatBuffersAccessorBase<MusicProduct, MusicProductEntry, Int32>, IMusicProductAccessor, IFlatBuffersAccessor<MusicProduct, MusicProductEntry, Int32>, IDaoAccessor<MusicProduct, MusicProductEntry, Int32>
{

	public MusicProductAccessor() { }

	protected virtual MusicProduct Parse(Byte[] source) { }

}

