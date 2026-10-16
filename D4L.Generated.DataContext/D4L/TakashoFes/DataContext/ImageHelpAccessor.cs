namespace D4L.TakashoFes.DataContext;

public sealed class ImageHelpAccessor : FlatBuffersAccessorBase<ImageHelp, ImageHelpEntry, Int64>, IImageHelpAccessor, IFlatBuffersAccessor<ImageHelp, ImageHelpEntry, Int64>, IDaoAccessor<ImageHelp, ImageHelpEntry, Int64>
{

	public ImageHelpAccessor() { }

	protected virtual ImageHelp Parse(Byte[] source) { }

}

