namespace Starnight.Internal.Entities;

using System;

/// <summary>
/// Represents discord permissions - role permission, channel overwrites.
/// </summary>
[Flags]
public enum DiscordPermissions : Int64
{
	/// <summary>
	/// Allows members to create invites.
	/// </summary>
	CreateInvite = 1 << 0,

	/// <summary>
	/// Allows members to kick others, limited by role hierarchy.
	/// </summary>
	KickMembers = 1 << 1,

	/// <summary>
	/// Allows members to ban others, limited by role hierarchy.
	/// </summary>
	BanMembers = 1 << 2,

	/// <summary>
	/// Administrator permission. Overrides every other permission, allows bypassing channel-specific restrictions.
	/// </summary>
	Administrator = 1 << 3,

	/// <summary>
	/// Allows members to create, edit and delete channels.
	/// </summary>
	ManageChannels = 1 << 4,

	/// <summary>
	/// Allows members to change (most) guild settings.
	/// </summary>
	ManageGuild = 1 << 5,

	/// <summary>
	/// Allows members to add a reaction to a message.
	/// </summary>
	AddReactions = 1 << 6,

	/// <summary>
	/// Allows members to access the guild's audit logs.
	/// </summary>
	ViewAuditLog = 1 << 7,

	/// <summary>
	/// Allows members to use Priority Speaker functionality.
	/// </summary>
	PrioritySpeaker = 1 << 8,

	/// <summary>
	/// Allows members to go live in voice channels.
	/// </summary>
	Stream = 1 << 9,

	/// <summary>
	/// Allows members to view (read) channels.
	/// </summary>
	ViewChannel = 1 << 10,

	/// <summary>
	/// Allows members to send messages in channels and to create threads in a forum channel.
	/// </summary>
	SendMessages = 1 << 11,

	/// <summary>
	/// Allows members to send text-to-speech messages.
	/// </summary>
	SendTTSMessages = 1 << 12,

	/// <summary>
	/// Allows members to delete other's messages.
	/// </summary>
	ManageMessages = 1 << 13,

	/// <summary>
	/// Allows members' messages to embed sent links.
	/// </summary>
	EmbedLinks = 1 << 14,

	/// <summary>
	/// Allows members to attach files.
	/// </summary>
	AttachFiles = 1 << 15,

	/// <summary>
	/// Allows members to read a channels' message history.
	/// </summary>
	ReadMessageHistory = 1 << 16,

	/// <summary>
	/// Allows members to mention @everyone, @here and all roles.
	/// </summary>
	MentionEveryone = 1 << 17,

	/// <summary>
	/// Allows members to use emojis from other guilds.
	/// </summary>
	UseExternalEmojis = 1 << 18,

	/// <summary>
	/// Allows members to access and view the Guild Insights menu.
	/// </summary>
	ViewGuildInsights = 1 << 19,

	/// <summary>
	/// Allows members to connect to voice channels.
	/// </summary>
	Connect = 1 << 20,

	/// <summary>
	/// Allows members to speak in voice channels.
	/// </summary>
	Speak = 1 << 21,

	/// <summary>
	/// Allows members to mute others in voice channels.
	/// </summary>
	MuteMembers = 1 << 22,

	/// <summary>
	/// Allows members to deafen others in voice channels.
	/// </summary>
	DeafenMembers = 1 << 23,

	/// <summary>
	/// Allows members to move others between voice channels they have access to.
	/// </summary>
	MoveMembers = 1 << 24,

	/// <summary>
	/// Allows members to use voice activity detection instead of push-to-talk.
	/// </summary>
	UseVoiceActivity = 1 << 25,

	/// <summary>
	/// Allows members to change their own nickname.
	/// </summary>
	ChangeNickname = 1 << 26,

	/// <summary>
	/// Allows members to change and remove other's nicknames.
	/// </summary>
	ManageNicknames = 1 << 27,

	/// <summary>
	/// Allows members to create, change and grant roles lower than their highest role.
	/// </summary>
	ManageRoles = 1 << 28,

	/// <summary>
	/// Allows members to create and delete webhooks.
	/// </summary>
	ManageWebhooks = 1 << 29,

	/// <summary>
	/// Allows members to manage guild emojis and stickers.
	/// </summary>
	ManageEmojisStickers = 1 << 30,

	/// <summary>
	/// Allows members to use slash and right-click commands.
	/// </summary>
	UseApplicationCommands = 1 << 31,

	/// <summary>
	/// Allows members to request to speak in stage channels.
	/// </summary>
	RequestToSpeak = 1L << 32,

	/// <summary>
	/// Allows members to create, edit and delete events.
	/// </summary>
	ManageEvents = 1L << 33,

	/// <summary>
	/// Allows members to manage threads.
	/// </summary>
	ManageThreads = 1L << 34,

	/// <summary>
	/// Allows members to create public threads.
	/// </summary>
	CreatePublicThreads = 1L << 35,

	/// <summary>
	/// Allows members to create private threads.
	/// </summary>
	CreatePrivateThreads = 1L << 36,

	/// <summary>
	/// Allows members to use stickers from other guilds.
	/// </summary>
	UseExternalStickers = 1L << 37,

	/// <summary>
	/// Allows members to send messages in threads.
	/// </summary>
	SendThreadMessages = 1L << 38,

	/// <summary>
	/// Allows members to start embedded activities.
	/// </summary>
	StartEmbeddedActivities = 1L << 39,

	/// <summary>
	/// Allows members to time out other members.
	/// </summary>
	ModerateMembers = 1L << 40
}
