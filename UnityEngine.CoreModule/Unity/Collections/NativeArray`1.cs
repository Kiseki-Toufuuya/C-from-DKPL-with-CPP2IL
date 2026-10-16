namespace Unity.Collections;

[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeArray : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray`1<T>>
{
	[ExcludeFromDocs]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeArray<T> m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0
		private T value; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 50
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 118
		}

		public Enumerator(ref NativeArray<T>& array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView`1))]
	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[ExcludeFromDocs]
		internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private ReadOnly<T> m_Array; //Field offset: 0x0
			private int m_Index; //Field offset: 0x0
			private T value; //Field offset: 0x0

			public override T Current
			{
				 get { } //Length: 50
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 118
			}

			public Enumerator(in ReadOnly<T> array) { }

			public override void Dispose() { }

			public override T get_Current() { }

			public override bool MoveNext() { }

			public override void Reset() { }

			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[NativeDisableUnsafePtrRestriction]
		internal Void* m_Buffer; //Field offset: 0x0
		internal int m_Length; //Field offset: 0x0

		public T Item
		{
			 get { } //Length: 105
		}

		public int Length
		{
			 get { } //Length: 11
		}

		internal ReadOnly(Void* buffer, int length) { }

		public T get_Item(int index) { }

		public int get_Length() { }

		public Enumerator<T> GetEnumerator() { }

		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[NativeDisableUnsafePtrRestriction]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule"})]
	internal Void* m_Buffer; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		 get { } //Length: 14
	}

	public T Item
	{
		 get { } //Length: 105
		[WriteAccessRequired]
		 set { } //Length: 86
	}

	public int Length
	{
		 get { } //Length: 11
	}

	public NativeArray`1(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	public NativeArray`1(T[] array, Allocator allocator) { }

	private static void Allocate(int length, Allocator allocator, out NativeArray<T>& array) { }

	public ReadOnly<T> AsReadOnly() { }

	public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	public static void Copy(NativeArray<T> src, T[] dst, int length) { }

	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	public static void Copy(T[] src, NativeArray<T> dst) { }

	public static void Copy(NativeArray<T> src, NativeArray<T> dst) { }

	[WriteAccessRequired]
	public void CopyFrom(NativeArray<T> array) { }

	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[WriteAccessRequired]
	public override void Dispose() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NativeArray<T> other) { }

	public bool get_IsCreated() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

}

