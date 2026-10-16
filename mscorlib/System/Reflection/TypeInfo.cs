namespace System.Reflection;

public abstract class TypeInfo : Type, IReflectableType
{

	public override IEnumerable<FieldInfo> DeclaredFields
	{
		 get { } //Length: 30
	}

	public override IEnumerable<Type> ImplementedInterfaces
	{
		 get { } //Length: 28
	}

	protected TypeInfo() { }

	public override Type AsType() { }

	public override IEnumerable<FieldInfo> get_DeclaredFields() { }

	public override IEnumerable<Type> get_ImplementedInterfaces() { }

	public override MethodInfo GetDeclaredMethod(string name) { }

	public override PropertyInfo GetDeclaredProperty(string name) { }

	public override bool IsAssignableFrom(TypeInfo typeInfo) { }

	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

