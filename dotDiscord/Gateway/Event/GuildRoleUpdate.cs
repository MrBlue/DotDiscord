using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildRoleUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Role object
    }
}