namespace Heqet.Kagura;

public class GrooveGaugeDisp : DispBase
{
	private const string ROLL = "roll"; //Field offset: 0x0
	private const string CELLS = "cells"; //Field offset: 0x0
	private const string BIG_CELLS = "big_cells"; //Field offset: 0x0
	private const string FRAME = "frame"; //Field offset: 0x0
	private const int CELL_MAX_NUM = 40; //Field offset: 0x0
	private const int BIG_CELL_MAX_NUM = 10; //Field offset: 0x0
	private const int ALL_CELL_MAX_NUM = 50; //Field offset: 0x0
	private const float ROLL_ROTATION_SPEED = 0.5; //Field offset: 0x0
	private KaguraLayer m_KaguraLayer; //Field offset: 0x114
	private RectTransform m_Roll; //Field offset: 0x118
	private Material m_Frame; //Field offset: 0x11C
	private Material m_ImageMaterial; //Field offset: 0x120
	private float m_CurrPercent; //Field offset: 0x124
	private int m_CurrIndex; //Field offset: 0x128
	private int m_Timer; //Field offset: 0x12C
	private List<GrooveGaugeCell> m_Cells; //Field offset: 0x130
	private List<GrooveGaugeCell> m_BigCells; //Field offset: 0x134
	private List<GrooveGaugeCell> m_AllCells; //Field offset: 0x138

	public GrooveGaugeDisp() { }

	[CompilerGenerated]
	private void <InitLayout>b__19_0(AssetBundleLoadAssetOperation ope) { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	public void SetGaugePercent(float percent) { }

	protected virtual void UpdateDispMain() { }

}

