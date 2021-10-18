// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// Return results for <see cref="OnReadFileDataCallback" /> callbacks to return
	/// </summary>
	public enum ReadResult : int
	{
		/// <summary>
		/// Signifies the data was read successfully, and we should continue to the next chunk if possible
		/// </summary>
		ContinueReading = 1,
		/// <summary>
		/// Signifies there was a failure reading the data, and the request should end
		/// </summary>
		FailRequest = 2,
		/// <summary>
		/// Signifies the request should be cancelled, but not due to an error
		/// </summary>
		CancelRequest = 3
	}
}