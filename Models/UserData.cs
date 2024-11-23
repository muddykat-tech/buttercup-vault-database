using System.ComponentModel.DataAnnotations;
namespace ButtercupAPI.Models;

public class UserData
{
    [Key]
	public string tideUID {get;set;} = default!;
	public required string vaultName {get; set;}
	public required string vaultData {get; set;}

}