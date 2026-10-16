namespace D4L.TakashoFes.DataContext;

public sealed class HeroineAccessor : FlatBuffersAccessorBase<Heroine, HeroineEntry, GuardInt>, IHeroineAccessor, IFlatBuffersAccessor<Heroine, HeroineEntry, GuardInt>, IDaoAccessor<Heroine, HeroineEntry, GuardInt>
{

	public HeroineAccessor() { }

	protected virtual Heroine Parse(Byte[] source) { }

}

