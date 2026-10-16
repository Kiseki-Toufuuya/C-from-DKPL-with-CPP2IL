namespace D4L.TakashoFes.DataContext;

public sealed class CardR2ExpAccessor : FlatBuffersAccessorBase<CardR2Exp, CardR2ExpEntry, GuardInt>, ICardR2ExpAccessor, IFlatBuffersAccessor<CardR2Exp, CardR2ExpEntry, GuardInt>, IDaoAccessor<CardR2Exp, CardR2ExpEntry, GuardInt>
{

	public CardR2ExpAccessor() { }

	protected virtual CardR2Exp Parse(Byte[] source) { }

}

