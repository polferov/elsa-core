using FastEndpoints;
using FluentValidation;
using JetBrains.Annotations;

namespace Elsa.Identity.Endpoints.Login;

[PublicAPI]
internal class RequestValidator : Validator<Request>
{
    public RequestValidator()
    {
        RuleFor(x => x.Username).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}