namespace Zbw.Carrent.Tests.CustomerManagement.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Zbw.Carrent.CustomerManagement.Api;

    public class CustomerControllerTests
    {
        [Fact]
        public void Create_WhenNoRepository_ThenThrow()
        {
            Action act = () => new CustomerController(null);

            act.Should().Throw<ArgumentNullException>();
        }
    }
}
