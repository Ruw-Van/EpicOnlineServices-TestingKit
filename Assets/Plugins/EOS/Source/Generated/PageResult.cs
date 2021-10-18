// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices
{
	/// <summary>
	/// A page result is part of query callback info. It is used to provide pagination details of query results.
	/// </summary>
	public class PageResult : ISettable
	{
		/// <summary>
		/// The index into the ordered query results to start the page at.
		/// </summary>
		public int StartIndex { get; set; }

		/// <summary>
		/// The number of results in the current page.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// The number of results associated with they original query options.
		/// </summary>
		public int TotalCount { get; set; }

		internal void Set(PageResultInternal? other)
		{
			if (other != null)
			{
				StartIndex = other.Value.StartIndex;
				Count = other.Value.Count;
				TotalCount = other.Value.TotalCount;
			}
		}

		public void Set(object other)
		{
			Set(other as PageResultInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PageResultInternal : ISettable, System.IDisposable
	{
		private int m_StartIndex;
		private int m_Count;
		private int m_TotalCount;

		public int StartIndex
		{
			get
			{
				return m_StartIndex;
			}

			set
			{
				m_StartIndex = value;
			}
		}

		public int Count
		{
			get
			{
				return m_Count;
			}

			set
			{
				m_Count = value;
			}
		}

		public int TotalCount
		{
			get
			{
				return m_TotalCount;
			}

			set
			{
				m_TotalCount = value;
			}
		}

		public void Set(PageResult other)
		{
			if (other != null)
			{
				StartIndex = other.StartIndex;
				Count = other.Count;
				TotalCount = other.TotalCount;
			}
		}

		public void Set(object other)
		{
			Set(other as PageResult);
		}

		public void Dispose()
		{
		}
	}
}