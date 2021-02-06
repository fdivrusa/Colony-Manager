using ColonyManager.Application.Validators.Account;
using ColonyManager.Domain.Models.Account;
using FluentAssertions;
using Xunit;

namespace ColonyManager.UnitTests.Validators
{
    public class AccountValidatorTests
    {
        private AuthenticateRequestDtoValidator AuthenticateRequestValidator { get; }

        public AccountValidatorTests()
        {
            AuthenticateRequestValidator = new AuthenticateRequestDtoValidator();
        }

        #region AuthenticateRequestValidator tests
        [Fact]
        public void AuthenticateRequestValidation_ShouldFailed_When_Password_Missing()
        {
            var request = new AuthenticateRequestDto
            {
                Email = "test@test.com",
                Password = null
            };
            AuthenticateRequestValidator.Validate(request).IsValid.Should().BeFalse();
        }

        [Fact]
        public void AuthenticateRequestValidation_ShouldFailed_When_Email_Missing()
        {
            var request = new AuthenticateRequestDto
            {
                Email = null,
                Password = "test123test123"
            };
            AuthenticateRequestValidator.Validate(request).IsValid.Should().BeFalse();
        }

        [Fact]
        public void AuthenticateRequestValidation_ShouldFailed_When_Email_Not_Valid()
        {
            var request = new AuthenticateRequestDto
            {
                Email = "testtest.com",
                Password = "test123test123"
            };
            AuthenticateRequestValidator.Validate(request).IsValid.Should().BeFalse();
        }

        [Fact]
        public void AuthenticateRequestValidation_Success_When_AllFilled()
        {
            var request = new AuthenticateRequestDto
            {
                Email = "test@test.com",
                Password = "test123test123"
            };
            AuthenticateRequestValidator.Validate(request).IsValid.Should().BeTrue();
        }
        #endregion


    }
}
