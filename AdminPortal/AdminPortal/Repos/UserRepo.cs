using AdminPortal.Data;
using System.Linq.Expressions;

namespace AdminPortal.Repos
{
    public class UserRepo : BaseRepo<ApplicationUser, ApplicationDbContext>
    {
        public UserRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
