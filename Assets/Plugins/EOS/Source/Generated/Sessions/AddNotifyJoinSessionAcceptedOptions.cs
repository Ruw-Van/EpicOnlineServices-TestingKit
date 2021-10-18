// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.AddNotifyJoinSessionAccepted" /> function.
	/// </summary>
	public class AddNotifyJoinSessionAcceptedOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyJoinSessionAcceptedOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(AddNotifyJoinSessionAcceptedOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionsInterface.AddnotifyjoinsessionacceptedApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyJoinSessionAcceptedOptions);
		}

		public void Dispose()
		{
		}
	}
}