namespace EBIMa.DTO
{
	public class GetUserByIdDTO
	{
		public string? Name { get; set; }
		public string? SurName { get; set; }
		public string? Email { get; set; }
		public string? PhoneNumber { get; set; }
		public string MTK { get; set; } = string.Empty;
		public string BlockNumber { get; set; } = string.Empty;
		public string Floor { get; set; } = string.Empty;
		public string ApartmentNumber { get; set; } = string.Empty;


	}
}
