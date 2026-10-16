namespace D4L.TakashoFes.DataContext;

public interface ICardAccessor : IFlatBuffersAccessor<Card, CardEntry, GuardInt>, IDaoAccessor<Card, CardEntry, GuardInt>
{

}

