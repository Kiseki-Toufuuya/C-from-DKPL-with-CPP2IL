namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class DynamicUtils
{
	[Nullable(0)]
	public static class BinderWrapper
	{
		[Nullable(2)]
		private static object _getCSharpArgumentInfoArray; //Field offset: 0x0
		[Nullable(2)]
		private static object _setCSharpArgumentInfoArray; //Field offset: 0x4
		[Nullable(2)]
		private static MethodCall<Object, Object> _getMemberCall; //Field offset: 0x8
		[Nullable(2)]
		private static MethodCall<Object, Object> _setMemberCall; //Field offset: 0xC
		private static bool _init; //Field offset: 0x10

		private static void CreateMemberCalls() { }

		private static object CreateSharpArgumentInfoArray(Int32[] values) { }

		public static CallSiteBinder GetMember(string name, Type context) { }

		private static void Init() { }

		public static CallSiteBinder SetMember(string name, Type context) { }

	}


	[Extension]
	public static IEnumerable<String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

