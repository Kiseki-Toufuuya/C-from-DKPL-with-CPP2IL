namespace D4L.TakashoFes.DataContext;

public sealed class EpisodeLivePresetAccessor : FlatBuffersAccessorBase<EpisodeLivePreset, EpisodeLivePresetEntry, GuardInt>, IEpisodeLivePresetAccessor, IFlatBuffersAccessor<EpisodeLivePreset, EpisodeLivePresetEntry, GuardInt>, IDaoAccessor<EpisodeLivePreset, EpisodeLivePresetEntry, GuardInt>
{

	public EpisodeLivePresetAccessor() { }

	protected virtual EpisodeLivePreset Parse(Byte[] source) { }

}

