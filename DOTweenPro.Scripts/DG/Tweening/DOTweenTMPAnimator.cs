namespace DG.Tweening;

public class DOTweenTMPAnimator : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass34_0() { }

		internal Color <DOFadeChar>b__0() { }

		internal void <DOFadeChar>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass35_0() { }

		internal Color <DOColorChar>b__0() { }

		internal void <DOColorChar>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass36_0() { }

		internal Vector3 <DOOffsetChar>b__0() { }

		internal void <DOOffsetChar>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass37_0() { }

		internal Quaternion <DORotateChar>b__0() { }

		internal void <DORotateChar>b__1(Quaternion x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass39_0() { }

		internal Vector3 <DOScaleChar>b__0() { }

		internal void <DOScaleChar>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass40_0() { }

		internal Vector3 <DOPunchCharOffset>b__0() { }

		internal void <DOPunchCharOffset>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass41_0() { }

		internal Vector3 <DOPunchCharRotation>b__0() { }

		internal void <DOPunchCharRotation>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass43_0() { }

		internal Vector3 <DOPunchCharScale>b__0() { }

		internal void <DOPunchCharScale>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass45_0() { }

		internal Vector3 <DOShakeCharOffset>b__0() { }

		internal void <DOShakeCharOffset>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass46_0() { }

		internal Vector3 <DOShakeCharRotation>b__0() { }

		internal void <DOShakeCharRotation>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public DOTweenTMPAnimator <>4__this; //Field offset: 0x8
		public int charIndex; //Field offset: 0xC

		public <>c__DisplayClass48_0() { }

		internal Vector3 <DOShakeCharScale>b__0() { }

		internal void <DOShakeCharScale>b__1(Vector3 x) { }

	}

	private struct CharTransform
	{
		public int charIndex; //Field offset: 0x0
		[CompilerGenerated]
		private bool <isVisible>k__BackingField; //Field offset: 0x4
		public Vector3 offset; //Field offset: 0x8
		public Quaternion rotation; //Field offset: 0x14
		public Vector3 scale; //Field offset: 0x24
		private Vector3 _topLeftShift; //Field offset: 0x30
		private Vector3 _topRightShift; //Field offset: 0x3C
		private Vector3 _bottomLeftShift; //Field offset: 0x48
		private Vector3 _bottomRightShift; //Field offset: 0x54
		private Vector3 _charMidBaselineOffset; //Field offset: 0x60
		private int _matIndex; //Field offset: 0x6C
		private int _firstVertexIndex; //Field offset: 0x70
		private TMP_MeshInfo _meshInfo; //Field offset: 0x74

		public private bool isVisible
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 14
		}

		public CharTransform(int charIndex, TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos) { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_isVisible() { }

		public Color32 GetColor(TMP_MeshInfo[] meshInfos) { }

		public CharVertices GetVertices() { }

		public void Refresh(TMP_TextInfo textInfo, TMP_MeshInfo[] cachedMeshInfos) { }

		public void ResetAll(TMP_Text target, TMP_MeshInfo[] meshInfos, TMP_MeshInfo[] cachedMeshInfos) { }

		public void ResetColors(TMP_Text target, TMP_MeshInfo[] meshInfos) { }

		public void ResetGeometry(TMP_Text target, TMP_MeshInfo[] cachedMeshInfos) { }

		public void ResetTransformationData() { }

		public void ResetVerticesShift(TMP_Text target) { }

		[CompilerGenerated]
		private void set_isVisible(bool value) { }

		public void ShiftVertices(TMP_Text target, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift) { }

		public void UpdateAlpha(TMP_Text target, Color alphaColor, TMP_MeshInfo[] meshInfos, bool apply = true) { }

		public void UpdateColor(TMP_Text target, Color32 color, TMP_MeshInfo[] meshInfos, bool apply = true) { }

		public void UpdateGeometry(TMP_Text target, Vector3 offset, Quaternion rotation, Vector3 scale, TMP_MeshInfo[] cachedMeshInfos, bool apply = true) { }

	}

	private struct CharVertices
	{
		public Vector3 bottomLeft; //Field offset: 0x0
		public Vector3 topLeft; //Field offset: 0xC
		public Vector3 topRight; //Field offset: 0x18
		public Vector3 bottomRight; //Field offset: 0x24

		public CharVertices(Vector3 bottomLeft, Vector3 topLeft, Vector3 topRight, Vector3 bottomRight) { }

	}

	private static readonly Dictionary<TMP_Text, DOTweenTMPAnimator> _targetToAnimator; //Field offset: 0x0
	[CompilerGenerated]
	private TMP_Text <target>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private TMP_TextInfo <textInfo>k__BackingField; //Field offset: 0xC
	private readonly List<CharTransform> _charTransforms; //Field offset: 0x10
	private TMP_MeshInfo[] _cachedMeshInfos; //Field offset: 0x14
	private bool _ignoreTextChangedEvent; //Field offset: 0x18

	public private TMP_Text target
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private TMP_TextInfo textInfo
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private static DOTweenTMPAnimator() { }

	public DOTweenTMPAnimator(TMP_Text target) { }

	public override void Dispose() { }

	public static void DisposeInstanceFor(TMP_Text target) { }

	public TweenerCore<Color, Color, ColorOptions> DOColorChar(int charIndex, Color endValue, float duration) { }

	public TweenerCore<Color, Color, ColorOptions> DOFadeChar(int charIndex, float endValue, float duration) { }

	public TweenerCore<Vector3, Vector3, VectorOptions> DOOffsetChar(int charIndex, Vector3 endValue, float duration) { }

	public Tweener DOPunchCharOffset(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1) { }

	public Tweener DOPunchCharRotation(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1) { }

	public Tweener DOPunchCharScale(int charIndex, float punch, float duration, int vibrato = 10, float elasticity = 1) { }

	public Tweener DOPunchCharScale(int charIndex, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1) { }

	public TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateChar(int charIndex, Vector3 endValue, float duration, RotateMode mode = 0) { }

	public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, Vector3 endValue, float duration) { }

	public TweenerCore<Vector3, Vector3, VectorOptions> DOScaleChar(int charIndex, float endValue, float duration) { }

	public Tweener DOShakeCharOffset(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	public Tweener DOShakeCharOffset(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	public Tweener DOShakeCharRotation(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	public Tweener DOShakeCharScale(int charIndex, float duration, float strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	public Tweener DOShakeCharScale(int charIndex, float duration, Vector3 strength, int vibrato = 10, float randomness = 90, bool fadeOut = true) { }

	[CompilerGenerated]
	public TMP_Text get_target() { }

	[CompilerGenerated]
	public TMP_TextInfo get_textInfo() { }

	public Color GetCharColor(int charIndex) { }

	public Vector3 GetCharOffset(int charIndex) { }

	public Vector3 GetCharRotation(int charIndex) { }

	public Vector3 GetCharScale(int charIndex) { }

	private void OnTextChanged(object obj) { }

	public void Refresh() { }

	public void Reset() { }

	public void ResetVerticesShift(int charIndex) { }

	[CompilerGenerated]
	private void set_target(TMP_Text value) { }

	[CompilerGenerated]
	private void set_textInfo(TMP_TextInfo value) { }

	public void SetCharColor(int charIndex, Color32 color) { }

	public void SetCharOffset(int charIndex, Vector3 offset) { }

	public void SetCharRotation(int charIndex, Vector3 rotation) { }

	public void SetCharScale(int charIndex, Vector3 scale) { }

	public void ShiftCharVertices(int charIndex, Vector3 topLeftShift, Vector3 topRightShift, Vector3 bottomLeftShift, Vector3 bottomRightShift) { }

	public float SkewCharX(int charIndex, float skewFactor, bool skewTop = true) { }

	public float SkewCharY(int charIndex, float skewFactor, bool skewRight = true, bool fixedSkew = false) { }

	public void SkewSpanX(int fromCharIndex, int toCharIndex, float skewFactor, bool skewTop = true) { }

	public void SkewSpanY(int fromCharIndex, int toCharIndex, float skewFactor, TMPSkewSpanMode mode = 0, bool skewRight = true) { }

	private bool ValidateChar(int charIndex, bool isTween = true) { }

	private bool ValidateSpan(int fromCharIndex, int toCharIndex, out int firstVisibleCharIndex, out int lastVisibleCharIndex) { }

}

