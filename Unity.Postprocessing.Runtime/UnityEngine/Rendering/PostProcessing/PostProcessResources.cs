namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessResources : ScriptableObject
{
	internal sealed class ComputeShaders
	{
		public ComputeShader autoExposure; //Field offset: 0x8
		public ComputeShader exposureHistogram; //Field offset: 0xC
		public ComputeShader lut3DBaker; //Field offset: 0x10
		public ComputeShader texture3dLerp; //Field offset: 0x14
		public ComputeShader gammaHistogram; //Field offset: 0x18
		public ComputeShader waveform; //Field offset: 0x1C
		public ComputeShader vectorscope; //Field offset: 0x20
		public ComputeShader multiScaleAODownsample1; //Field offset: 0x24
		public ComputeShader multiScaleAODownsample2; //Field offset: 0x28
		public ComputeShader multiScaleAORender; //Field offset: 0x2C
		public ComputeShader multiScaleAOUpsample; //Field offset: 0x30
		public ComputeShader gaussianDownsample; //Field offset: 0x34

		public ComputeShaders() { }

		public ComputeShaders Clone() { }

	}

	internal sealed class Shaders
	{
		public Shader bloom; //Field offset: 0x8
		public Shader copy; //Field offset: 0xC
		public Shader copyStd; //Field offset: 0x10
		public Shader copyStdFromTexArray; //Field offset: 0x14
		public Shader copyStdFromDoubleWide; //Field offset: 0x18
		public Shader discardAlpha; //Field offset: 0x1C
		public Shader depthOfField; //Field offset: 0x20
		public Shader finalPass; //Field offset: 0x24
		public Shader grainBaker; //Field offset: 0x28
		public Shader motionBlur; //Field offset: 0x2C
		public Shader temporalAntialiasing; //Field offset: 0x30
		public Shader subpixelMorphologicalAntialiasing; //Field offset: 0x34
		public Shader texture2dLerp; //Field offset: 0x38
		public Shader uber; //Field offset: 0x3C
		public Shader lut2DBaker; //Field offset: 0x40
		public Shader lightMeter; //Field offset: 0x44
		public Shader gammaHistogram; //Field offset: 0x48
		public Shader waveform; //Field offset: 0x4C
		public Shader vectorscope; //Field offset: 0x50
		public Shader debugOverlays; //Field offset: 0x54
		public Shader deferredFog; //Field offset: 0x58
		public Shader scalableAO; //Field offset: 0x5C
		public Shader multiScaleAO; //Field offset: 0x60
		public Shader screenSpaceReflections; //Field offset: 0x64

		public Shaders() { }

		public Shaders Clone() { }

	}

	internal sealed class SMAALuts
	{
		public Texture2D area; //Field offset: 0x8
		public Texture2D search; //Field offset: 0xC

		public SMAALuts() { }

	}

	public Texture2D[] blueNoise64; //Field offset: 0xC
	public Texture2D[] blueNoise256; //Field offset: 0x10
	public SMAALuts smaaLuts; //Field offset: 0x14
	public Shaders shaders; //Field offset: 0x18
	public ComputeShaders computeShaders; //Field offset: 0x1C

	public PostProcessResources() { }

}

