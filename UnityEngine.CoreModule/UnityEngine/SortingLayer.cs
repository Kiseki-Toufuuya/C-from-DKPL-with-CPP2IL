namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct SortingLayer
{
	private int m_Id; //Field offset: 0x0

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	public static int GetLayerValueFromID(int id) { }

	[FreeFunction("GetTagManager().GetSortingLayerNameFromUniqueID")]
	public static string IDToName(int id) { }

	private static void IDToName_Injected(int id, out ManagedSpanWrapper ret) { }

	[FreeFunction("GetTagManager().GetSortingLayerUniqueIDFromName")]
	public static int NameToID(string name) { }

	private static int NameToID_Injected(ref ManagedSpanWrapper name) { }

}

