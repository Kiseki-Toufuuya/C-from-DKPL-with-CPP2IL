namespace Heqet;

public class NotesSkinModel : EntityBase<NotesSkinModel, Int32>
{
	public int ID; //Field offset: 0xC
	public int Enable; //Field offset: 0x10
	public int DataVersion; //Field offset: 0x14
	public int UseFlag; //Field offset: 0x18
	public int NotesGroupID; //Field offset: 0x1C
	public int TapEffectGroupID; //Field offset: 0x20
	public int LeneEffectGroupID; //Field offset: 0x24

	public NotesSkinModel() { }

}

