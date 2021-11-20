using System;
using AutomationPracticeProject.Helpers;
using NUnit.Framework;

namespace AutomationPracticeProject.TestCases
{
    [SetUpFixture]
    public class BaseSuite
    {
        private ExtentReportsHelper Extent;

        [OneTimeSetUp]
        public void SetUpReporter()
        {
            Extent = ExtentReportsHelper.GetExtentReportsHelper();
        }

        [OneTimeTearDown]
        public void CloseReporterAndSendMessage()
        {
            try
            {
                Extent.Close();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}