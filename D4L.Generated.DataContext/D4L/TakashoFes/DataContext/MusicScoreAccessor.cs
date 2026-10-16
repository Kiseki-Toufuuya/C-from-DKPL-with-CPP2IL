namespace D4L.TakashoFes.DataContext;

public sealed class MusicScoreAccessor : FlatBuffersAccessorBase<MusicScore, MusicScoreEntry, Int32>, IMusicScoreAccessor, IFlatBuffersAccessor<MusicScore, MusicScoreEntry, Int32>, IDaoAccessor<MusicScore, MusicScoreEntry, Int32>
{

	public MusicScoreAccessor() { }

	protected virtual MusicScore Parse(Byte[] source) { }

}

