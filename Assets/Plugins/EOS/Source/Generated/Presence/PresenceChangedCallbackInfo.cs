// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data containing which users presence has changed
	/// </summary>
	public class PresenceChangedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into <see cref="PresenceInterface.AddNotifyOnPresenceChanged" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Epic Online Services Account ID of the local user who is being informed for PresenceUserId's presence change
		/// </summary>
		public EpicAccountId LocalUserId { get; private set; }

		/// <summary>
		/// The Epic Online Services Account ID of the user who had their presence changed
		/// </summary>
		public EpicAccountId PresenceUserId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(PresenceChangedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				PresenceUserId = other.Value.PresenceUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as PresenceChangedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceChangedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_PresenceUserId;

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

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public EpicAccountId PresenceUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_PresenceUserId, out value);
				return value;
			}
		}
	}
}