// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	public class EndSessionOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct EndSessionOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(EndSessionOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatClientInterface.EndsessionApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as EndSessionOptions);
		}

		public void Dispose()
		{
		}
	}
}