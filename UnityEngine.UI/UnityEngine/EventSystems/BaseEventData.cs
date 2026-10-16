namespace UnityEngine.EventSystems;

public class BaseEventData : AbstractEventData
{
	private readonly EventSystem m_EventSystem; //Field offset: 0xC

	public BaseInputModule currentInputModule
	{
		 get { } //Length: 23
	}

	public GameObject selectedObject
	{
		 get { } //Length: 23
		 set { } //Length: 35
	}

	public BaseEventData(EventSystem eventSystem) { }

	public BaseInputModule get_currentInputModule() { }

	public GameObject get_selectedObject() { }

	public void set_selectedObject(GameObject value) { }

}

