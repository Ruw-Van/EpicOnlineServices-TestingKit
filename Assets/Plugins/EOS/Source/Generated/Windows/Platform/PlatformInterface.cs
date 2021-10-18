// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Platform
{
	public sealed partial class PlatformInterface : Handle
	{
		/// <summary>
		/// The most recent version of the <see cref="WindowsRTCOptionsPlatformSpecificOptions" /> structure.
		/// </summary>
		public const int PlatformWindowsrtcoptionsplatformspecificoptionsApiLatest = 1;

		public static PlatformInterface Create(WindowsOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<WindowsOptionsInternal, WindowsOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_Platform_Create(optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			PlatformInterface funcResultReturn;
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}
	}
}