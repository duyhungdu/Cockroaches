using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Core.Validations;
using FluentValidation;

namespace Cockroaches.Model.Validators
{
   public class ItemAttachmentsValidator : AbstractValidator<ItemAttachment>
    {
        public ItemAttachmentsValidator()
        {
            RuleFor(x => x.AttachmentType).NotEmpty().WithMessage("Loại không để trống.");
        }
    }
}
