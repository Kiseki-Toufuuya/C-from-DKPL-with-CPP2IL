namespace Live2D.Cubism.Rendering;

[ExecuteInEditMode]
[RequireComponent(typeof(CubismPart))]
public class CubismPartColorsEditor : MonoBehaviour
{
	private CubismRenderController _renderController; //Field offset: 0x10
	private CubismRenderer[] _renderers; //Field offset: 0x14
	private CubismPart _part; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private CubismRenderer[] _childDrawableRenderers; //Field offset: 0x1C
	[HideInInspector]
	[SerializeField]
	private CubismPartColorsEditor[] _childParts; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private bool _isOverriddenPartMultiplyColors; //Field offset: 0x24
	[HideInInspector]
	[SerializeField]
	private bool _isOverriddenPartScreenColors; //Field offset: 0x25
	[HideInInspector]
	[SerializeField]
	private Color _multiplyColor; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private Color _screenColor; //Field offset: 0x38

	public CubismRenderer[] ChildDrawableRenderers
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public CubismPartColorsEditor[] ChildParts
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Color MultiplyColor
	{
		 get { } //Length: 18
		 set { } //Length: 371
	}

	public bool OverrideColorForPartMultiplyColors
	{
		 get { } //Length: 11
		 set { } //Length: 434
	}

	public bool OverrideColorForPartScreenColors
	{
		 get { } //Length: 11
		 set { } //Length: 434
	}

	public bool OverwriteColorForPartMultiplyColors
	{
		 get { } //Length: 11
		 set { } //Length: 16
	}

	public bool OverwriteColorForPartScreenColors
	{
		 get { } //Length: 11
		 set { } //Length: 16
	}

	public Color ScreenColor
	{
		 get { } //Length: 18
		 set { } //Length: 371
	}

	public CubismPartColorsEditor() { }

	[CompilerGenerated]
	private bool <TryInitialize>b__34_0(CubismPart e) { }

	public CubismRenderer[] get_ChildDrawableRenderers() { }

	public CubismPartColorsEditor[] get_ChildParts() { }

	public Color get_MultiplyColor() { }

	public bool get_OverrideColorForPartMultiplyColors() { }

	public bool get_OverrideColorForPartScreenColors() { }

	public bool get_OverwriteColorForPartMultiplyColors() { }

	public bool get_OverwriteColorForPartScreenColors() { }

	public Color get_ScreenColor() { }

	private void OnEnable() { }

	public void set_ChildDrawableRenderers(CubismRenderer[] value) { }

	public void set_ChildParts(CubismPartColorsEditor[] value) { }

	public void set_MultiplyColor(Color value) { }

	public void set_OverrideColorForPartMultiplyColors(bool value) { }

	public void set_OverrideColorForPartScreenColors(bool value) { }

	public void set_OverwriteColorForPartMultiplyColors(bool value) { }

	public void set_OverwriteColorForPartScreenColors(bool value) { }

	public void set_ScreenColor(Color value) { }

	[Obsolete]
	public void TryInitialize(CubismRenderController cubismRenderController, CubismPart part, CubismDrawable[] drawables) { }

	public void TryInitialize(CubismModel model) { }

}

