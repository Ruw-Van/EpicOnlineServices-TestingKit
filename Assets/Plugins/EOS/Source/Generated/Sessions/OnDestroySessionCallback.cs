// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="SessionsInterface.DestroySession" />
	/// </summary>
	/// <param name="data">A <see cref="DestroySessionCallbackInfo" /> containing the output information and result</param>
	public delegate void OnDestroySessionCallback(DestroySessionCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
	internal delegate void OnDestroySessionCallbackInternal(System.IntPtr data);
}