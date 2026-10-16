namespace D4L.TakashoFes.DataContext;

public sealed class CardAccessor : FlatBuffersAccessorBase<Card, CardEntry, GuardInt>, ICardAccessor, IFlatBuffersAccessor<Card, CardEntry, GuardInt>, IDaoAccessor<Card, CardEntry, GuardInt>
{

	public CardAccessor() { }

	protected virtual Card Parse(Byte[] source) { }

}

