namespace XPostProcessing;

[PostProcess(typeof(PixelizeDiamondRenderer), PostProcessEvent::BeforeStack (1), "X-PostProcessing/Pixelize/PixelizeDiamond", True)]
public class PixelizeDiamond : PostProcessEffectSettings
{
	[Range(0.01, 1)]
	public FloatParameter pixelSize; //Field offset: 0x18

	public PixelizeDiamond() { }

}

