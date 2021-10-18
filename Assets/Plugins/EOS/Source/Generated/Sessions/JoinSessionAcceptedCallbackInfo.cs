// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Output parameters for the <see cref="OnJoinSessionAcceptedCallback" /> function.
	/// </summary>
	public class JoinSessionAcceptedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Context that was passed into <see cref="SessionsInterface.AddNotifyJoinSessionAccepted" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID for the user who initialized the game
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The UI Event associated with this Join Game event.
		/// This should be used with <see cref="SessionsInterface.CopySessionHandleByUiEventId" /> to get a handle to be used
		/// when calling <see cref="SessionsInterface.JoinSession" />.
		/// </summary>
		public ulong UiEventId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(JoinSessionAcceptedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				UiEventId = other.Value.UiEventId;
			}
		}

		public void Set(object other)
		{
			Set(other as JoinSessionAcceptedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct JoinSessionAcceptedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private ulong m_UiEventId;

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

		public ulong UiEventId
		{
			get
			{
				return m_UiEventId;
			}
		}
	}
}