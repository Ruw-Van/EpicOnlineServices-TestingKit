// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices
{
	public sealed partial class EpicAccountId : Handle
	{
		public EpicAccountId()
		{
		}

		public EpicAccountId(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// A character buffer of this size is large enough to fit a successful output of <see cref="ToString" />. This length does not include the null-terminator.
		/// The EpicAccountId data structure is opaque in nature and no assumptions of its structure should be inferred
		/// </summary>
		public const int EpicaccountidMaxLength = 32;

		/// <summary>
		/// Retrieve an <see cref="EpicAccountId" /> from a raw string representing an Epic Online Services Account ID. The input string must be null-terminated.
		/// </summary>
		/// <param name="accountIdString">The stringified account ID for which to retrieve the Epic Online Services Account ID</param>
		/// <returns>
		/// The <see cref="EpicAccountId" /> that corresponds to the AccountIdString
		/// </returns>
		public static EpicAccountId FromString(string accountIdString)
		{
			System.IntPtr accountIdStringAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet(ref accountIdStringAddress, accountIdString);

			var funcResult = EOS_EpicAccountId_FromString(accountIdStringAddress);

			Helper.TryMarshalDispose(ref accountIdStringAddress);

			EpicAccountId funcResultReturn;
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Check whether or not the given Epic Online Services Account ID is considered valid
		/// </summary>
		/// <param name="accountId">The Epic Online Services Account ID to check for validity</param>
		/// <returns>
		/// true if the <see cref="EpicAccountId" /> is valid, otherwise false
		/// </returns>
		public bool IsValid()
		{
			var funcResult = EOS_EpicAccountId_IsValid(InnerHandle);

			bool funcResultReturn;
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Retrieve a null-terminated stringified Epic Online Services Account ID from an <see cref="EpicAccountId" />. This is useful for replication of Epic Online Services Account IDs in multiplayer games.
		/// This string will be no larger than <see cref="EpicaccountidMaxLength" /> + 1 and will only contain UTF8-encoded printable characters (excluding the null-terminator).
		/// </summary>
		/// <param name="accountId">The Epic Online Services Account ID for which to retrieve the stringified version.</param>
		/// <param name="outBuffer">The buffer into which the character data should be written</param>
		/// <param name="inOutBufferLength">
		/// The size of the OutBuffer in characters.
		/// The input buffer should include enough space to be null-terminated.
		/// When the function returns, this parameter will be filled with the length of the string copied into OutBuffer including the null termination character.
		/// </param>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the Epic Online Services Account ID string was copied into the OutBuffer.
		/// <see cref="Result.Success" /> - The OutBuffer was filled, and InOutBufferLength contains the number of characters copied into OutBuffer including the null terminator.
		/// <see cref="Result.InvalidParameters" /> - Either OutBuffer or InOutBufferLength were passed as NULL parameters.
		/// <see cref="Result.InvalidUser" /> - The AccountId is invalid and cannot be stringified.
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the Epic Online Services Account ID string. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public Result ToString(out string outBuffer)
		{
			System.IntPtr outBufferAddress = System.IntPtr.Zero;
			int inOutBufferLength = EpicaccountidMaxLength + 1;
			Helper.TryMarshalAllocate(ref outBufferAddress, inOutBufferLength, out _);

			var funcResult = EOS_EpicAccountId_ToString(InnerHandle, outBufferAddress, ref inOutBufferLength);

			Helper.TryMarshalGet(outBufferAddress, out outBuffer);
			Helper.TryMarshalDispose(ref outBufferAddress);

			return funcResult;
		}

		[System.Runtime.InteropServices.DllImport(Config.BinaryName)]
		internal static extern System.IntPtr EOS_EpicAccountId_FromString(System.IntPtr accountIdString);

		[System.Runtime.InteropServices.DllImport(Config.BinaryName)]
		internal static extern int EOS_EpicAccountId_IsValid(System.IntPtr accountId);

		[System.Runtime.InteropServices.DllImport(Config.BinaryName)]
		internal static extern Result EOS_EpicAccountId_ToString(System.IntPtr accountId, System.IntPtr outBuffer, ref int inOutBufferLength);
	}
}