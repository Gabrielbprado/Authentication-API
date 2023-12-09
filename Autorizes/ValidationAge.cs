using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Authentication_API.Autorizes
{
    public class ValidationAge : AuthorizationHandler<MinimumAge>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAge requirement)
        {

            var dateOfBirthClaim = context.User.FindFirst(x => x.Type == ClaimTypes.DateOfBirth);
            if (dateOfBirthClaim == null) return Task.CompletedTask;
            var DateOfBirth = Convert.ToDateTime(dateOfBirthClaim.Value);
            var age = DateTime.Today.Year - DateOfBirth.Year;
            if(DateOfBirth > DateTime.Today.AddDays(-age))
                age--;
            if(age >= requirement.Age)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;

        }
    }
}
