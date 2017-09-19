using Cockroaches.Core.Validations;
using FluentValidation;
using System;

namespace Cockroaches.Model.Validators
{
   public class AspNetUserRolesValidator : AbstractValidator<AspNetUserRole>
    {
        public AspNetUserRolesValidator()
        {
            RuleFor(x => x.UserId).NotNull().WithMessage("Người dùng không được để trống.");
            RuleFor(x => x.RoleId).NotNull().WithMessage("Quyền không được để trống.");
        }
    }
}
