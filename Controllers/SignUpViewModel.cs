
namespace NettlyMVCWebApp.web.Controllers
{
    public class SignUpViewModel
    {
        internal object LastName;
        internal object UserName;
        internal object Role;

        public object FirstName { get; internal set; }

        internal string GetHashCode(object password)
        {
            throw new NotImplementedException();
        }
    }
}