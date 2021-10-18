// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.SetPermissionLevel" /> function.
	/// </summary>
	public class SessionModificationSetPermissionLevelOptions
	{
		/// <summary>
		/// Permission level to set on the sesion
		/// </summary>
		public OnlineSessionPermissionLevel PermissionLevel { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationSetPermissionLevelOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private OnlineSessionPermissionLevel m_PermissionLevel;

		public OnlineSessionPermissionLevel PermissionLevel
		{
			set
			{
				m_PermissionLevel = value;
			}
		}

		public void Set(SessionModificationSetPermissionLevelOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionModification.SessionmodificationSetpermissionlevelApiLatest;
				PermissionLevel = other.PermissionLevel;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionModificationSetPermissionLevelOptions);
		}

		public void Dispose()
		{
		}
	}
}