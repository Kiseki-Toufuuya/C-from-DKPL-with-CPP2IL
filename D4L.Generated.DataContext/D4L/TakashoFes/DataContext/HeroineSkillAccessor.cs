namespace D4L.TakashoFes.DataContext;

public sealed class HeroineSkillAccessor : FlatBuffersAccessorBase<HeroineSkill, HeroineSkillEntry, GuardInt>, IHeroineSkillAccessor, IFlatBuffersAccessor<HeroineSkill, HeroineSkillEntry, GuardInt>, IDaoAccessor<HeroineSkill, HeroineSkillEntry, GuardInt>
{

	public HeroineSkillAccessor() { }

	protected virtual HeroineSkill Parse(Byte[] source) { }

}

