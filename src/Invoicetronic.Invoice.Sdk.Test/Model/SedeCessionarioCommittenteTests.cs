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
    ///  Class for testing SedeCessionarioCommittente
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SedeCessionarioCommittenteTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SedeCessionarioCommittente
        //private SedeCessionarioCommittente instance;

        public SedeCessionarioCommittenteTests()
        {
            // TODO uncomment below to create an instance of SedeCessionarioCommittente
            //instance = new SedeCessionarioCommittente();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SedeCessionarioCommittente
        /// </summary>
        [Fact]
        public void SedeCessionarioCommittenteInstanceTest()
        {
            // TODO uncomment below to test "IsType" SedeCessionarioCommittente
            //Assert.IsType<SedeCessionarioCommittente>(instance);
        }

        /// <summary>
        /// Test the property 'Indirizzo'
        /// </summary>
        [Fact]
        public void IndirizzoTest()
        {
            // TODO unit test for the property 'Indirizzo'
        }

        /// <summary>
        /// Test the property 'NumeroCivico'
        /// </summary>
        [Fact]
        public void NumeroCivicoTest()
        {
            // TODO unit test for the property 'NumeroCivico'
        }

        /// <summary>
        /// Test the property 'Cap'
        /// </summary>
        [Fact]
        public void CapTest()
        {
            // TODO unit test for the property 'Cap'
        }

        /// <summary>
        /// Test the property 'Comune'
        /// </summary>
        [Fact]
        public void ComuneTest()
        {
            // TODO unit test for the property 'Comune'
        }

        /// <summary>
        /// Test the property 'Provincia'
        /// </summary>
        [Fact]
        public void ProvinciaTest()
        {
            // TODO unit test for the property 'Provincia'
        }

        /// <summary>
        /// Test the property 'Nazione'
        /// </summary>
        [Fact]
        public void NazioneTest()
        {
            // TODO unit test for the property 'Nazione'
        }
    }
}
