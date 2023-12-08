using Authentication_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication_API.Data;

public class DataContext :IdentityDbContext<User>
{
    public DataContext(DbContextOptions<DataContext> opts) : base (opts) 
    {
        
    }
}
