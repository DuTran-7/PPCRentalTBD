﻿using System.Web.Mvc;
using FluentAssertions;

namespace WebPPC.AcceptanceTests.Support
{
    public static class ActionResultExtensions
    {
        public static TModel Model<TModel>(this ActionResult result)
        {
            return result.Should().NotBeNull()
                         .And.Subject.Should().BeAssignableTo<ViewResult>()
                         .Which.ViewData.Model.Should().NotBeNull()
                         .And.Subject.Should().BeAssignableTo<TModel>()
                         .Subject;
            //return result.Should()
            //             .Subject.Should().BeAssignableTo<ViewResult>()
            //             .Which.ViewData.Model.Should().Subject.Should().BeAssignableTo<TModel>()
            //             .Subject;
        }
    }
}