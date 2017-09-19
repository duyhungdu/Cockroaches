using Cockroaches.Core.Validations;
using FluentValidation;
using System;

namespace Cockroaches.Model.Validators
{
   public class AspNetGroupUsersValidator : AbstractValidator<AspNetGroupUser>
    {
        public AspNetGroupUsersValidator()
        {
            RuleFor(x => x.GroupId).NotNull().WithMessage("Nhóm không được để trống.");
            RuleFor(x => x.UserId).NotNull().WithMessage("Người dùng không được để trống.");
        }
    }
}
