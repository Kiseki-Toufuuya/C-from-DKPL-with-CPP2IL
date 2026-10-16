namespace D4L.TakashoFes.DataContext;

public sealed class EpisodeRewardAccessor : FlatBuffersAccessorBase<EpisodeReward, EpisodeRewardEntry, GuardInt>, IEpisodeRewardAccessor, IFlatBuffersAccessor<EpisodeReward, EpisodeRewardEntry, GuardInt>, IDaoAccessor<EpisodeReward, EpisodeRewardEntry, GuardInt>
{

	public EpisodeRewardAccessor() { }

	protected virtual EpisodeReward Parse(Byte[] source) { }

}

