//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Mvc;
//using TechTalk.SpecFlow;

//namespace WebPPC.AcceptanceTests.Support
//{
//    [Binding]
//    public class HttpContextStub
//    {
//        private static StubSession SessionStub;

//        [BeforeScenario]
//        public void CleanReferenceBooks()
//        {
//            SessionStub = null;
//        }

//        public static HttpContextBase Get()
//        {
//            var httpContextStub = new Mock<HttpContextBase>();
//            if (SessionStub == null)
//            {
//                SessionStub = new StubSession();
//            }

//            httpContextStub.SetupGet(m => m.Session).Returns(SessionStub);
//            return httpContextStub.Object;
//        }

//        //public static void SetupController(Controller controller) => controller.ControllerContext = new ControllerContext { HttpContext = Get() };

//        private class StubSession : HttpSessionStateBase
//        {
//            private readonly Dictionary<string, object> _state = new Dictionary<string, object>();

//            public override object this[string name]
//            {
//                get => !_state.ContainsKey(name) ? null : _state[name];
//                set => _state[name] = value;
//            }
//        }
//    }

//    public class HttpContextBase
//    {
//        public object Session { get; internal set; }
//    }
//}
