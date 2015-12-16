﻿namespace Nancy.Tests.Functional.Tests
{
    using System.Threading.Tasks;
    using Modules;

    using Testing;
    using Xunit;

    public class CookieFixture
    {
        [Fact]
        public async Task Cookie_should_decode_value_correctly()
        {
            // Given
            var browser = new Browser(with => with.Module<CookieModule>());

            // When
            await browser.GetAsync("/setcookie");
                
            var result = await browser.GetAsync("/getcookie");

            // Then
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}