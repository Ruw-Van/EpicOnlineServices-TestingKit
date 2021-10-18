// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Input parameters for the <see cref="AchievementsInterface.GetPlayerAchievementCount" /> function.
	/// </summary>
	public class GetPlayerAchievementCountOptions
	{
		/// <summary>
		/// The Product User ID for the user whose achievement count is being retrieved.
		/// </summary>
		public ProductUserId UserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetPlayerAchievementCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_UserId;

		public ProductUserId UserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_UserId, value);
			}
		}

		public void Set(GetPlayerAchievementCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AchievementsInterface.GetplayerachievementcountApiLatest;
				UserId = other.UserId;
			}
		}

		public void Set(object other)
		{
			Set(other as GetPlayerAchievementCountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_UserId);
		}
	}
}