namespace EBIMa.DTO
{
	public class PostApplicationRequestsDTO
	{
		public string? RequestType { get; set; } // e.g., "Şikayət", "Təklif", "Giriş kartı", "Digər"
		public string? Message { get; set; }     // User's request message
	}
}
