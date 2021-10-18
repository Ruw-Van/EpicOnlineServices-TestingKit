// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Callback for information related to open connections being closed.
	/// </summary>
	public delegate void OnRemoteConnectionClosedCallback(OnRemoteConnectionClosedInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnRemoteConnectionClosedCallbackInternal(System.IntPtr data);
}