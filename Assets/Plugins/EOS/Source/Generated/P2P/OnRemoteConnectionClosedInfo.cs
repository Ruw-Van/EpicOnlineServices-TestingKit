// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about an connection request that is being closed.
	/// </summary>
	public class OnRemoteConnectionClosedInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into <see cref="Presence.PresenceInterface.AddNotifyOnPresenceChanged" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The local user who is being notified of a connection being closed
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The Product User ID of the remote user who this connection was with
		/// </summary>
		public ProductUserId RemoteUserId { get; private set; }

		/// <summary>
		/// The socket ID of the connection being closed
		/// </summary>
		public SocketId SocketId { get; private set; }

		/// <summary>
		/// The reason the connection was closed (if known)
		/// </summary>
		public ConnectionClosedReason Reason { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnRemoteConnectionClosedInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RemoteUserId = other.Value.RemoteUserId;
				SocketId = other.Value.SocketId;
				Reason = other.Value.Reason;
			}
		}

		public void Set(object other)
		{
			Set(other as OnRemoteConnectionClosedInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct OnRemoteConnectionClosedInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RemoteUserId;
		private System.IntPtr m_SocketId;
		private ConnectionClosedReason m_Reason;

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

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public ProductUserId RemoteUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_RemoteUserId, out value);
				return value;
			}
		}

		public SocketId SocketId
		{
			get
			{
				SocketId value;
				Helper.TryMarshalGet<SocketIdInternal, SocketId>(m_SocketId, out value);
				return value;
			}
		}

		public ConnectionClosedReason Reason
		{
			get
			{
				return m_Reason;
			}
		}
	}
}