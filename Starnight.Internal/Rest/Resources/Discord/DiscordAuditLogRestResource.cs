namespace Starnight.Internal.Rest.Resources.Discord;

using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Starnight.Caching.Abstractions;
using Starnight.Internal.Entities.Guilds.Audit;

using static DiscordApiConstants;

/// <inheritdoc cref="IDiscordAuditLogRestResource"/>
public sealed class DiscordAuditLogRestResource
	: AbstractRestResource, IDiscordAuditLogRestResource
{
	private readonly RestClient __rest_client;

	/// <inheritdoc/>
	public DiscordAuditLogRestResource
	(
		RestClient client,
		ICacheProvider cache
	)
		: base(cache)
		=> this.__rest_client = client;

	/// <inheritdoc/>
	public async ValueTask<DiscordAuditLogObject> GetGuildAuditLogAsync
	(
		Int64 guildId,
		Int64? userId = null,
		DiscordAuditLogEvent? actionType = null,
		Int64? before = null,
		Int32? limit = null,
		CancellationToken ct = default
	)
	{
		QueryBuilder builder = new
		(
			$"{Guilds}/{guildId}/{AuditLogs}"
		);

		_ = builder.AddParameter
			(
				"user_id",
				userId.ToString()
			)
			.AddParameter
			(
				"action_type",
				((Int32?)actionType).ToString()
			)
			.AddParameter
			(
				"before",
				before.ToString()
			)
			.AddParameter
			(
				"limit",
				limit.ToString()
			);

		IRestRequest request = new RestRequest
		{
			Url = builder.Build(),
			Method = HttpMethod.Get,
			Context = new()
			{
				["endpoint"] = $"/{Guilds}/{guildId}/{AuditLogs}",
				["cache"] = this.RatelimitBucketCache,
				["exempt-from-global-limit"] = false,
				["is-webhook-request"] = false
			}
		};

		HttpResponseMessage response = await this.__rest_client.MakeRequestAsync
		(
			request,
			ct
		);

		return JsonSerializer.Deserialize<DiscordAuditLogObject>
		(
			await response.Content.ReadAsStringAsync
			(
				ct
			),
			StarnightInternalConstants.DefaultSerializerOptions
		)!;
	}
}
