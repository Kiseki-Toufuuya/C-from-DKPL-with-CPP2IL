namespace D4L.TakashoFes.DataContext;

public sealed class MusicSelectionAccessor : FlatBuffersAccessorBase<MusicSelection, MusicSelectionEntry, GuardInt>, IMusicSelectionAccessor, IFlatBuffersAccessor<MusicSelection, MusicSelectionEntry, GuardInt>, IDaoAccessor<MusicSelection, MusicSelectionEntry, GuardInt>
{

	public MusicSelectionAccessor() { }

	protected virtual MusicSelection Parse(Byte[] source) { }

}

