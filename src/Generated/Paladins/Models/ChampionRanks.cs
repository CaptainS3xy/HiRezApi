// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HiRezApi.Paladins.Models
{
    using Newtonsoft.Json;
    using System.Linq;
    using HiRezApi.Common.Models;

    public partial class ChampionRanks : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the ChampionRanks class.
        /// </summary>
        public ChampionRanks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChampionRanks class.
        /// </summary>
        public ChampionRanks(string retMsg, int assists = default(int), int deaths = default(int), int kills = default(int), int losses = default(int), int minionKills = default(int), int rank = default(int), int wins = default(int), int worshippers = default(int), string champion = default(string), string championId = default(string), int playerId = default(int))
            : base(retMsg)
        {
            Assists = assists;
            Deaths = deaths;
            Kills = kills;
            Losses = losses;
            MinionKills = minionKills;
            Rank = rank;
            Wins = wins;
            Worshippers = worshippers;
            Champion = champion;
            ChampionId = championId;
            PlayerId = playerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Assists")]
        public int Assists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Kills")]
        public int Kills { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Losses")]
        public int Losses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinionKills")]
        public int MinionKills { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rank")]
        public int Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Wins")]
        public int Wins { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Worshippers")]
        public int Worshippers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "champion")]
        public string Champion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "champion_id")]
        public string ChampionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "player_id")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
