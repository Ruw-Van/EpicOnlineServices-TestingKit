// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="OnUpdateSendingCallback" />.
	/// </summary>
	public class UpdateSendingCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// This returns:
		/// <see cref="Result.Success" /> if the channel was successfully blocked.
		/// <see cref="Result.UnexpectedError" /> otherwise.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Client-specified data passed into <see cref="RTCAudioInterface.UpdateSending" />.
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The room this settings should be applied on.
		/// </summary>
		public string RoomName { get; private set; }

		/// <summary>
		/// Muted or unmuted audio track status
		/// </summary>
		public RTCAudioStatus AudioStatus { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(UpdateSendingCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				AudioStatus = other.Value.AudioStatus;
			}
		}

		public void Set(object other)
		{
			Set(other as UpdateSendingCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UpdateSendingCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private RTCAudioStatus m_AudioStatus;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

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

		public string RoomName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_RoomName, out value);
				return value;
			}
		}

		public RTCAudioStatus AudioStatus
		{
			get
			{
				return m_AudioStatus;
			}
		}
	}
}