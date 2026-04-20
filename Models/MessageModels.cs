using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MangsIpulAsli.Models
{
    public class MessageResponse
    {
        [JsonPropertyName("data")]
        public List<MessageData> Data { get; set; }
    }

    public class MessageDetailResponse
    {
        [JsonPropertyName("data")]
        public MessageData Data { get; set; }
    }

    public class MessageData
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
