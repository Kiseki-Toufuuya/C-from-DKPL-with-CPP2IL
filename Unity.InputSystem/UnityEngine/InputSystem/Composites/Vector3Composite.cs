namespace UnityEngine.InputSystem.Composites;

[DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
public class Vector3Composite : InputBindingComposite<Vector3>
{
	internal enum Mode
	{
		Analog = 0,
		DigitalNormalized = 1,
		Digital = 2,
	}

	[InputControl(layout = "Axis")]
	public int up; //Field offset: 0x8
	[InputControl(layout = "Axis")]
	public int down; //Field offset: 0xC
	[InputControl(layout = "Axis")]
	public int left; //Field offset: 0x10
	[InputControl(layout = "Axis")]
	public int right; //Field offset: 0x14
	[InputControl(layout = "Axis")]
	public int forward; //Field offset: 0x18
	[InputControl(layout = "Axis")]
	public int backward; //Field offset: 0x1C
	public Mode mode; //Field offset: 0x20

	public Vector3Composite() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	public virtual Vector3 ReadValue(ref InputBindingCompositeContext context) { }

}

