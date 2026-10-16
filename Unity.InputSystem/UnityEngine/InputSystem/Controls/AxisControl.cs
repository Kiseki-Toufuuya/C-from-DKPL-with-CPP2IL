namespace UnityEngine.InputSystem.Controls;

public class AxisControl : InputControl<Single>
{
	internal enum Clamp
	{
		None = 0,
		BeforeNormalize = 1,
		AfterNormalize = 2,
		ToConstantBeforeNormalize = 3,
	}

	public Clamp clamp; //Field offset: 0xC0
	public float clampMin; //Field offset: 0xC4
	public float clampMax; //Field offset: 0xC8
	public float clampConstant; //Field offset: 0xCC
	public bool invert; //Field offset: 0xD0
	public bool normalize; //Field offset: 0xD1
	public float normalizeMin; //Field offset: 0xD4
	public float normalizeMax; //Field offset: 0xD8
	public float normalizeZero; //Field offset: 0xDC
	public bool scale; //Field offset: 0xE0
	public float scaleFactor; //Field offset: 0xE4

	public AxisControl() { }

	protected virtual FourCC CalculateOptimizedControlDataType() { }

	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	public virtual float EvaluateMagnitude(Void* statePtr) { }

	private float EvaluateMagnitude(float value) { }

	protected virtual void FinishSetup() { }

	protected float Preprocess(float value) { }

	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	private float Unpreprocess(float value) { }

	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}

