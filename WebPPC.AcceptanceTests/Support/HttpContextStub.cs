using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Moq;
using TechTalk.SpecFlow;
using System.Web.Routing;

namespace WebPPC.AcceptanceTests.Support
{
    [Binding]
    public class HttpContextStub
    {
        private static StubSession SessionStub;

        [BeforeScenario]
        public void CleanReferenceBooks()
        {
            SessionStub = null;
        }

        public static HttpContextBase Get()
        {
            var httpContextStub = new Mock<HttpContextBase>();
            if (SessionStub == null)
            {
                SessionStub = new StubSession();
            }

            httpContextStub.SetupGet(m => m.Session).Returns(SessionStub);
            return httpContextStub.Object;
        }

        public static void SetupController(Controller controller)
        {
            controller.ControllerContext = new ControllerContext { HttpContext = Get() };
        }

        public static void SetupController(Controller controller, RouteData routeData)
        {
            controller.ControllerContext = new ControllerContext { HttpContext = Get(), RouteData = routeData };
        }

        private class StubSession : HttpSessionStateBase
        {
            private readonly Dictionary<string, object> _state = new Dictionary<string, object>();

            public override object this[string name]
            {
                get
                {
                    if (!_state.ContainsKey(name))
                        return null;
                    else
                        return _state[name];
                }

                set
                {
                    _state[name] = value;
                }
            }
        }
    }
}
