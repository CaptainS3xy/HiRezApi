// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HiRezApi.RealmRoyale.Models
{
    using System.Linq;
    using HiRezApi.Common.Models;

    public partial class PlayerMatchHistory : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the PlayerMatchHistory class.
        /// </summary>
        public PlayerMatchHistory() { }

        /// <summary>
        /// Initializes a new instance of the PlayerMatchHistory class.
        /// </summary>
        public PlayerMatchHistory(string retMsg, int id = default(int), System.Collections.Generic.IList<Match> matches = default(System.Collections.Generic.IList<Match>), string name = default(string))
            : base(retMsg)
        {
            Id = id;
            Matches = matches;
            Name = name;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "matches")]
        public System.Collections.Generic.IList<Match> Matches { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
