using Cockroaches.Core.Validations;
using FluentValidation;
using System;

namespace Cockroaches.Model.Validators
{
   public class AspNetRoleValidator : AbstractValidator<AspNetRole>
    {
        public AspNetRoleValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Tên quyền không được để trống.");
            RuleFor(x => x.CreatedOn).SetValidator(new ValidSQLDateTimeValidator<DateTime>()).WithMessage("Ngày tạo không hợp lệ.");
            RuleFor(x => x.CreatedBy).NotEmpty().WithMessage("Chọn người tạo.");

        }
    }
}
