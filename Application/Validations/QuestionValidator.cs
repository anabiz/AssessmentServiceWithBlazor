//using Application.Enums;
//using BlazorApp1.Shared;
//using FluentValidation;

//namespace Application.Validations
//{
//    public class QuestionValidator : AbstractValidator<CreateQuestionDto>
//    {
//        public QuestionValidator()
//        {
//            RuleFor(x => x.Type).IsEnumName(typeof(EQuestionType))
//                .WithMessage("Enter a valid Question type");
//        }
//    }
//}
