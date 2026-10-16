namespace D4L.TakashoFes.DataContext;

public sealed class ErrorMessageAccessor : FlatBuffersAccessorBase<ErrorMessage, ErrorMessageEntry, Int32>, IErrorMessageAccessor, IFlatBuffersAccessor<ErrorMessage, ErrorMessageEntry, Int32>, IDaoAccessor<ErrorMessage, ErrorMessageEntry, Int32>
{

	public ErrorMessageAccessor() { }

	public override void BuildAllIndex() { }

	protected virtual ErrorMessage Parse(Byte[] source) { }

}

