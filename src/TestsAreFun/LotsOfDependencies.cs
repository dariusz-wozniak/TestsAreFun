using TestsAreFun.AgeCalculator;
using TestsAreFun.Configuration;
using TestsAreFun.TestDoubleCustomer;

namespace TestsAreFun
{
    public class LotsOfDependencies
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IConfigurationWrapper _configurationWrapper;
        private readonly ICustomerValidator _customerValidator;
        private readonly ICustomerRepository _customerRepository;

        public LotsOfDependencies(IDateTimeProvider dateTimeProvider,
            IConfigurationWrapper configurationWrapper,
            ICustomerValidator customerValidator,
            ICustomerRepository customerRepository)
        {
            _dateTimeProvider = dateTimeProvider;
            _configurationWrapper = configurationWrapper;
            _customerValidator = customerValidator;
            _customerRepository = customerRepository;
        }

        public DateTime GetCurrentDateTime() => _dateTimeProvider.GetDateTime();
    }
}
