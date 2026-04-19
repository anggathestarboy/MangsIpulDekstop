using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MangsIpulAsli.Models
{
    public class TransactionResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public TransactionPagination Data { get; set; }
    }

    public class TransactionPagination
    {
        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("data")]
        public List<Transaction> Data { get; set; }

        [JsonPropertyName("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonPropertyName("from")]
        public int? From { get; set; }

        [JsonPropertyName("last_page")]
        public int LastPage { get; set; }

        [JsonPropertyName("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonPropertyName("links")]
        public List<PaginationLink> Links { get; set; }

        [JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonPropertyName("to")]
        public int? To { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class Transaction
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("payment_profile_id")]
        public int? PaymentProfileId { get; set; }

        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("admin_note")]
        public string AdminNote { get; set; }

        [JsonPropertyName("midtrans_order_id")]
        public string MidtransOrderId { get; set; }

        [JsonPropertyName("snap_token")]
        public string SnapToken { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("total_price")]
        public decimal TotalPrice { get; set; }

        [JsonPropertyName("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonPropertyName("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("payment_profile")]
        public PaymentProfile PaymentProfile { get; set; }

        [JsonPropertyName("details")]
        public List<TransactionDetail> Details { get; set; }
    }

    public class PaymentProfile
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("province")]
        public string Province { get; set; }

        [JsonPropertyName("regencie")]
        public string Regencie { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("village")]
        public string Village { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }

    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }

    public class TransactionDetail
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("transaction_id")]
        public int TransactionId { get; set; }

        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("qty")]
        public int Qty { get; set; }

        [JsonPropertyName("sub_price")]
        public decimal SubPrice { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }
    }
}
