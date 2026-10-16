namespace Newtonsoft.Json;

[AttributeUsage(1036, AllowMultiple = False)]
public sealed class JsonObjectAttribute : JsonContainerAttribute
{
	private MemberSerialization _memberSerialization; //Field offset: 0x30
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x34
	internal Nullable<Required> _itemRequired; //Field offset: 0x3C
	internal Nullable<NullValueHandling> _itemNullValueHandling; //Field offset: 0x44

	public MemberSerialization MemberSerialization
	{
		 get { } //Length: 11
	}

	public MemberSerialization get_MemberSerialization() { }

}

