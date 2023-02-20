namespace Starnight;

using System;

public readonly partial record struct Snowflake
{
	public static Snowflake operator +
	(
		Snowflake left,
		TimeSpan right
	)
	{
		Int64 time = (Int64)right.TotalMilliseconds << 22;
		return left.Value + time;
	}

	public static Snowflake operator -
	(
		Snowflake left,
		TimeSpan right
	)
	{
		Int64 time = (Int64)right.TotalMilliseconds << 22;
		return left.Value - time;
	}

	public static Boolean operator ==
	(
		Snowflake left,
		DateTimeOffset right
	)
		=> left.Timestamp == right;

	public static Boolean operator !=
	(
		Snowflake left,
		DateTimeOffset right
	)
		=> left.Timestamp != right;

	public static Boolean operator <
	(
		Snowflake left,
		DateTimeOffset right
	)
		=> left.Timestamp < right;

	public static Boolean operator <=
	(
		Snowflake left,
		DateTimeOffset right
	)
		=> left.Timestamp <= right;

	public static Boolean operator >
	(
		Snowflake left,
		DateTimeOffset right
	)
		=> left.Timestamp > right;

	public static Boolean operator >=
	(
		Snowflake left,
		DateTimeOffset right
	)
		=> left.Timestamp >= right;

	/// <summary>
	/// Returns the absolute difference in time between the two snowflakes.
	/// </summary>
	public static TimeSpan GetAbsoluteTimeDifference
	(
		Snowflake first,
		Snowflake second
	)
	{
		Int64 absolute = Int64.Abs
		(
			first - second
		);

		return new
		(
			(absolute >> 22) * 10_000
		);
	}

	/// <summary>
	/// Creates a new snowflake from an offset into the future.
	/// </summary>
	public static Snowflake FromFuture
	(
		TimeSpan offset
	)
	{
		return new
		(
			DateTimeOffset.UtcNow + offset,
			0,
			0,
			0
		);
	}

	/// <summary>
	/// Creates a new snowflake from an offset into the past.
	/// </summary>
	public static Snowflake FromPast
	(
		TimeSpan offset
	)
	{
		return new
		(
			DateTimeOffset.UtcNow - offset,
			0,
			0,
			0
		);
	}
}
