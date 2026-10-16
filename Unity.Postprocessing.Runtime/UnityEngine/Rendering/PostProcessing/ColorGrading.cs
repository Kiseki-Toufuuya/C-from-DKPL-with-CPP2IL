namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(ColorGradingRenderer), "Unity/Color Grading", True)]
public sealed class ColorGrading : PostProcessEffectSettings
{
	[DisplayName("Mode")]
	[Tooltip("Select a color grading mode that fits your dynamic range and workflow. Use HDR if your camera is set to render in HDR and your target platform supports it. Use LDR for low-end mobiles or devices that don't support HDR. Use External if you prefer authoring a Log LUT in an external software.")]
	public GradingModeParameter gradingMode; //Field offset: 0x18
	[DisplayName("Lookup Texture")]
	[Tooltip("A custom 3D log-encoded texture.")]
	public TextureParameter externalLut; //Field offset: 0x1C
	[DisplayName("Mode")]
	[Tooltip("Select a tonemapping algorithm to use at the end of the color grading process.")]
	public TonemapperParameter tonemapper; //Field offset: 0x20
	[DisplayName("Toe Strength")]
	[Range(0, 1)]
	[Tooltip("Affects the transition between the toe and the mid section of the curve. A value of 0 means no toe, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveToeStrength; //Field offset: 0x24
	[DisplayName("Toe Length")]
	[Range(0, 1)]
	[Tooltip("Affects how much of the dynamic range is in the toe. With a small value, the toe will be very short and quickly transition into the linear section, with a larger value, the toe will be longer.")]
	public FloatParameter toneCurveToeLength; //Field offset: 0x28
	[DisplayName("Shoulder Strength")]
	[Range(0, 1)]
	[Tooltip("Affects the transition between the mid section and the shoulder of the curve. A value of 0 means no shoulder, a value of 1 means a very hard transition.")]
	public FloatParameter toneCurveShoulderStrength; //Field offset: 0x2C
	[DisplayName("Shoulder Length")]
	[Min(0)]
	[Tooltip("Affects how many F-stops (EV) to add to the dynamic range of the curve.")]
	public FloatParameter toneCurveShoulderLength; //Field offset: 0x30
	[DisplayName("Shoulder Angle")]
	[Range(0, 1)]
	[Tooltip("Affects how much overshoot to add to the shoulder.")]
	public FloatParameter toneCurveShoulderAngle; //Field offset: 0x34
	[DisplayName("Gamma")]
	[Min(0.001)]
	[Tooltip("Applies a gamma function to the curve.")]
	public FloatParameter toneCurveGamma; //Field offset: 0x38
	[DisplayName("Lookup Texture")]
	[Tooltip("Custom lookup texture (strip format, for example 256x16) to apply before the rest of the color grading operators. If none is provided, a neutral one will be generated internally.")]
	public TextureParameter ldrLut; //Field offset: 0x3C
	[DisplayName("Contribution")]
	[Range(0, 1)]
	[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
	public FloatParameter ldrLutContribution; //Field offset: 0x40
	[DisplayName("Temperature")]
	[Range(-100, 100)]
	[Tooltip("Sets the white balance to a custom color temperature.")]
	public FloatParameter temperature; //Field offset: 0x44
	[DisplayName("Tint")]
	[Range(-100, 100)]
	[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
	public FloatParameter tint; //Field offset: 0x48
	[ColorUsage(False, True)]
	[DisplayName("Color Filter")]
	[Tooltip("Tint the render by multiplying a color.")]
	public ColorParameter colorFilter; //Field offset: 0x4C
	[DisplayName("Hue Shift")]
	[Range(-180, 180)]
	[Tooltip("Shift the hue of all colors.")]
	public FloatParameter hueShift; //Field offset: 0x50
	[DisplayName("Saturation")]
	[Range(-100, 100)]
	[Tooltip("Pushes the intensity of all colors.")]
	public FloatParameter saturation; //Field offset: 0x54
	[DisplayName("Brightness")]
	[Range(-100, 100)]
	[Tooltip("Makes the image brighter or darker.")]
	public FloatParameter brightness; //Field offset: 0x58
	[DisplayName("Post-exposure (EV)")]
	[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after the HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
	public FloatParameter postExposure; //Field offset: 0x5C
	[DisplayName("Contrast")]
	[Range(-100, 100)]
	[Tooltip("Expands or shrinks the overall range of tonal values.")]
	public FloatParameter contrast; //Field offset: 0x60
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerRedOutRedIn; //Field offset: 0x64
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerRedOutGreenIn; //Field offset: 0x68
	[DisplayName("Blue")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerRedOutBlueIn; //Field offset: 0x6C
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerGreenOutRedIn; //Field offset: 0x70
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerGreenOutGreenIn; //Field offset: 0x74
	[DisplayName("Blue")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerGreenOutBlueIn; //Field offset: 0x78
	[DisplayName("Red")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the red channel in the overall mix.")]
	public FloatParameter mixerBlueOutRedIn; //Field offset: 0x7C
	[DisplayName("Green")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the green channel in the overall mix.")]
	public FloatParameter mixerBlueOutGreenIn; //Field offset: 0x80
	[DisplayName("Blue")]
	[Range(-200, 200)]
	[Tooltip("Modify influence of the blue channel in the overall mix.")]
	public FloatParameter mixerBlueOutBlueIn; //Field offset: 0x84
	[DisplayName("Lift")]
	[Tooltip("Controls the darkest portions of the render.")]
	[Trackball(Mode::Lift (1))]
	public Vector4Parameter lift; //Field offset: 0x88
	[DisplayName("Gamma")]
	[Tooltip("Power function that controls mid-range tones.")]
	[Trackball(Mode::Gamma (2))]
	public Vector4Parameter gamma; //Field offset: 0x8C
	[DisplayName("Gain")]
	[Tooltip("Controls the lightest portions of the render.")]
	[Trackball(Mode::Gain (3))]
	public Vector4Parameter gain; //Field offset: 0x90
	public SplineParameter masterCurve; //Field offset: 0x94
	public SplineParameter redCurve; //Field offset: 0x98
	public SplineParameter greenCurve; //Field offset: 0x9C
	public SplineParameter blueCurve; //Field offset: 0xA0
	public SplineParameter hueVsHueCurve; //Field offset: 0xA4
	public SplineParameter hueVsSatCurve; //Field offset: 0xA8
	public SplineParameter satVsSatCurve; //Field offset: 0xAC
	public SplineParameter lumVsSatCurve; //Field offset: 0xB0

	public ColorGrading() { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

