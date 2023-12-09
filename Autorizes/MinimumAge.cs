using Microsoft.AspNetCore.Authorization;

namespace Authentication_API.Autorizes
{
    public class MinimumAge : IAuthorizationRequirement
    {
        public MinimumAge(int age) 
        {
            Age = age;
        }
        public int Age { get; set; }
    }
}
