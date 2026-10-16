namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Humidity")]
public class HumiditySensor : Sensor
{
	[CompilerGenerated]
	private static HumiditySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AxisControl <relativeHumidity>k__BackingField; //Field offset: 0x110

	public private static HumiditySensor current
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	[InputControl(displayName = "Relative Humidity", noisy = True)]
	public AxisControl relativeHumidity
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public HumiditySensor() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public static HumiditySensor get_current() { }

	[CompilerGenerated]
	public AxisControl get_relativeHumidity() { }

	public virtual void MakeCurrent() { }

	protected virtual void OnRemoved() { }

	[CompilerGenerated]
	private static void set_current(HumiditySensor value) { }

	[CompilerGenerated]
	protected void set_relativeHumidity(AxisControl value) { }

}

