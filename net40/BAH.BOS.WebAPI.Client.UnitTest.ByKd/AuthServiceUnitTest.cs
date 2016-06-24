﻿using BAH.BOS.WebAPI.Client.AuthOperationResult;
using BAH.BOS.WebAPI.Client.AuthServiceOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace BAH.BOS.WebAPI.Client.UnitTest
{
    //[TestClass]
    public class AuthServiceUnitTest : BaseUnitTest<UnitTestParameter>
    {
        [TestMethod]
        public virtual void TestLogin()
        {
            var result = this.Login();

            Assert.AreEqual(result.StatusCode, HttpStatusCode.OK);
            Assert.IsNull(result.Error);
            Assert.IsNull(result.APIError);
            Assert.IsNotNull(result.Body);
            Assert.IsNotNull(result.Body.Context);
            Assert.IsFalse(string.IsNullOrWhiteSpace(result.Body.Context.UserName));
        }//end method

    }//end class
}//end namespace
