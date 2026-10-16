namespace D4L.TakashoFes.DataContext;

public interface IEpisodeAccessor : IFlatBuffersAccessor<Episode, EpisodeEntry, GuardInt>, IDaoAccessor<Episode, EpisodeEntry, GuardInt>
{

	public void BuildAllIndex() { }

}

