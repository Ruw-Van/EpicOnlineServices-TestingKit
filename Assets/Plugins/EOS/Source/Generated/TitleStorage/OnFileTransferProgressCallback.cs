// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Callback for when there is a progress update for a file transfer in progress
	/// </summary>
	public delegate void OnFileTransferProgressCallback(FileTransferProgressCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnFileTransferProgressCallbackInternal(System.IntPtr data);
}