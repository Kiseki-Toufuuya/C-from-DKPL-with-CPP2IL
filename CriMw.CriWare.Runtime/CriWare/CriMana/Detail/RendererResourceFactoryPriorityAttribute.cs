namespace CriWare.CriMana.Detail;

[AttributeUsage(AttributeTargets::Class (4))]
public class RendererResourceFactoryPriorityAttribute : Attribute
{
	public readonly int priority; //Field offset: 0x8

	public RendererResourceFactoryPriorityAttribute(int priority) { }

}

