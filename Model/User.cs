using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreGoogleAuth.Model
{

    public class User
	{
		private ClaimsPrincipal _principal;

		public User(ClaimsPrincipal principal) {
			this._principal = principal;
		}
		public string Name => _principal.Identity.Name;
		public string Email => _principal.FindFirst(ClaimTypes.Email).Value;
	}

}