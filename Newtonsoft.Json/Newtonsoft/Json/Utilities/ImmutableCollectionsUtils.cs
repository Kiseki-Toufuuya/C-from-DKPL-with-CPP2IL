namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class ImmutableCollectionsUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<MethodInfo, Boolean> <>9__24_1; //Field offset: 0x4
		[Nullable(0)]
		public static Func<MethodInfo, Boolean> <>9__25_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		[Nullable(0)]
		public string name; //Field offset: 0x8

		public <>c__DisplayClass24_0() { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		[Nullable(0)]
		public string name; //Field offset: 0x8

		public <>c__DisplayClass25_0() { }

		[NullableContext(0)]
		internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

	}

	[Nullable(0)]
	public class ImmutableCollectionTypeInfo
	{
		[CompilerGenerated]
		private string <ContractTypeName>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private string <CreatedTypeName>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private string <BuilderTypeName>k__BackingField; //Field offset: 0x10

		public string BuilderTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public string ContractTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public string CreatedTypeName
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName) { }

		[CompilerGenerated]
		public string get_BuilderTypeName() { }

		[CompilerGenerated]
		public string get_ContractTypeName() { }

		[CompilerGenerated]
		public string get_CreatedTypeName() { }

		[CompilerGenerated]
		public void set_BuilderTypeName(string value) { }

		[CompilerGenerated]
		public void set_ContractTypeName(string value) { }

		[CompilerGenerated]
		public void set_CreatedTypeName(string value) { }

	}

	private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; //Field offset: 0x0
	private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; //Field offset: 0x4

	private static ImmutableCollectionsUtils() { }

	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<Object>& parameterizedCreator) { }

}

