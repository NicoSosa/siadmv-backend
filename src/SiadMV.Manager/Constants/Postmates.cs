namespace SiadMV.Manager.Constants
{
	public struct Postmates
	{
		public const string ClientId = "postmates:clientid";
		public const string Key = "postmates:key";
		public const string Uri = "postmates:uri";
		public const string Secret = "postmates:secret";

		public struct Endpoints
		{
			public const string Deliveries = "postmates:endpoint:deliveries";
			public const string DeliveryQuotes = "postmates:endpoint:deliveryQuotes";
		}
	}
}
