using GoogleAuth.Auth.AuthEnums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoogleAuth.Auth.Attributes
{
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    //public class AuthorizeADAttribute : AuthorizeAttribute, IAuthorizationFilter
    //{
    //    private const string USER_ROLE_NOT_EXISTS_RESPONSE = "Access denied. There is no role set for your user.";
    //    private const string USER_ROLE_CHECK_FAIL_RESPONSE = "Access denied. Check your user role.";

    //    public AuthRole AuthRole { get; }

    //    public AuthorizeADAttribute(AuthRole authRole)
    //    {
    //        AuthRole = authRole;
    //    }
    //    public void OnAuthorization(AuthorizationFilterContext authorizationFilterContext)
    //    {
    //        var identity = authorizationFilterContext.HttpContext.User.Identity;
    //        if (identity.IsAuthenticated)
    //        {
    //            var claimsIdentity = identity as ClaimsIdentity;
    //            var clientAuthenticationMode = claimsIdentity
    //                .Claims
    //                .FirstOrDefault(claim => claim.Type.Equals(Claims.AUTHENTICATION_MODE))?.Value;

    //            // allow private clients; 0 = public client (users), 1 = client id and secret (azure functions), 2 = client certificate
    //            if (clientAuthenticationMode == "1")
    //            {
    //                return;
    //            }

    //            if (AuthRole == AuthRole.AnyAzureAD)
    //            {
    //                return;
    //            }

    //            var userRoleId = claimsIdentity
    //                .Claims
    //                .FirstOrDefault(claim => claim.Type.Equals(Claims.ROLE_ID))?.Value ?? null;
    //            if (userRoleId is null)
    //            {
    //                authorizationFilterContext.Result = new UnauthorizedObjectResult(USER_ROLE_NOT_EXISTS_RESPONSE);
    //                return;
    //            }

    //            var authRoleId = ((int)AuthRole).ToString();
    //            if (!authRoleId.Contains(userRoleId))
    //            {
    //                authorizationFilterContext.Result = new ObjectResult(USER_ROLE_CHECK_FAIL_RESPONSE) { StatusCode = 403 };
    //                return;
    //            }
    //        }
    //    }
    //}
}
