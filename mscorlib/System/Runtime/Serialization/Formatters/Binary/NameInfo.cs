namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameInfo
{
	internal string NIFullName; //Field offset: 0x8
	internal long NIobjectId; //Field offset: 0x10
	internal long NIassemId; //Field offset: 0x18
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; //Field offset: 0x20
	internal Type NItype; //Field offset: 0x24
	internal bool NIisSealed; //Field offset: 0x28
	internal bool NIisArray; //Field offset: 0x29
	internal bool NIisArrayItem; //Field offset: 0x2A
	internal bool NItransmitTypeOnObject; //Field offset: 0x2B
	internal bool NItransmitTypeOnMember; //Field offset: 0x2C
	internal bool NIisParentTypeOnObject; //Field offset: 0x2D
	internal InternalArrayTypeE NIarrayEnum; //Field offset: 0x30
	private bool NIsealedStatusChecked; //Field offset: 0x34

	public bool IsSealed
	{
		 get { } //Length: 49
	}

	public string NIname
	{
		 get { } //Length: 64
		 set { } //Length: 27
	}

	internal NameInfo() { }

	public bool get_IsSealed() { }

	public string get_NIname() { }

	internal void Init() { }

	public void set_NIname(string value) { }

}

