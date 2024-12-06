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
    ///  Class for testing DatiRicezione
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiRicezioneTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiRicezione
        //private DatiRicezione instance;

        public DatiRicezioneTests()
        {
            // TODO uncomment below to create an instance of DatiRicezione
            //instance = new DatiRicezione();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiRicezione
        /// </summary>
        [Fact]
        public void DatiRicezioneInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiRicezione
            //Assert.IsType<DatiRicezione>(instance);
        }

        /// <summary>
        /// Test the property 'RiferimentoNumeroLinea'
        /// </summary>
        [Fact]
        public void RiferimentoNumeroLineaTest()
        {
            // TODO unit test for the property 'RiferimentoNumeroLinea'
        }

        /// <summary>
        /// Test the property 'IdDocumento'
        /// </summary>
        [Fact]
        public void IdDocumentoTest()
        {
            // TODO unit test for the property 'IdDocumento'
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
        /// Test the property 'NumItem'
        /// </summary>
        [Fact]
        public void NumItemTest()
        {
            // TODO unit test for the property 'NumItem'
        }

        /// <summary>
        /// Test the property 'CodiceCommessaConvenzione'
        /// </summary>
        [Fact]
        public void CodiceCommessaConvenzioneTest()
        {
            // TODO unit test for the property 'CodiceCommessaConvenzione'
        }

        /// <summary>
        /// Test the property 'CodiceCup'
        /// </summary>
        [Fact]
        public void CodiceCupTest()
        {
            // TODO unit test for the property 'CodiceCup'
        }

        /// <summary>
        /// Test the property 'CodiceCig'
        /// </summary>
        [Fact]
        public void CodiceCigTest()
        {
            // TODO unit test for the property 'CodiceCig'
        }
    }
}
