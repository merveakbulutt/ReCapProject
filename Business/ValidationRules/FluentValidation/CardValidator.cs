using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
 public   class CardValidator : AbstractValidator<Card>
    {
        public CardValidator()
        {
            RuleFor(c=> c.CardNumber).NotEmpty();
            RuleFor(c => c.CardOwnerName).NotEmpty();
            RuleFor(c => c.ExpirationDate).NotEmpty();
            RuleFor(c => c.CardCvv).NotEmpty();
            RuleFor(c => c.CardNumber).MaximumLength(16);
            RuleFor(c => c.CardCvv).MaximumLength(3);

        }
    }
}
