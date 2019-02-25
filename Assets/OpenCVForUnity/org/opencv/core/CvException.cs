using System;

namespace OpenCVForUnity{

	/// <summary>
	/// The exception that is thrown by OpenCVForUntiy. 
	/// </summary>
	public class CvException : ApplicationException
	{
		/// <summary>
		/// 
		/// </summary>
		public CvException()
			: base()
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public CvException(string message)
			: base(message)
		{ }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="messageFormat"></param>
		/// <param name="args"></param>
		public CvException(string messageFormat, params object[] args)
			: base(string.Format(messageFormat, args))
		{ }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public CvException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
