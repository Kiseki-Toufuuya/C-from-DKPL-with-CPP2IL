namespace D4L.TakashoFes.DataContext;

public sealed class HeroineGrowthAccessor : FlatBuffersAccessorBase<HeroineGrowth, HeroineGrowthEntry, GuardInt>, IHeroineGrowthAccessor, IFlatBuffersAccessor<HeroineGrowth, HeroineGrowthEntry, GuardInt>, IDaoAccessor<HeroineGrowth, HeroineGrowthEntry, GuardInt>
{

	public HeroineGrowthAccessor() { }

	protected virtual HeroineGrowth Parse(Byte[] source) { }

}

