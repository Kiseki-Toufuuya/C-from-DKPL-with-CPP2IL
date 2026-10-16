namespace D4L.TakashoFes.DataContext;

public sealed class EpisodeAccessor : FlatBuffersAccessorBase<Episode, EpisodeEntry, GuardInt>, IEpisodeAccessor, IFlatBuffersAccessor<Episode, EpisodeEntry, GuardInt>, IDaoAccessor<Episode, EpisodeEntry, GuardInt>
{

	public EpisodeAccessor() { }

	public override void BuildAllIndex() { }

	protected virtual Episode Parse(Byte[] source) { }

}

