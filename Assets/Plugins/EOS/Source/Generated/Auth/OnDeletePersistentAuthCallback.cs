// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="AuthInterface.DeletePersistentAuth" />
	/// </summary>
	/// <param name="data">A <see cref="DeletePersistentAuthCallbackInfo" /> containing the output information and result</param>
	public delegate void OnDeletePersistentAuthCallback(DeletePersistentAuthCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnDeletePersistentAuthCallbackInternal(System.IntPtr data);
}