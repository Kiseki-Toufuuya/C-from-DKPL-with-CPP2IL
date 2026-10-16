namespace XeApp.Core;

public enum SaveReturnCode
{
	Success = 0,
	PS4_Mount_Error_NotFound = 1,
	PS4_Mount_Error_Broken = 2,
	PS4_Mount_Error_OtherError = 3,
	FileMissing = 4,
	UnsupportedSaveDataVersion = 5,
	DiskFull = 6,
	UnknownError = 7,
}

