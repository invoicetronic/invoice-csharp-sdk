/*
 * Italian eInvoice API
 *
 * The Italian eInvoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while still providing complete control over the invoice send/receive process. The API also provides advanced features and a rich toolchain, such as invoice validation, multiple upload methods, webhooks, event logs, CORS support, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
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
using Invoicetronic.Invoice.Sdk.Model;
using Invoicetronic.Invoice.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.Invoice.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing DatiGeneraliDocumento
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiGeneraliDocumentoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiGeneraliDocumento
        //private DatiGeneraliDocumento instance;

        public DatiGeneraliDocumentoTests()
        {
            // TODO uncomment below to create an instance of DatiGeneraliDocumento
            //instance = new DatiGeneraliDocumento();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiGeneraliDocumento
        /// </summary>
        [Fact]
        public void DatiGeneraliDocumentoInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiGeneraliDocumento
            //Assert.IsType<DatiGeneraliDocumento>(instance);
        }

        /// <summary>
        /// Test the property 'TipoDocumento'
        /// </summary>
        [Fact]
        public void TipoDocumentoTest()
        {
            // TODO unit test for the property 'TipoDocumento'
        }

        /// <summary>
        /// Test the property 'Divisa'
        /// </summary>
        [Fact]
        public void DivisaTest()
        {
            // TODO unit test for the property 'Divisa'
        }

        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

        /// <summary>
        /// Test the property 'Numero'
        /// </summary>
        [Fact]
        public void NumeroTest()
        {
            // TODO unit test for the property 'Numero'
        }

        /// <summary>
        /// Test the property 'DatiRitenuta'
        /// </summary>
        [Fact]
        public void DatiRitenutaTest()
        {
            // TODO unit test for the property 'DatiRitenuta'
        }

        /// <summary>
        /// Test the property 'DatiBollo'
        /// </summary>
        [Fact]
        public void DatiBolloTest()
        {
            // TODO unit test for the property 'DatiBollo'
        }

        /// <summary>
        /// Test the property 'DatiCassaPrevidenziale'
        /// </summary>
        [Fact]
        public void DatiCassaPrevidenzialeTest()
        {
            // TODO unit test for the property 'DatiCassaPrevidenziale'
        }

        /// <summary>
        /// Test the property 'ScontoMaggiorazione'
        /// </summary>
        [Fact]
        public void ScontoMaggiorazioneTest()
        {
            // TODO unit test for the property 'ScontoMaggiorazione'
        }

        /// <summary>
        /// Test the property 'ImportoTotaleDocumento'
        /// </summary>
        [Fact]
        public void ImportoTotaleDocumentoTest()
        {
            // TODO unit test for the property 'ImportoTotaleDocumento'
        }

        /// <summary>
        /// Test the property 'Arrotondamento'
        /// </summary>
        [Fact]
        public void ArrotondamentoTest()
        {
            // TODO unit test for the property 'Arrotondamento'
        }

        /// <summary>
        /// Test the property 'Causale'
        /// </summary>
        [Fact]
        public void CausaleTest()
        {
            // TODO unit test for the property 'Causale'
        }

        /// <summary>
        /// Test the property 'Art73'
        /// </summary>
        [Fact]
        public void Art73Test()
        {
            // TODO unit test for the property 'Art73'
        }
    }
}
