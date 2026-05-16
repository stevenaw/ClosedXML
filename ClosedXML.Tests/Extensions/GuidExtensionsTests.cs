using NUnit.Framework;
using System;
using ClosedXML.Extensions;

namespace ClosedXML.Tests.Extensions
{
    internal class GuidExtensionsTests
    {
        [Test]
        public void WrapInBraces_formats_as_expected()
        {
            var expected = "{28139ca3-b13d-42af-806d-2e4011534ce7}";

            var guid = Guid.Parse(expected);

            Assert.AreEqual(expected, guid.WrapInBraces());
        }
    }
}
