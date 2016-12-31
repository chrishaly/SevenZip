#if NETCORE

// ReSharper disable once CheckNamespace
namespace System
{
	public class ApplicationException : Exception
	{
		public ApplicationException()
		{
		}

		public ApplicationException(string message)
			: base(message)
		{
		}
	}
}

#endif