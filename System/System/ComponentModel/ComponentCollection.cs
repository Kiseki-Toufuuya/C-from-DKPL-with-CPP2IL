namespace System.ComponentModel;

[DefaultMember("Item")]
public class ComponentCollection : ReadOnlyCollectionBase
{

	public override IComponent Item
	{
		 get { } //Length: 590
	}

	public override IComponent get_Item(string name) { }

}

