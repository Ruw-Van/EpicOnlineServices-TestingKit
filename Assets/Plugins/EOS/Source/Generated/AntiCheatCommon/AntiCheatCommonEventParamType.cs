// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	/// <summary>
	/// Types supported for custom gameplay behavior event parameters
	/// </summary>
	public enum AntiCheatCommonEventParamType : int
	{
		/// <summary>
		/// Not used
		/// </summary>
		Invalid = 0,
		/// <summary>
		/// <see cref="System.IntPtr" />
		/// </summary>
		ClientHandle = 1,
		/// <summary>
		/// const char*
		/// </summary>
		String = 2,
		/// <summary>
		/// uint32_t
		/// </summary>
		UInt32 = 3,
		/// <summary>
		/// int32_t
		/// </summary>
		Int32 = 4,
		/// <summary>
		/// uint64_t
		/// </summary>
		UInt64 = 5,
		/// <summary>
		/// int64_t
		/// </summary>
		Int64 = 6,
		/// <summary>
		/// <see cref="Vec3f" />
		/// </summary>
		Vector3f = 7,
		/// <summary>
		/// <see cref="Quat" />
		/// </summary>
		Quat = 8
	}
}