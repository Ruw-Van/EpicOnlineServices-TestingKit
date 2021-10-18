// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.UpdateSessionModification" /> function.
	/// </summary>
	public class UpdateSessionModificationOptions
	{
		/// <summary>
		/// Name of the session to update
		/// </summary>
		public string SessionName { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UpdateSessionModificationOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_SessionName;

		public string SessionName
		{
			set
			{
				Helper.TryMarshalSet(ref m_SessionName, value);
			}
		}

		public void Set(UpdateSessionModificationOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionsInterface.UpdatesessionmodificationApiLatest;
				SessionName = other.SessionName;
			}
		}

		public void Set(object other)
		{
			Set(other as UpdateSessionModificationOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_SessionName);
		}
	}
}