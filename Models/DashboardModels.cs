using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MangsIpulAsli.Models
{
    public class DashboardStats
    {
        [JsonPropertyName("total_sales")]
        public object total_sales { get; set; } // Can be string or number from API

        [JsonPropertyName("total_orders")]
        public int total_orders { get; set; }

        [JsonPropertyName("total_products")]
        public int total_products { get; set; }

        [JsonPropertyName("total_customers")]
        public int total_customers { get; set; }

        public decimal TotalSalesValue
        {
            get
            {
                if (total_sales == null) return 0;
                if (total_sales is string s)
                {
                    decimal.TryParse(s, out decimal result);
                    return result;
                }
                if (total_sales is JsonElement je)
                {
                    if (je.ValueKind == JsonValueKind.String)
                    {
                        decimal.TryParse(je.GetString(), out decimal result);
                        return result;
                    }
                    if (je.ValueKind == JsonValueKind.Number)
                    {
                        return je.GetDecimal();
                    }
                }
                try { return Convert.ToDecimal(total_sales); } catch { return 0; }
            }
        }
    }

    public class ChartDataPoint
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("total")]
        public object Total { get; set; }

        public decimal TotalValue
        {
            get
            {
                if (Total == null) return 0;
                if (Total is string s)
                {
                    decimal.TryParse(s, out decimal result);
                    return result;
                }
                if (Total is JsonElement je)
                {
                    if (je.ValueKind == JsonValueKind.String)
                    {
                        decimal.TryParse(je.GetString(), out decimal result);
                        return result;
                    }
                    if (je.ValueKind == JsonValueKind.Number)
                    {
                        return je.GetDecimal();
                    }
                }
                try { return Convert.ToDecimal(Total); } catch { return 0; }
            }
        }
    }

    public class DashboardChartResponse
    {
        [JsonPropertyName("filter")]
        public string Filter { get; set; }

        [JsonPropertyName("data")]
        public List<ChartDataPoint> Data { get; set; }
    }

    public class LogActivity
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("entity")]
        public string Entity { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        public DateTime CreatedAtDateTime
        {
            get
            {
                if (DateTime.TryParse(CreatedAt, out DateTime dt)) return dt;
                return DateTime.Now;
            }
        }
    }

    public class WalletInfo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("balance")]
        public object Balance { get; set; }

        public decimal BalanceValue
        {
            get
            {
                if (Balance == null) return 0;
                if (Balance is string s)
                {
                    decimal.TryParse(s, out decimal result);
                    return result;
                }
                if (Balance is JsonElement je)
                {
                    if (je.ValueKind == JsonValueKind.String)
                    {
                        decimal.TryParse(je.GetString(), out decimal result);
                        return result;
                    }
                    if (je.ValueKind == JsonValueKind.Number)
                    {
                        return je.GetDecimal();
                    }
                }
                try { return Convert.ToDecimal(Balance); } catch { return 0; }
            }
        }
    }
}
