using Cockroaches.Core.Validations;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Model;

namespace Cockroaches.Model.Validators
{
    public class LoginHistoryValidator : AbstractValidator<LoginHistory>
    {
        public LoginHistoryValidator()
        {
            RuleFor(x => x.UserHostAddress).NotEmpty().WithMessage("Địa chỉ IP không được trống.");
            RuleFor(x => x.AttempOn).NotNull().WithMessage("Ngày đăng nhập không được trống.");
            RuleFor(x => x.AttempOn).SetValidator(new ValidSQLDateTimeValidator<DateTime>()).WithMessage("Ngày đăng nhập không hợp lệ.");
        }
    }
}
