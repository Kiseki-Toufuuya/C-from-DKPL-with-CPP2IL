namespace UnityEngine.Scripting.APIUpdating;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct MovedFromAttributeData
{
	public string className; //Field offset: 0x0
	public string nameSpace; //Field offset: 0x4
	public string assembly; //Field offset: 0x8
	public bool classHasChanged; //Field offset: 0xC
	public bool nameSpaceHasChanged; //Field offset: 0xD
	public bool assemblyHasChanged; //Field offset: 0xE
	public bool autoUdpateAPI; //Field offset: 0xF

	public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

}

