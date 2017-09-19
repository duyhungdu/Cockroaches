using Cockroaches.Core.Validations;
using FluentValidation;
using System;

namespace Cockroaches.Model.Validators
{
   public class AspNetGroupsValidator : AbstractValidator<AspNetGroup>
    {
        public AspNetGroupsValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Tên nhóm không được để trống.");
            RuleFor(x => x.CreatedOn).SetValidator(new ValidSQLDateTimeValidator<DateTime>()).WithMessage("Ngày tạo không hợp lệ.");
            RuleFor(x => x.CreatedBy).NotEmpty().WithMessage("Chọn người tạo.");

        }
    }
}
