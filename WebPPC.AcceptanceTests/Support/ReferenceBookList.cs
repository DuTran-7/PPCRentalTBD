using System.Collections.Generic;
using WebPPC.Models;
using FluentAssertions;

namespace WebPPC.AcceptanceTests.Support
{
    public class ReferenceBookList : Dictionary<string, PROPERTY>
    {
        public PROPERTY GetById(string bookId)
        {
            return this[bookId.Trim()].Should().NotBeNull()
                                      .And.Subject.Should().BeOfType<PROPERTY>().Which;
        }
    }
}
