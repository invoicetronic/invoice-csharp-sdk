/*
 * Italian Invoice API
 *
 * The Italian Invoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1] (Interchange Service). The API is designed by Invoicetronic to be simple and easy to use, abstracting away the Interchange Service's complexity while still providing complete control over the invoice send/receive process. The API also provides advanced features and a rich toolchain, such as invoice validation, multiple upload methods, webhooks, event logs, CORS support, client SDKs for commonly used languages, and CLI tools.  For more information, see:  - [Invoicetronic website][2] - [Invoice API reference][3]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/ [3]: https://api.invoicetronic.com/invoice/v1/docs 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Invoicetronic.InvoiceApi.Model;
using Invoicetronic.InvoiceApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.InvoiceApi.Test.Model
{
    /// <summary>
    ///  Class for testing DatiBollo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiBolloTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiBollo
        //private DatiBollo instance;

        public DatiBolloTests()
        {
            // TODO uncomment below to create an instance of DatiBollo
            //instance = new DatiBollo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiBollo
        /// </summary>
        [Fact]
        public void DatiBolloInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiBollo
            //Assert.IsType<DatiBollo>(instance);
        }

        /// <summary>
        /// Test the property 'BolloVirtuale'
        /// </summary>
        [Fact]
        public void BolloVirtualeTest()
        {
            // TODO unit test for the property 'BolloVirtuale'
        }

        /// <summary>
        /// Test the property 'ImportoBollo'
        /// </summary>
        [Fact]
        public void ImportoBolloTest()
        {
            // TODO unit test for the property 'ImportoBollo'
        }
    }
}
