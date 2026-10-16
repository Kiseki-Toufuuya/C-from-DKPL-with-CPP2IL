namespace System.Data;

internal sealed class XmlDataLoader
{
	private DataSet _dataSet; //Field offset: 0x8
	private XmlToDatasetMap _nodeToSchemaMap; //Field offset: 0xC
	private Hashtable _nodeToRowMap; //Field offset: 0x10
	private Stack _childRowsStack; //Field offset: 0x14
	private Hashtable _htableExcludedNS; //Field offset: 0x18
	private bool _fIsXdr; //Field offset: 0x1C
	internal bool _isDiffgram; //Field offset: 0x1D
	private XmlElement _topMostNode; //Field offset: 0x20
	private bool _ignoreSchema; //Field offset: 0x24
	private DataTable _dataTable; //Field offset: 0x28
	private bool _isTableLevel; //Field offset: 0x2C
	private bool _fromInference; //Field offset: 0x2D
	private XmlReader _dataReader; //Field offset: 0x30
	private object _XSD_XMLNS_NS; //Field offset: 0x34
	private object _XDR_SCHEMA; //Field offset: 0x38
	private object _XDRNS; //Field offset: 0x3C
	private object _SQL_SYNC; //Field offset: 0x40
	private object _UPDGNS; //Field offset: 0x44
	private object _XSD_SCHEMA; //Field offset: 0x48
	private object _XSDNS; //Field offset: 0x4C
	private object _DFFNS; //Field offset: 0x50
	private object _MSDNS; //Field offset: 0x54
	private object _DIFFID; //Field offset: 0x58
	private object _HASCHANGES; //Field offset: 0x5C
	private object _ROWORDER; //Field offset: 0x60

	internal bool FromInference
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	internal XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	internal XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	internal XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	private int CountNonNSAttributes(XmlNode node) { }

	internal bool FColumnElement(XmlElement e) { }

	private bool FExcludedNamespace(string ns) { }

	private bool FIgnoreNamespace(XmlNode node) { }

	private bool FIgnoreNamespace(XmlReader node) { }

	internal bool get_FromInference() { }

	private string GetInitialTextFromNodes(ref XmlNode n) { }

	internal DataRow GetRowFromElement(XmlElement e) { }

	private DataColumn GetTextOnlyColumn(DataRow row) { }

	private string GetValueForTextOnlyColums(XmlNode n) { }

	private void InitNameTable() { }

	internal bool IsTextLikeNode(XmlNodeType n) { }

	internal bool IsTextOnly(DataColumn c) { }

	private void LoadColumn(DataColumn column, Object[] foundColumns) { }

	internal void LoadData(XmlDocument xdoc) { }

	internal void LoadData(XmlReader reader) { }

	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	private void LoadTable(DataTable table, bool isNested) { }

	private void LoadTopMostTable(DataTable table) { }

	private bool ProcessXsdSchema() { }

	internal void set_FromInference(bool value) { }

	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

}

