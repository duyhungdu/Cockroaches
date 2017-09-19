using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Core.Validations;
using FluentValidation;

namespace Cockroaches.Model.Validators
{
    public class SystemConfigValidator : AbstractValidator<SystemConfig>
    {
        public SystemConfigValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Tên không được trống.");
            RuleFor(x => x.CreatedOn).SetValidator(new ValidSQLDateTimeValidator<DateTime>()).WithMessage("Ngày tạo không hợp lệ.");
            RuleFor(x => x.CreatedBy).NotEmpty().WithMessage("Chọn người tạo.");
        }
    }
}
