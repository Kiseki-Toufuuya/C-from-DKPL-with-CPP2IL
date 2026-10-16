namespace D4L.Domain;

public abstract class EntityBase : IEntity<TConcrete, Identity>, IEquatable<TConcrete>
{
	private Identity id; //Field offset: 0x0

	public override Identity Id
	{
		 get { } //Length: 11
	}

	protected EntityBase`2() { }

	public override bool Equals(TConcrete other) { }

	public override Identity get_Id() { }

}

