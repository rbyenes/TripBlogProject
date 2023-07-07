using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.ValidationRules.FluentValidation
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(b => b.ID).NotEmpty();
            RuleFor(b => b.Title).NotEmpty();
            RuleFor(b => b.BlogImage).NotEmpty();
            RuleFor(b => b.DateTime).NotEmpty();
            RuleFor(b => b.Description).NotEmpty();

        }
    }
}
