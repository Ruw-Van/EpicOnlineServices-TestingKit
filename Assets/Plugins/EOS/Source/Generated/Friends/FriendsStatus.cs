// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// An enumeration of the different friendship statuses.
	/// </summary>
	public enum FriendsStatus : int
	{
		/// <summary>
		/// The two accounts have no friendship status
		/// </summary>
		NotFriends = 0,
		/// <summary>
		/// The local account has sent a friend invite to the other account
		/// </summary>
		InviteSent = 1,
		/// <summary>
		/// The other account has sent a friend invite to the local account
		/// </summary>
		InviteReceived = 2,
		/// <summary>
		/// The accounts have accepted friendship
		/// </summary>
		Friends = 3
	}
}