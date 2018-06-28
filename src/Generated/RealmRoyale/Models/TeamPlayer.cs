// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HiRezApi.RealmRoyale.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TeamPlayer
    {
        /// <summary>
        /// Initializes a new instance of the TeamPlayer class.
        /// </summary>
        public TeamPlayer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamPlayer class.
        /// </summary>
        public TeamPlayer(int assists = default(int), int classId = default(int), string className = default(string), int damageDoneInHand = default(int), int damageMitigated = default(int), int damagePlayer = default(int), int damageTaken = default(int), int deaths = default(int), int droppedOutFlag = default(int), int durationSecs = default(int), int earnedTokens = default(int), int earnedXp = default(int), double healingPlayer = default(double), double healingPlayerSelf = default(double), int id = default(int), int killingSpreeMax = default(int), int killsBot = default(int), int killsPlayer = default(int), int level = default(int), int minesWardsPlaced = default(int), string name = default(string))
        {
            Assists = assists;
            ClassId = classId;
            ClassName = className;
            DamageDoneInHand = damageDoneInHand;
            DamageMitigated = damageMitigated;
            DamagePlayer = damagePlayer;
            DamageTaken = damageTaken;
            Deaths = deaths;
            DroppedOutFlag = droppedOutFlag;
            DurationSecs = durationSecs;
            EarnedTokens = earnedTokens;
            EarnedXp = earnedXp;
            HealingPlayer = healingPlayer;
            HealingPlayerSelf = healingPlayerSelf;
            Id = id;
            KillingSpreeMax = killingSpreeMax;
            KillsBot = killsBot;
            KillsPlayer = killsPlayer;
            Level = level;
            MinesWardsPlaced = minesWardsPlaced;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assists")]
        public int Assists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "class_id")]
        public int ClassId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "damage_done_in_hand")]
        public int DamageDoneInHand { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "damage_mitigated")]
        public int DamageMitigated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "damage_player")]
        public int DamagePlayer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "damage_taken")]
        public int DamageTaken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deaths")]
        public int Deaths { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dropped_out_flag")]
        public int DroppedOutFlag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration_secs")]
        public int DurationSecs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "earned_tokens")]
        public int EarnedTokens { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "earned_xp")]
        public int EarnedXp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "healing_player")]
        public double HealingPlayer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "healing_player_self")]
        public double HealingPlayerSelf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "killing_spree_max")]
        public int KillingSpreeMax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kills_bot")]
        public int KillsBot { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kills_player")]
        public int KillsPlayer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mines_wards_placed")]
        public int MinesWardsPlaced { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}