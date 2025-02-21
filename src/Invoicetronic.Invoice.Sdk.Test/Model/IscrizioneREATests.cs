/*
 * Italian eInvoice API v1
 *
 * The [Italian eInvoice API][2] is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Invoicetronic.Invoice.Sdk.Model;
using Invoicetronic.Invoice.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.Invoice.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing IscrizioneREA
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IscrizioneREATests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IscrizioneREA
        //private IscrizioneREA instance;

        public IscrizioneREATests()
        {
            // TODO uncomment below to create an instance of IscrizioneREA
            //instance = new IscrizioneREA();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IscrizioneREA
        /// </summary>
        [Fact]
        public void IscrizioneREAInstanceTest()
        {
            // TODO uncomment below to test "IsType" IscrizioneREA
            //Assert.IsType<IscrizioneREA>(instance);
        }

        /// <summary>
        /// Test the property 'Ufficio'
        /// </summary>
        [Fact]
        public void UfficioTest()
        {
            // TODO unit test for the property 'Ufficio'
        }

        /// <summary>
        /// Test the property 'NumeroRea'
        /// </summary>
        [Fact]
        public void NumeroReaTest()
        {
            // TODO unit test for the property 'NumeroRea'
        }

        /// <summary>
        /// Test the property 'CapitaleSociale'
        /// </summary>
        [Fact]
        public void CapitaleSocialeTest()
        {
            // TODO unit test for the property 'CapitaleSociale'
        }

        /// <summary>
        /// Test the property 'SocioUnico'
        /// </summary>
        [Fact]
        public void SocioUnicoTest()
        {
            // TODO unit test for the property 'SocioUnico'
        }

        /// <summary>
        /// Test the property 'StatoLiquidazione'
        /// </summary>
        [Fact]
        public void StatoLiquidazioneTest()
        {
            // TODO unit test for the property 'StatoLiquidazione'
        }
    }
}
