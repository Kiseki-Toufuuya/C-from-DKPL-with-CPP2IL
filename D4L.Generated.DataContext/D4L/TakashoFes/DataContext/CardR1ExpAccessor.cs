namespace D4L.TakashoFes.DataContext;

public sealed class CardR1ExpAccessor : FlatBuffersAccessorBase<CardR1Exp, CardR1ExpEntry, GuardInt>, ICardR1ExpAccessor, IFlatBuffersAccessor<CardR1Exp, CardR1ExpEntry, GuardInt>, IDaoAccessor<CardR1Exp, CardR1ExpEntry, GuardInt>
{

	public CardR1ExpAccessor() { }

	protected virtual CardR1Exp Parse(Byte[] source) { }

}

