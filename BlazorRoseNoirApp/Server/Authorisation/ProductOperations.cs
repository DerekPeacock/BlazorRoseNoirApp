using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace BlazorRoseNoirApp.Server.Authorisation
{
	public class ProductOperations
	{
		public static OperationAuthorizationRequirement Create = 
			new OperationAuthorizationRequirement 
			{ Name= Constants.CreateOperation };

		public static OperationAuthorizationRequirement Read =
			new OperationAuthorizationRequirement
			{ Name = Constants.ReadOperation };

		public static OperationAuthorizationRequirement Update =
			new OperationAuthorizationRequirement
			{ Name = Constants.UpdateOperation };

		public static OperationAuthorizationRequirement Delete =
			new OperationAuthorizationRequirement
			{ Name = Constants.DeleteOperation };

		public static OperationAuthorizationRequirement List =
			new OperationAuthorizationRequirement
			{ Name = Constants.ListOperation };
	}
}
