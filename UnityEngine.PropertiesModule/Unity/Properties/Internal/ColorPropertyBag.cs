namespace Unity.Properties.Internal;

internal class ColorPropertyBag : ContainerPropertyBag<Color>
{
	private class AProperty : Property<Color, Single>
	{

		public virtual bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public virtual string Name
		{
			 get { } //Length: 35
		}

		public AProperty() { }

		public virtual bool get_IsReadOnly() { }

		public virtual string get_Name() { }

		public virtual float GetValue(ref Color container) { }

		public virtual void SetValue(ref Color container, float value) { }

	}

	private class BProperty : Property<Color, Single>
	{

		public virtual bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public virtual string Name
		{
			 get { } //Length: 35
		}

		public BProperty() { }

		public virtual bool get_IsReadOnly() { }

		public virtual string get_Name() { }

		public virtual float GetValue(ref Color container) { }

		public virtual void SetValue(ref Color container, float value) { }

	}

	private class GProperty : Property<Color, Single>
	{

		public virtual bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public virtual string Name
		{
			 get { } //Length: 35
		}

		public GProperty() { }

		public virtual bool get_IsReadOnly() { }

		public virtual string get_Name() { }

		public virtual float GetValue(ref Color container) { }

		public virtual void SetValue(ref Color container, float value) { }

	}

	private class RProperty : Property<Color, Single>
	{

		public virtual bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public virtual string Name
		{
			 get { } //Length: 35
		}

		public RProperty() { }

		public virtual bool get_IsReadOnly() { }

		public virtual string get_Name() { }

		public virtual float GetValue(ref Color container) { }

		public virtual void SetValue(ref Color container, float value) { }

	}


	public ColorPropertyBag() { }

}

