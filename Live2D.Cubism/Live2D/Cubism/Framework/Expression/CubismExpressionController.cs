namespace Live2D.Cubism.Framework.Expression;

public class CubismExpressionController : MonoBehaviour, ICubismUpdatable
{
	private const float DefaultAdditiveValue = 0; //Field offset: 0x0
	private const float DefaultMultiplyValue = 1; //Field offset: 0x0
	[SerializeField]
	public CubismExpressionList ExpressionsList; //Field offset: 0x10
	[SerializeField]
	public bool UseLegacyBlendCalculation; //Field offset: 0x14
	private CubismModel _model; //Field offset: 0x18
	private List<CubismPlayingExpression> _playingExpressions; //Field offset: 0x1C
	[SerializeField]
	public int CurrentExpressionIndex; //Field offset: 0x20
	private int _lastExpressionIndex; //Field offset: 0x24
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x28
	private List<CubismExpressionParameterValue> _expressionParameterValues; //Field offset: 0x2C

	public override int ExecutionOrder
	{
		 get { } //Length: 61
	}

	[HideInInspector]
	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	public CubismExpressionController() { }

	private void CalculateExpressionParameters(int expressionIndex, CubismPlayingExpression playingExpression) { }

	private float CalculateValue(float source, float destination, float fadeWeight) { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public override void OnLateUpdate() { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	private void StartExpression() { }

	private void UpdateExpression() { }

	private void UpdateExpressionLegacy() { }

	private void UpdateFadeWeight(CubismPlayingExpression playingExpression) { }

}

