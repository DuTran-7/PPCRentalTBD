using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebPPC.Models;
using FluentAssertions;

namespace WebPPC.AcceptanceTests.Common
{
    public class ProjectAssertions
    {
        public static void HomeScreenShouldShow(IEnumerable<WebPPC.Models.PROPERTY> shownProject, IEnumerable<string> expectedTitles)
        {
            shownProject.ShouldAllBeEquivalentTo(expectedTitles, option => option.Excluding(o => o.ID).WithStrictOrdering());
        }

        public static void HomeScreenShouldShow(IEnumerable<PROPERTY> shownProject, IEnumerable<PROPERTY> expectedProject)
        {
            shownProject.ShouldAllBeEquivalentTo(expectedProject, option => option.Excluding(o => o.ID).WithStrictOrdering());
        }
    }
}
