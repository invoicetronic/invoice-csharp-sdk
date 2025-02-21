/*
 * Italian eInvoice API v1
 *
 * The [Italian eInvoice API][2] is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Invoicetronic.Invoice.Sdk.Client;
using Invoicetronic.Invoice.Sdk.Api;
// uncomment below to import models
//using Invoicetronic.Invoice.Sdk.Model;

namespace Invoicetronic.Invoice.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ReceiveApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReceiveApiTests : IDisposable
    {
        private ReceiveApi instance;

        public ReceiveApiTests()
        {
            instance = new ReceiveApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceiveApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReceiveApi
            //Assert.IsType<ReceiveApi>(instance);
        }

        /// <summary>
        /// Test ReceiveGet
        /// </summary>
        [Fact]
        public void ReceiveGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? companyId = null;
            //string identifier = null;
            //bool? unread = null;
            //string committente = null;
            //string prestatore = null;
            //string fileName = null;
            //DateTime? lastUpdateFrom = null;
            //DateTime? lastUpdateTo = null;
            //DateTime? dateSentFrom = null;
            //DateTime? dateSentTo = null;
            //DateTime? documentDateFrom = null;
            //DateTime? documentDateTo = null;
            //string documentNumber = null;
            //int? page = null;
            //int? pageSize = null;
            //string sort = null;
            //var response = instance.ReceiveGet(companyId, identifier, unread, committente, prestatore, fileName, lastUpdateFrom, lastUpdateTo, dateSentFrom, dateSentTo, documentDateFrom, documentDateTo, documentNumber, page, pageSize, sort);
            //Assert.IsType<List<Receive>>(response);
        }

        /// <summary>
        /// Test ReceiveIdDelete
        /// </summary>
        [Fact]
        public void ReceiveIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ReceiveIdDelete(id);
            //Assert.IsType<Receive>(response);
        }

        /// <summary>
        /// Test ReceiveIdGet
        /// </summary>
        [Fact]
        public void ReceiveIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ReceiveIdGet(id);
            //Assert.IsType<Receive>(response);
        }
    }
}
