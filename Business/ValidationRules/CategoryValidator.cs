using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CetegoryName).NotEmpty().WithMessage("Kategori adını boş geçemesiniz");
            RuleFor(x => x.CetegoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.CetegoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.CetegoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer giriş yapamyın");
        }
    }
}
