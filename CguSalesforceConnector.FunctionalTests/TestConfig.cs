using System;
using TestSharp;

namespace CguSalesforceConnector.FunctionalTests
{
    /// <summary>
    /// Test's configurations.
    /// <remarks>
    /// PLEASE, DO NOT USE PRODUCTION DATA FOR TESTS. SANDBOX EXISTS FOR THIS PURPOSE.
    /// </remarks>
    /// </summary>
    public static class TestConfig
    {
        #region Constructors
        static TestConfig()
        {
            try
            {
                TokenRequestEndpointUrl = ConfigHelper.ReadAppSetting("CguSalesforceConnector.FunctionalTests", "TokenRequestEndpointUrl");
                ClientId = ConfigHelper.ReadAppSetting("CguSalesforceConnector.FunctionalTests", "ClientId");
                ClientSecret = ConfigHelper.ReadAppSetting("CguSalesforceConnector.FunctionalTests", "ClientSecret");
                Username = ConfigHelper.ReadAppSetting("CguSalesforceConnector.FunctionalTests", "Username");
                Password = ConfigHelper.ReadAppSetting("CguSalesforceConnector.FunctionalTests", "Password");
                ObjectName = ConfigHelper.ReadAppSetting("CguSalesforceConnector.FunctionalTests", "ObjectName");                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Please, check the Salesforce.FunctionalTests' App.config and define the test configurations.", ex);
            }

            if (String.IsNullOrWhiteSpace(TokenRequestEndpointUrl)
            || String.IsNullOrWhiteSpace(ClientId)
            || String.IsNullOrWhiteSpace(ClientSecret)
            || String.IsNullOrWhiteSpace(Username)
            || String.IsNullOrWhiteSpace(Password)
            || String.IsNullOrWhiteSpace(ObjectName))
            {
                throw new InvalidOperationException("Please, check the Salesforce.FunctionalTests' App.config and define ALL the test configurations.");
            }           
        }
        #endregion

        #region Properties
        public static string TokenRequestEndpointUrl { get; set; }
        public static string ClientId { get; set; }
        public static string ClientSecret { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string ObjectName { get; set; }
        #endregion
    }
}
