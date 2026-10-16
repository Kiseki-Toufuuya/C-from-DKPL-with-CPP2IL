namespace D4L.TakashoFes.DataContext;

public interface IMusicAccessor : IFlatBuffersAccessor<Music, MusicEntry, GuardInt>, IDaoAccessor<Music, MusicEntry, GuardInt>
{

}

