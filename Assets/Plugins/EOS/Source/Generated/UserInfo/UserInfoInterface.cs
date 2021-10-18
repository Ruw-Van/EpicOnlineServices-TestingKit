// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UserInfo
{
	public sealed partial class UserInfoInterface : Handle
	{
		public UserInfoInterface()
		{
		}

		public UserInfoInterface(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="CopyExternalUserInfoByAccountIdOptions" /> struct.
		/// </summary>
		public const int CopyexternaluserinfobyaccountidApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyExternalUserInfoByIndexOptions" /> struct.
		/// </summary>
		public const int CopyexternaluserinfobyaccounttypeApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyExternalUserInfoByIndexOptions" /> struct.
		/// </summary>
		public const int CopyexternaluserinfobyindexApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="CopyUserInfo" /> API.
		/// </summary>
		public const int CopyuserinfoApiLatest = 2;

		/// <summary>
		/// The most recent version of the <see cref="ExternalUserInfo" /> struct.
		/// </summary>
		public const int ExternaluserinfoApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="Achievements.AchievementsInterface.GetAchievementDefinitionCount" /> API.
		/// </summary>
		public const int GetexternaluserinfocountApiLatest = 1;

		/// <summary>
		/// The maximum length of display names, in displayable characters
		/// </summary>
		public const int MaxDisplaynameCharacters = 16;

		/// <summary>
		/// The maximum length of display names when encoded as UTF-8 as returned by <see cref="CopyUserInfo" />. This length does not include the null terminator.
		/// </summary>
		public const int MaxDisplaynameUtf8Length = 64;

		/// <summary>
		/// The most recent version of the <see cref="QueryUserInfo" /> API.
		/// </summary>
		public const int QueryuserinfoApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="QueryUserInfoByDisplayName" /> API.
		/// </summary>
		public const int QueryuserinfobydisplaynameApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="QueryUserInfoByExternalAccount" /> API.
		/// </summary>
		public const int QueryuserinfobyexternalaccountApiLatest = 1;

		/// <summary>
		/// Fetches an external user info for a given external account ID.
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Structure containing the account ID being accessed</param>
		/// <param name="outExternalUserInfo">The external user info. If it exists and is valid, use <see cref="Release" /> when finished</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutExternalUserInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.NotFound" /> if the external user info is not found
		/// </returns>
		public Result CopyExternalUserInfoByAccountId(CopyExternalUserInfoByAccountIdOptions options, out ExternalUserInfo outExternalUserInfo)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<CopyExternalUserInfoByAccountIdOptionsInternal, CopyExternalUserInfoByAccountIdOptions>(ref optionsAddress, options);

			var outExternalUserInfoAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_UserInfo_CopyExternalUserInfoByAccountId(InnerHandle, optionsAddress, ref outExternalUserInfoAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			if (Helper.TryMarshalGet<ExternalUserInfoInternal, ExternalUserInfo>(outExternalUserInfoAddress, out outExternalUserInfo))
			{
				Bindings.EOS_UserInfo_ExternalUserInfo_Release(outExternalUserInfoAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// Fetches an external user info for a given external account type.
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Structure containing the account type being accessed</param>
		/// <param name="outExternalUserInfo">The external user info. If it exists and is valid, use <see cref="Release" /> when finished</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutExternalUserInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.NotFound" /> if the external user info is not found
		/// </returns>
		public Result CopyExternalUserInfoByAccountType(CopyExternalUserInfoByAccountTypeOptions options, out ExternalUserInfo outExternalUserInfo)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<CopyExternalUserInfoByAccountTypeOptionsInternal, CopyExternalUserInfoByAccountTypeOptions>(ref optionsAddress, options);

			var outExternalUserInfoAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_UserInfo_CopyExternalUserInfoByAccountType(InnerHandle, optionsAddress, ref outExternalUserInfoAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			if (Helper.TryMarshalGet<ExternalUserInfoInternal, ExternalUserInfo>(outExternalUserInfoAddress, out outExternalUserInfo))
			{
				Bindings.EOS_UserInfo_ExternalUserInfo_Release(outExternalUserInfoAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// Fetches an external user info from a given index.
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Structure containing the index being accessed</param>
		/// <param name="outExternalUserInfo">The external user info. If it exists and is valid, use <see cref="Release" /> when finished</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutExternalUserInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.NotFound" /> if the external user info is not found
		/// </returns>
		public Result CopyExternalUserInfoByIndex(CopyExternalUserInfoByIndexOptions options, out ExternalUserInfo outExternalUserInfo)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<CopyExternalUserInfoByIndexOptionsInternal, CopyExternalUserInfoByIndexOptions>(ref optionsAddress, options);

			var outExternalUserInfoAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_UserInfo_CopyExternalUserInfoByIndex(InnerHandle, optionsAddress, ref outExternalUserInfoAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			if (Helper.TryMarshalGet<ExternalUserInfoInternal, ExternalUserInfo>(outExternalUserInfoAddress, out outExternalUserInfo))
			{
				Bindings.EOS_UserInfo_ExternalUserInfo_Release(outExternalUserInfoAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// <see cref="CopyUserInfo" /> is used to immediately retrieve a copy of user information based on an Epic Online Services Account ID, cached by a previous call to <see cref="QueryUserInfo" />.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutUserInfo, must be passed to <see cref="Release" /> to release the memory associated with it.
		/// <seealso cref="UserInfoData" />
		/// <seealso cref="CopyUserInfoOptions" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">structure containing the input parameters</param>
		/// <param name="outUserInfo">out parameter used to receive the <see cref="UserInfoData" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutUserInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// <see cref="Result.NotFound" /> if the user info is not locally cached. The information must have been previously cached by a call to <see cref="QueryUserInfo" />
		/// </returns>
		public Result CopyUserInfo(CopyUserInfoOptions options, out UserInfoData outUserInfo)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<CopyUserInfoOptionsInternal, CopyUserInfoOptions>(ref optionsAddress, options);

			var outUserInfoAddress = System.IntPtr.Zero;

			var funcResult = Bindings.EOS_UserInfo_CopyUserInfo(InnerHandle, optionsAddress, ref outUserInfoAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			if (Helper.TryMarshalGet<UserInfoDataInternal, UserInfoData>(outUserInfoAddress, out outUserInfo))
			{
				Bindings.EOS_UserInfo_Release(outUserInfoAddress);
			}

			return funcResult;
		}

		/// <summary>
		/// Fetch the number of external user infos that are cached locally.
		/// <seealso cref="CopyExternalUserInfoByIndex" />
		/// </summary>
		/// <param name="options">The options associated with retrieving the external user info count</param>
		/// <returns>
		/// The number of external user infos, or 0 if there is an error
		/// </returns>
		public uint GetExternalUserInfoCount(GetExternalUserInfoCountOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<GetExternalUserInfoCountOptionsInternal, GetExternalUserInfoCountOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_UserInfo_GetExternalUserInfoCount(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// <see cref="QueryUserInfo" /> is used to start an asynchronous query to retrieve information, such as display name, about another account.
		/// Once the callback has been fired with a successful ResultCode, it is possible to call <see cref="CopyUserInfo" /> to receive an <see cref="UserInfoData" /> containing the available information.
		/// <seealso cref="UserInfoData" />
		/// <seealso cref="CopyUserInfo" />
		/// <seealso cref="QueryUserInfoOptions" />
		/// <seealso cref="OnQueryUserInfoCallback" />
		/// </summary>
		/// <param name="options">structure containing the input parameters</param>
		/// <param name="clientData">arbitrary data that is passed back to you in the CompletionDelegate</param>
		/// <param name="completionDelegate">a callback that is fired when the async operation completes, either successfully or in error</param>
		public void QueryUserInfo(QueryUserInfoOptions options, object clientData, OnQueryUserInfoCallback completionDelegate)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<QueryUserInfoOptionsInternal, QueryUserInfoOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var completionDelegateInternal = new OnQueryUserInfoCallbackInternal(OnQueryUserInfoCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			Bindings.EOS_UserInfo_QueryUserInfo(InnerHandle, optionsAddress, clientDataAddress, completionDelegateInternal);

			Helper.TryMarshalDispose(ref optionsAddress);
		}

		/// <summary>
		/// <see cref="QueryUserInfoByDisplayName" /> is used to start an asynchronous query to retrieve user information by display name. This can be useful for getting the <see cref="EpicAccountId" /> for a display name.
		/// Once the callback has been fired with a successful ResultCode, it is possible to call <see cref="CopyUserInfo" /> to receive an <see cref="UserInfoData" /> containing the available information.
		/// <seealso cref="UserInfoData" />
		/// <seealso cref="CopyUserInfo" />
		/// <seealso cref="QueryUserInfoByDisplayNameOptions" />
		/// <seealso cref="OnQueryUserInfoByDisplayNameCallback" />
		/// </summary>
		/// <param name="options">structure containing the input parameters</param>
		/// <param name="clientData">arbitrary data that is passed back to you in the CompletionDelegate</param>
		/// <param name="completionDelegate">a callback that is fired when the async operation completes, either successfully or in error</param>
		public void QueryUserInfoByDisplayName(QueryUserInfoByDisplayNameOptions options, object clientData, OnQueryUserInfoByDisplayNameCallback completionDelegate)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<QueryUserInfoByDisplayNameOptionsInternal, QueryUserInfoByDisplayNameOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var completionDelegateInternal = new OnQueryUserInfoByDisplayNameCallbackInternal(OnQueryUserInfoByDisplayNameCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			Bindings.EOS_UserInfo_QueryUserInfoByDisplayName(InnerHandle, optionsAddress, clientDataAddress, completionDelegateInternal);

			Helper.TryMarshalDispose(ref optionsAddress);
		}

		/// <summary>
		/// <see cref="QueryUserInfoByExternalAccount" /> is used to start an asynchronous query to retrieve user information by external accounts.
		/// This can be useful for getting the <see cref="EpicAccountId" /> for external accounts.
		/// Once the callback has been fired with a successful ResultCode, it is possible to call CopyUserInfo to receive an <see cref="UserInfoData" /> containing the available information.
		/// <seealso cref="UserInfoData" />
		/// <seealso cref="QueryUserInfoByExternalAccountOptions" />
		/// <seealso cref="OnQueryUserInfoByExternalAccountCallback" />
		/// </summary>
		/// <param name="options">structure containing the input parameters</param>
		/// <param name="clientData">arbitrary data that is passed back to you in the CompletionDelegate</param>
		/// <param name="completionDelegate">a callback that is fired when the async operation completes, either successfully or in error</param>
		public void QueryUserInfoByExternalAccount(QueryUserInfoByExternalAccountOptions options, object clientData, OnQueryUserInfoByExternalAccountCallback completionDelegate)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<QueryUserInfoByExternalAccountOptionsInternal, QueryUserInfoByExternalAccountOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var completionDelegateInternal = new OnQueryUserInfoByExternalAccountCallbackInternal(OnQueryUserInfoByExternalAccountCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			Bindings.EOS_UserInfo_QueryUserInfoByExternalAccount(InnerHandle, optionsAddress, clientDataAddress, completionDelegateInternal);

			Helper.TryMarshalDispose(ref optionsAddress);
		}

		[MonoPInvokeCallback(typeof(OnQueryUserInfoByDisplayNameCallbackInternal))]
		internal static void OnQueryUserInfoByDisplayNameCallbackInternalImplementation(System.IntPtr data)
		{
			OnQueryUserInfoByDisplayNameCallback callback;
			QueryUserInfoByDisplayNameCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnQueryUserInfoByDisplayNameCallback, QueryUserInfoByDisplayNameCallbackInfoInternal, QueryUserInfoByDisplayNameCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryUserInfoByExternalAccountCallbackInternal))]
		internal static void OnQueryUserInfoByExternalAccountCallbackInternalImplementation(System.IntPtr data)
		{
			OnQueryUserInfoByExternalAccountCallback callback;
			QueryUserInfoByExternalAccountCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnQueryUserInfoByExternalAccountCallback, QueryUserInfoByExternalAccountCallbackInfoInternal, QueryUserInfoByExternalAccountCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryUserInfoCallbackInternal))]
		internal static void OnQueryUserInfoCallbackInternalImplementation(System.IntPtr data)
		{
			OnQueryUserInfoCallback callback;
			QueryUserInfoCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnQueryUserInfoCallback, QueryUserInfoCallbackInfoInternal, QueryUserInfoCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}
	}
}