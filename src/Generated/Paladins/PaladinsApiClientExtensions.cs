// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HiRezApi.Paladins
{
    using HiRezApi.Common.Models;
    using HiRezApi.Paladins.Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PaladinsApiClient.
    /// </summary>
    public static partial class PaladinsApiClientExtensions
    {
            /// <summary>
            /// createsession
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Session CreateSession(this IPaladinsApiClient operations)
            {
                return operations.CreateSessionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// createsession
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Session> CreateSessionAsync(this IPaladinsApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSessionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getdataused
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DataUsed GetDataUsed(this IPaladinsApiClient operations)
            {
                return operations.GetDataUsedAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// getdataused
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataUsed> GetDataUsedAsync(this IPaladinsApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDataUsedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body?.FirstOrDefault();
                }
            }

            /// <summary>
            /// getdemodetails
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchId'>
            /// The matchId
            /// </param>
            public static IList<DemoDetails> GetDemoDetails(this IPaladinsApiClient operations, string matchId)
            {
                return operations.GetDemoDetailsAsync(matchId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getdemodetails
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchId'>
            /// The matchId
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DemoDetails>> GetDemoDetailsAsync(this IPaladinsApiClient operations, string matchId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDemoDetailsWithHttpMessagesAsync(matchId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getfriends
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            public static IList<Friends> GetFriends(this IPaladinsApiClient operations, string player)
            {
                return operations.GetFriendsAsync(player).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getfriends
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Friends>> GetFriendsAsync(this IPaladinsApiClient operations, string player, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFriendsWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getchampionranks
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            public static IList<ChampionRanks> GetChampionRanks(this IPaladinsApiClient operations, string player)
            {
                return operations.GetChampionRanksAsync(player).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getchampionranks
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ChampionRanks>> GetChampionRanksAsync(this IPaladinsApiClient operations, string player, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetChampionRanksWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getchampions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            public static IList<Champions> GetChampions(this IPaladinsApiClient operations, string languageCode)
            {
                return operations.GetChampionsAsync(languageCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getchampions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Champions>> GetChampionsAsync(this IPaladinsApiClient operations, string languageCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetChampionsWithHttpMessagesAsync(languageCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getchampionskins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='championId'>
            /// The championId
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            public static IList<ChampionSkins> GetChampionSkins(this IPaladinsApiClient operations, string championId, string languageCode)
            {
                return operations.GetChampionSkinsAsync(championId, languageCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getchampionskins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='championId'>
            /// The championId
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ChampionSkins>> GetChampionSkinsAsync(this IPaladinsApiClient operations, string championId, string languageCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetChampionSkinsWithHttpMessagesAsync(championId, languageCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getitems
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            public static IList<Items> GetItems(this IPaladinsApiClient operations, string languageCode)
            {
                return operations.GetItemsAsync(languageCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getitems
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Items>> GetItemsAsync(this IPaladinsApiClient operations, string languageCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetItemsWithHttpMessagesAsync(languageCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getmatchdetails
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchId'>
            /// The matchId
            /// </param>
            public static IList<MatchDetails> GetMatchDetails(this IPaladinsApiClient operations, string matchId)
            {
                return operations.GetMatchDetailsAsync(matchId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getmatchdetails
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchId'>
            /// The matchId
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MatchDetails>> GetMatchDetailsAsync(this IPaladinsApiClient operations, string matchId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMatchDetailsWithHttpMessagesAsync(matchId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getmatchdetailsbatch
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchIds'>
            /// The matchIds
            /// </param>
            public static IList<MatchDetails> GetMatchDetailsBatch(this IPaladinsApiClient operations, string matchIds)
            {
                return operations.GetMatchDetailsBatchAsync(matchIds).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getmatchdetailsbatch
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchIds'>
            /// The matchIds
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MatchDetails>> GetMatchDetailsBatchAsync(this IPaladinsApiClient operations, string matchIds, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMatchDetailsBatchWithHttpMessagesAsync(matchIds, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getmatchplayerdetails
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchId'>
            /// The matchId
            /// </param>
            public static IList<MatchPlayerDetails> GetMatchPlayerDetails(this IPaladinsApiClient operations, string matchId)
            {
                return operations.GetMatchPlayerDetailsAsync(matchId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getmatchplayerdetails
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='matchId'>
            /// The matchId
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MatchPlayerDetails>> GetMatchPlayerDetailsAsync(this IPaladinsApiClient operations, string matchId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMatchPlayerDetailsWithHttpMessagesAsync(matchId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getmatchidsbyqueue
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queue'>
            /// The queue
            /// </param>
            /// <param name='date'>
            /// The date
            /// </param>
            /// <param name='hour'>
            /// The hour
            /// </param>
            public static IList<MatchIdsByQueue> GetMatchIdsByQueue(this IPaladinsApiClient operations, string queue, string date, string hour)
            {
                return operations.GetMatchIdsByQueueAsync(queue, date, hour).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getmatchidsbyqueue
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queue'>
            /// The queue
            /// </param>
            /// <param name='date'>
            /// The date
            /// </param>
            /// <param name='hour'>
            /// The hour
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MatchIdsByQueue>> GetMatchIdsByQueueAsync(this IPaladinsApiClient operations, string queue, string date, string hour, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMatchIdsByQueueWithHttpMessagesAsync(queue, date, hour, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getleagueleaderboard
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queue'>
            /// The queue
            /// </param>
            /// <param name='tier'>
            /// The tier
            /// </param>
            /// <param name='season'>
            /// The season
            /// </param>
            public static IList<LeagueLeaderBoard> GetLeagueLeaderBoard(this IPaladinsApiClient operations, string queue, string tier, string season)
            {
                return operations.GetLeagueLeaderBoardAsync(queue, tier, season).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getleagueleaderboard
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='queue'>
            /// The queue
            /// </param>
            /// <param name='tier'>
            /// The tier
            /// </param>
            /// <param name='season'>
            /// The season
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<LeagueLeaderBoard>> GetLeagueLeaderBoardAsync(this IPaladinsApiClient operations, string queue, string tier, string season, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLeagueLeaderBoardWithHttpMessagesAsync(queue, tier, season, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getmatchhistory
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            public static IList<MatchHistory> GetMatchHistory(this IPaladinsApiClient operations, string player)
            {
                return operations.GetMatchHistoryAsync(player).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getmatchhistory
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MatchHistory>> GetMatchHistoryAsync(this IPaladinsApiClient operations, string player, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMatchHistoryWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getplayer
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            public static Player GetPlayer(this IPaladinsApiClient operations, string player)
            {
                return operations.GetPlayerAsync(player).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getplayer
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Player> GetPlayerAsync(this IPaladinsApiClient operations, string player, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPlayerWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body?.FirstOrDefault();
                }
            }

            /// <summary>
            /// getplayerloadouts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            public static IList<PlayerLoadouts> GetPlayerLoadouts(this IPaladinsApiClient operations, string player, string languageCode)
            {
                return operations.GetPlayerLoadoutsAsync(player, languageCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getplayerloadouts
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='languageCode'>
            /// The languageCode
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PlayerLoadouts>> GetPlayerLoadoutsAsync(this IPaladinsApiClient operations, string player, string languageCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPlayerLoadoutsWithHttpMessagesAsync(player, languageCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getplayerstatus
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            public static PlayerStatus GetPlayerStatus(this IPaladinsApiClient operations, string player)
            {
                return operations.GetPlayerStatusAsync(player).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getplayerstatus
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlayerStatus> GetPlayerStatusAsync(this IPaladinsApiClient operations, string player, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPlayerStatusWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body?.FirstOrDefault();
                }
            }

            /// <summary>
            /// getqueuestats
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='queue'>
            /// The queue
            /// </param>
            public static IList<QueueStats> GetQueueStats(this IPaladinsApiClient operations, string player, string queue)
            {
                return operations.GetQueueStatsAsync(player, queue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getqueuestats
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='queue'>
            /// The queue
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<QueueStats>> GetQueueStatsAsync(this IPaladinsApiClient operations, string player, string queue, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQueueStatsWithHttpMessagesAsync(player, queue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getplayerachievements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            public static PlayerAchievements GetPlayerAchievements(this IPaladinsApiClient operations, string player)
            {
                return operations.GetPlayerAchievementsAsync(player).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getplayerachievements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='player'>
            /// The player
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlayerAchievements> GetPlayerAchievementsAsync(this IPaladinsApiClient operations, string player, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPlayerAchievementsWithHttpMessagesAsync(player, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getpatchinfo
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static PatchInfo GetPatchInfo(this IPaladinsApiClient operations)
            {
                return operations.GetPatchInfoAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// getpatchinfo
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PatchInfo> GetPatchInfoAsync(this IPaladinsApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPatchInfoWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// gethirezserverstatus
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HirezServerStatus GetHirezServerStatus(this IPaladinsApiClient operations)
            {
                return operations.GetHirezServerStatusAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// gethirezserverstatus
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HirezServerStatus> GetHirezServerStatusAsync(this IPaladinsApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetHirezServerStatusWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body?.FirstOrDefault();
                }
            }


        /// <summary>
        /// ping
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static string Ping(this IPaladinsApiClient operations)
        {
            return operations.PingAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// ping
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<string> PingAsync(this IPaladinsApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PingWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// testsession
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static string TestSession(this IPaladinsApiClient operations)
        {
            return operations.TestSessionAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// testsession
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<string> TestSessionAsync(this IPaladinsApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.TestSessionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
