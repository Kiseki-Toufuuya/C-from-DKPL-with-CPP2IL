namespace D4L.TakashoFes.DataContext;

public sealed class CharacterParameterAccessor : FlatBuffersAccessorBase<CharacterParameter, CharacterParameterEntry, GuardInt>, ICharacterParameterAccessor, IFlatBuffersAccessor<CharacterParameter, CharacterParameterEntry, GuardInt>, IDaoAccessor<CharacterParameter, CharacterParameterEntry, GuardInt>
{

	public CharacterParameterAccessor() { }

	public override void BuildAllIndex() { }

	protected virtual CharacterParameter Parse(Byte[] source) { }

}

