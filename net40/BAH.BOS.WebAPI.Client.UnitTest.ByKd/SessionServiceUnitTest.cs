﻿using BAH.BOS.WebAPI.Client.BusinessOperationResult;
using BAH.BOS.WebAPI.Client.BusinessServiceOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace BAH.BOS.WebAPI.Client.UnitTest
{
    //[TestClass]
    public class SessionServiceUnitTest : BaseUnitTest<UnitTestParameter>
    {
        [TestMethod]
        public virtual void TestSessionService()
        {
            Login();
            TestHeartbeat();
        }//end method

        public virtual void TestHeartbeat()
        {
            var result = APIClient.CreateAPIOperation<SessionService>(TestParameter.URL)
                                  .Heartbeat()
                                  .ToKdAPIRequest()
                                  .ToAPIResponse<ServiceResult>();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNull(result.Error);
            Assert.IsNull(result.APIError);
            Assert.IsNotNull(result.Body);
            Assert.IsTrue(result.Body.Code == (int)ResultCode.Success);
        }//end method

    }//end class
}//end namespace
