namespace System.Reflection;

public class TypeDelegator : TypeInfo
{
	protected Type typeImpl; //Field offset: 0xC

	public virtual Assembly Assembly
	{
		 get { } //Length: 40
	}

	public virtual string AssemblyQualifiedName
	{
		 get { } //Length: 40
	}

	public virtual Type BaseType
	{
		 get { } //Length: 40
	}

	public virtual string FullName
	{
		 get { } //Length: 40
	}

	public virtual Guid GUID
	{
		 get { } //Length: 58
	}

	public virtual bool IsCollectible
	{
		 get { } //Length: 40
	}

	public virtual bool IsConstructedGenericType
	{
		 get { } //Length: 40
	}

	public virtual bool IsGenericMethodParameter
	{
		 get { } //Length: 40
	}

	public virtual bool IsSZArray
	{
		 get { } //Length: 40
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 40
	}

	public virtual Module Module
	{
		 get { } //Length: 40
	}

	public virtual string Name
	{
		 get { } //Length: 40
	}

	public virtual string Namespace
	{
		 get { } //Length: 40
	}

	public virtual RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 40
	}

	public virtual Type UnderlyingSystemType
	{
		 get { } //Length: 40
	}

	public TypeDelegator(Type delegatingType) { }

	public virtual Assembly get_Assembly() { }

	public virtual string get_AssemblyQualifiedName() { }

	public virtual Type get_BaseType() { }

	public virtual string get_FullName() { }

	public virtual Guid get_GUID() { }

	public virtual bool get_IsCollectible() { }

	public virtual bool get_IsConstructedGenericType() { }

	public virtual bool get_IsGenericMethodParameter() { }

	public virtual bool get_IsSZArray() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual string get_Namespace() { }

	public virtual RuntimeTypeHandle get_TypeHandle() { }

	public virtual Type get_UnderlyingSystemType() { }

	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Type GetElementType() { }

	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	public virtual Type GetInterface(string name, bool ignoreCase) { }

	[ComVisible(True)]
	public virtual InterfaceMapping GetInterfaceMap(Type interfaceType) { }

	public virtual Type[] GetInterfaces() { }

	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public virtual Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	protected virtual bool HasElementTypeImpl() { }

	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	protected virtual bool IsArrayImpl() { }

	public virtual bool IsAssignableFrom(TypeInfo typeInfo) { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsCOMObjectImpl() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	protected virtual bool IsPointerImpl() { }

	protected virtual bool IsPrimitiveImpl() { }

	protected virtual bool IsValueTypeImpl() { }

}

