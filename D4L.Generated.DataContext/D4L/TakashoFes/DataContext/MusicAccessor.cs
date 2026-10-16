namespace D4L.TakashoFes.DataContext;

public sealed class MusicAccessor : FlatBuffersAccessorBase<Music, MusicEntry, GuardInt>, IMusicAccessor, IFlatBuffersAccessor<Music, MusicEntry, GuardInt>, IDaoAccessor<Music, MusicEntry, GuardInt>
{

	public MusicAccessor() { }

	protected virtual Music Parse(Byte[] source) { }

}

