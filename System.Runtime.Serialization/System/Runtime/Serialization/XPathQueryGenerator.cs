namespace System.Runtime.Serialization;

public static class XPathQueryGenerator
{
	[CompilerGenerated]
	private sealed class <GetDataMembers>d__6 : IEnumerable<DataMember>, IEnumerable, IEnumerator<DataMember>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x8
		private DataMember <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private ClassDataContract contract; //Field offset: 0x14
		public ClassDataContract <>3__contract; //Field offset: 0x18
		private IEnumerator<DataMember> <>7__wrap1; //Field offset: 0x1C
		private Enumerator<DataMember> <>7__wrap2; //Field offset: 0x20

		private override DataMember System.Collections.Generic.IEnumerator<System.Runtime.Serialization.DataMember>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <GetDataMembers>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<DataMember> System.Collections.Generic.IEnumerable<System.Runtime.Serialization.DataMember>.GetEnumerator() { }

		[DebuggerHidden]
		private override DataMember System.Collections.Generic.IEnumerator<System.Runtime.Serialization.DataMember>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class ExportContext
	{
		private XmlNamespaceManager namespaces; //Field offset: 0x8
		private int nextPrefix; //Field offset: 0xC
		private StringBuilder xPathBuilder; //Field offset: 0x10

		public XmlNamespaceManager Namespaces
		{
			 get { } //Length: 11
		}

		public string XPath
		{
			 get { } //Length: 40
		}

		public ExportContext(DataContract rootContract) { }

		public ExportContext(StringBuilder rootContractXPath) { }

		public XmlNamespaceManager get_Namespaces() { }

		public string get_XPath() { }

		public string SetNamespace(string ns) { }

		public void WriteChildToContext(DataMember contextMember, string prefix) { }

	}

	private const string XPathSeparator = "/"; //Field offset: 0x0
	private const string NsSeparator = ":"; //Field offset: 0x0

	public static string CreateFromDataContractSerializer(Type type, MemberInfo[] pathToMember, out XmlNamespaceManager namespaces) { }

	public static string CreateFromDataContractSerializer(Type type, MemberInfo[] pathToMember, StringBuilder rootElementXpath, out XmlNamespaceManager namespaces) { }

	[IteratorStateMachine(typeof(<GetDataMembers>d__6))]
	private static IEnumerable<DataMember> GetDataMembers(ClassDataContract contract) { }

	private static DataContract ProcessClassDataContract(ClassDataContract contract, ExportContext context, MemberInfo memberNode) { }

	private static DataContract ProcessDataContract(DataContract contract, ExportContext context, MemberInfo memberNode) { }

}

