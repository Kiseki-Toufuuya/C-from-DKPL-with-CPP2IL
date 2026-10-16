namespace D4L.TakashoFes.DataContext;

public interface ICharacterParameterAccessor : IFlatBuffersAccessor<CharacterParameter, CharacterParameterEntry, GuardInt>, IDaoAccessor<CharacterParameter, CharacterParameterEntry, GuardInt>
{

	public void BuildAllIndex() { }

}

