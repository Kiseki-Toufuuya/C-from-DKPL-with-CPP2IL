namespace D4L.TakashoFes.DataContext;

public sealed class WavAccessor : FlatBuffersAccessorBase<Wav, WavEntry, GuardInt>, IWavAccessor, IFlatBuffersAccessor<Wav, WavEntry, GuardInt>, IDaoAccessor<Wav, WavEntry, GuardInt>
{

	public WavAccessor() { }

	protected virtual Wav Parse(Byte[] source) { }

}

