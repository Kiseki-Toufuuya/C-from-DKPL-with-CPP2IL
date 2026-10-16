namespace XeApp.RGameEngine;

public class RGameScoreConstantsData
{
	internal class AdvConstants
	{
		public float scale; //Field offset: 0x8
		public float xPos_0; //Field offset: 0xC
		public float xPos_1; //Field offset: 0x10
		public float xPos_2; //Field offset: 0x14
		public float xPos_3; //Field offset: 0x18
		public float xPos_4; //Field offset: 0x1C
		public float xPos_5; //Field offset: 0x20
		public float xPos_6; //Field offset: 0x24
		public float xPos_7; //Field offset: 0x28
		public float xPos_8; //Field offset: 0x2C
		public float xPos_9; //Field offset: 0x30
		public float xPos_10; //Field offset: 0x34
		public float xPos_11; //Field offset: 0x38
		public float xPos_12; //Field offset: 0x3C
		public float xPos_20; //Field offset: 0x40
		public float xPos_21; //Field offset: 0x44
		public float xPos_22; //Field offset: 0x48
		public float xPos_23; //Field offset: 0x4C
		public float xPos_24; //Field offset: 0x50
		public float xPos_25; //Field offset: 0x54
		public float xPos_26; //Field offset: 0x58
		public float xPos_27; //Field offset: 0x5C
		public float xPos_28; //Field offset: 0x60
		public float yPos; //Field offset: 0x64
		public float yPos_2; //Field offset: 0x68
		public float yPos_3; //Field offset: 0x6C

		public AdvConstants() { }

	}

	internal class NotesScore
	{
		public float baseScore; //Field offset: 0x8
		public Single[] judgeCoefficient; //Field offset: 0xC
		public float comboCoefficient; //Field offset: 0x10
		public int addComboCoefficeientValue; //Field offset: 0x14

		public NotesScore() { }

	}

	internal class RythmGameConstants
	{
		public int maxRange; //Field offset: 0x8
		public int minRange; //Field offset: 0xC
		public float hitRectWidth; //Field offset: 0x10
		public float hitRectTop; //Field offset: 0x14
		public float hitRectBottom; //Field offset: 0x18
		public float hitRectWidth_wid; //Field offset: 0x1C
		public float hitRectTop_wid; //Field offset: 0x20
		public float hitRectBottom_wid; //Field offset: 0x24
		public float damageBase; //Field offset: 0x28
		public float attackPower; //Field offset: 0x2C
		public float attackBaseNum; //Field offset: 0x30
		public int comboSeparate; //Field offset: 0x34
		public float activeSkillCoefficientValue; //Field offset: 0x38
		public float activeSkillBrillantValue; //Field offset: 0x3C
		public float activeSkillGreatValue; //Field offset: 0x40
		public int PowerMax; //Field offset: 0x44
		public float PowerCoef; //Field offset: 0x48
		public float BossDamageAdjustRate; //Field offset: 0x4C
		public float BossPowerAdjustRate; //Field offset: 0x50

		public RythmGameConstants() { }

	}


	public RGameScoreConstantsData() { }

}

