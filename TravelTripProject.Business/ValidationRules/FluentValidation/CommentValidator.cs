using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelTripProject.Models.Entity;

namespace TravelTripProject.Business.ValidationRules.FluentValidation
{
    public class CommentValidator : AbstractValidator<Comments>
    {
        public CommentValidator()
        {
            RuleFor(c => c.ID).NotEmpty();
            RuleFor(c => c.UserName).NotEmpty();
            RuleFor(c => c.Comment).NotEmpty();
        }
    }
}
