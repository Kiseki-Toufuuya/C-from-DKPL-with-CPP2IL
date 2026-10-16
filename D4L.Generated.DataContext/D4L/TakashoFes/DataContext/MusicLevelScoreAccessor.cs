namespace D4L.TakashoFes.DataContext;

public sealed class MusicLevelScoreAccessor : FlatBuffersAccessorBase<MusicLevelScore, MusicLevelScoreEntry, Int32>, IMusicLevelScoreAccessor, IFlatBuffersAccessor<MusicLevelScore, MusicLevelScoreEntry, Int32>, IDaoAccessor<MusicLevelScore, MusicLevelScoreEntry, Int32>
{

	public MusicLevelScoreAccessor() { }

	protected virtual MusicLevelScore Parse(Byte[] source) { }

}

