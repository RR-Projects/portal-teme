﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using PortalTeme.Data.Identity;
using PortalTeme.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalTeme.Data.Authorization.Policies {
    public class AssignmentAuthorizatonCrudHandler : AuthorizationHandler<OperationAuthorizationRequirement, Assignment> {
        private CourseAuthorizatonCrudHandler courseHandler;

        public AssignmentAuthorizatonCrudHandler(UserManager<User> userManager, PortalTemeContext temeContext) {
            courseHandler = new CourseAuthorizatonCrudHandler(userManager, temeContext);
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Assignment resource) {
            return courseHandler.HandleCourseRequirementAsync(context, requirement, resource.Course);
        }
    }
}
