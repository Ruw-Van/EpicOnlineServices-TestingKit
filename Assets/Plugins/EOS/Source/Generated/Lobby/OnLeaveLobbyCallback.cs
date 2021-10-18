// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="LobbyInterface.LeaveLobby" />
	/// </summary>
	/// <param name="data">A <see cref="LobbyInterface.LeaveLobby" /> CallbackInfo containing the output information and result</param>
	public delegate void OnLeaveLobbyCallback(LeaveLobbyCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
	internal delegate void OnLeaveLobbyCallbackInternal(System.IntPtr data);
}