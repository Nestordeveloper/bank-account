#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace bank_account.Models;
public class Transaction
{
    public int TransactionId { get; set; }
    public int Amount { get; set; }
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }
    public User? Creator { get; set; }
}