// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	/// <summary>
	/// Structure containing details about a client/peer authentication status change
	/// </summary>
	public class OnClientAuthStatusChangedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Caller-specified context data
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The identifier of the client/peer that this status change applies to. See the RegisterClient and RegisterPeer functions.
		/// </summary>
		public System.IntPtr ClientHandle { get; private set; }

		/// <summary>
		/// The client/peer's new authentication status
		/// </summary>
		public AntiCheatCommonClientAuthStatus ClientAuthStatus { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnClientAuthStatusChangedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				ClientHandle = other.Value.ClientHandle;
				ClientAuthStatus = other.Value.ClientAuthStatus;
			}
		}

		public void Set(object other)
		{
			Set(other as OnClientAuthStatusChangedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct OnClientAuthStatusChangedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_ClientHandle;
		private AntiCheatCommonClientAuthStatus m_ClientAuthStatus;

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public System.IntPtr ClientHandle
		{
			get
			{
				return m_ClientHandle;
			}
		}

		public AntiCheatCommonClientAuthStatus ClientAuthStatus
		{
			get
			{
				return m_ClientAuthStatus;
			}
		}
	}
}