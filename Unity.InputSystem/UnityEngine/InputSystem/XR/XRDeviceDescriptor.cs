namespace UnityEngine.InputSystem.XR;

public class XRDeviceDescriptor
{
	public string deviceName; //Field offset: 0x8
	public string manufacturer; //Field offset: 0xC
	public string serialNumber; //Field offset: 0x10
	public InputDeviceCharacteristics characteristics; //Field offset: 0x14
	public int deviceId; //Field offset: 0x18
	public List<XRFeatureDescriptor> inputFeatures; //Field offset: 0x1C

	public XRDeviceDescriptor() { }

	public static XRDeviceDescriptor FromJson(string json) { }

	public string ToJson() { }

}

