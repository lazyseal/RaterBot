// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace RaterBot.Database
{
	[Table("Interaction")]
	public class Interaction
	{
		[Column("Id"       , IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public long Id        { get; set; } // integer
		[Column("ChatId"                                                                                     )] public long ChatId    { get; set; } // integer
		[Column("MessageId"                                                                                  )] public long MessageId { get; set; } // integer
		[Column("UserId"                                                                                     )] public long UserId    { get; set; } // integer
		[Column("Reaction"                                                                                   )] public bool Reaction  { get; set; } // integer
	}
}
