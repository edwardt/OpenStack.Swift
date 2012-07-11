namespace OpenStack.Swift
{
	using System;
	using System.Collections.Generic;

	public class BaseResponse
	{		
		/// <summary>
		/// Headers for the associated resource
		/// </summary>
		public readonly Dictionary<string, string> Headers;
		/// <summary>
		/// response status from the server.
		/// </summary>
		public readonly int Status;
		/// <summary>
		/// The status description from the server.
		/// </summary>
		public readonly string Reason;

		//private BaseResponse(){}

		public BaseResponse (Dictionary<string, string> headers,  string reason, int status)
		{
			Headers = headers;
			Status = status;
			Reason = reason;
		}
	}
}

