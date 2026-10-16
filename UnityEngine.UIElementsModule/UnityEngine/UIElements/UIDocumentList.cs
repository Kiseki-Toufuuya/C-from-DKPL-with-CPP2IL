namespace UnityEngine.UIElements;

internal class UIDocumentList
{
	internal List<UIDocument> m_AttachedUIDocuments; //Field offset: 0x8

	public UIDocumentList() { }

	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0) { }

	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) { }

}

