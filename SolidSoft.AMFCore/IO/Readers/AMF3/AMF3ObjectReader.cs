﻿namespace SolidSoft.AMFCore.IO.Readers
{
	/// <summary>
	/// This type supports the AMFCore infrastructure and is not intended to be used directly from your code.
	/// </summary>
	class AMF3ObjectReader : IAMFReader
	{
		public AMF3ObjectReader()
		{
		}

		#region IAMFReader Members

		public object ReadData(AMFReader reader)
		{
            return reader.ReadAMF3Object();
		}

		#endregion
	}
}