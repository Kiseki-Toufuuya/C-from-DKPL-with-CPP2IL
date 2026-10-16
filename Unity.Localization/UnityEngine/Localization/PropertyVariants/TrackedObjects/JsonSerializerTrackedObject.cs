namespace UnityEngine.Localization.PropertyVariants.TrackedObjects;

public abstract class JsonSerializerTrackedObject : TrackedObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public JsonSerializerTrackedObject <>4__this; //Field offset: 0x8
		public List<ArraySizeTrackedProperty> arraySizes; //Field offset: 0xC
		public JObject jsonObject; //Field offset: 0x10
		public Locale variantLocale; //Field offset: 0x14
		public LocaleIdentifier defaultLocaleIdentifier; //Field offset: 0x18
		public List<AsyncOperationHandle> asyncOperations; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal void <ApplyLocale>b__0(AsyncOperationHandle<IList`1<AsyncOperationHandle>> res) { }

	}

	internal enum ApplyChangesMethod
	{
		Partial = 0,
		Full = 1,
	}

	public struct ArrayResult
	{
		public string path; //Field offset: 0x0
		public int arrayStartIndex; //Field offset: 0x4
		public int arrayDataIndexStart; //Field offset: 0x8
		public int arrayDataIndexEnd; //Field offset: 0xC

		public bool IsArrayElement
		{
			 get { } //Length: 116
		}

		public bool IsArraySize
		{
			 get { } //Length: 25
		}

		public ArrayResult(string p, int start, int bracketStart, int bracketEnd) { }

		public bool get_IsArrayElement() { }

		public bool get_IsArraySize() { }

		public int GetDataIndex() { }

	}

	private class DeferredJsonObjectOperation
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal DeferredJsonObjectOperation <.cctor>b__5_0() { }

		}

		public static readonly ObjectPool<DeferredJsonObjectOperation> Pool; //Field offset: 0x0
		public JValue jsonValue; //Field offset: 0x8
		public readonly Action<AsyncOperationHandle`1<Object>> callback; //Field offset: 0xC

		private static DeferredJsonObjectOperation() { }

		public DeferredJsonObjectOperation() { }

		private void OnAssetLoaded(AsyncOperationHandle<Object> asyncOperationHandle) { }

	}

	private class DeferredJsonStringOperation
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal DeferredJsonStringOperation <.cctor>b__5_0() { }

		}

		public static readonly ObjectPool<DeferredJsonStringOperation> Pool; //Field offset: 0x0
		public JValue jsonValue; //Field offset: 0x8
		public readonly Action<AsyncOperationHandle`1<String>> callback; //Field offset: 0xC

		private static DeferredJsonStringOperation() { }

		public DeferredJsonStringOperation() { }

		private void OnStringLoaded(AsyncOperationHandle<String> asyncOperationHandle) { }

	}

	[SerializeField]
	[Tooltip("Determines the type of property update that will be performed.- Full update reads the entire object into JSON, patches the properties, then reapplies the new JSON.\n- Partial update generates a partial patch and applies the changes for the tracked properties only.\nPartial update provides better performance however is not supported when modifying collections or properties that contain a serialized version such as Rect.\nThis value is automatically set based on the properties tracked.")]
	private ApplyChangesMethod m_UpdateType; //Field offset: 0x14

	public ApplyChangesMethod UpdateType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	protected JsonSerializerTrackedObject() { }

	public virtual void AddTrackedProperty(ITrackedProperty trackedProperty) { }

	private void ApplyArraySizes(IEnumerable<ArraySizeTrackedProperty> arraySizes, JObject jsonObject, LocaleIdentifier variantLocale, LocaleIdentifier defaultLocale) { }

	private void ApplyJson(JObject jsonObject) { }

	public virtual AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	public ApplyChangesMethod get_UpdateType() { }

	internal static ArrayResult GetNextArrayItem(string path, int startIndex) { }

	internal static JToken GetPropertyFromPath(string path, JContainer obj) { }

	public void set_UpdateType(ApplyChangesMethod value) { }

}

