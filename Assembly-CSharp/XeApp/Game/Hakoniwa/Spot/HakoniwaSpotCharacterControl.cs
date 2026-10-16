namespace XeApp.Game.Hakoniwa.Spot;

public class HakoniwaSpotCharacterControl
{
	internal class Emotion
	{
		public EffectObjectBase eff; //Field offset: 0x8
		public int seID; //Field offset: 0xC
		private ParticleSystem[] particles; //Field offset: 0x10
		private ParticleSystemRenderer[] particleSystemRenderers; //Field offset: 0x14
		private SpriteRenderer[] renderers; //Field offset: 0x18
		private float dissolve; //Field offset: 0x1C
		private bool dissolveUpdated; //Field offset: 0x20

		public Emotion() { }

		public void Init(int id) { }

		public void Release() { }

		public void SetDissolve(float value) { }

		public void SetLayer(int layer) { }

		private void SetMaterialDissolve() { }

		public void SetOrder(int order) { }

		public void SetSortingLayer(string layer) { }

		public void Update() { }

	}


	public HakoniwaSpotCharacterControl() { }

}

