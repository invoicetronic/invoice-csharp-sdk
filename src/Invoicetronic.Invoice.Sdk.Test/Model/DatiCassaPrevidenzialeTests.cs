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
    ///  Class for testing DatiCassaPrevidenziale
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiCassaPrevidenzialeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiCassaPrevidenziale
        //private DatiCassaPrevidenziale instance;

        public DatiCassaPrevidenzialeTests()
        {
            // TODO uncomment below to create an instance of DatiCassaPrevidenziale
            //instance = new DatiCassaPrevidenziale();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiCassaPrevidenziale
        /// </summary>
        [Fact]
        public void DatiCassaPrevidenzialeInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiCassaPrevidenziale
            //Assert.IsType<DatiCassaPrevidenziale>(instance);
        }

        /// <summary>
        /// Test the property 'TipoCassa'
        /// </summary>
        [Fact]
        public void TipoCassaTest()
        {
            // TODO unit test for the property 'TipoCassa'
        }

        /// <summary>
        /// Test the property 'AlCassa'
        /// </summary>
        [Fact]
        public void AlCassaTest()
        {
            // TODO unit test for the property 'AlCassa'
        }

        /// <summary>
        /// Test the property 'ImportoContributoCassa'
        /// </summary>
        [Fact]
        public void ImportoContributoCassaTest()
        {
            // TODO unit test for the property 'ImportoContributoCassa'
        }

        /// <summary>
        /// Test the property 'ImponibileCassa'
        /// </summary>
        [Fact]
        public void ImponibileCassaTest()
        {
            // TODO unit test for the property 'ImponibileCassa'
        }

        /// <summary>
        /// Test the property 'AliquotaIva'
        /// </summary>
        [Fact]
        public void AliquotaIvaTest()
        {
            // TODO unit test for the property 'AliquotaIva'
        }

        /// <summary>
        /// Test the property 'Ritenuta'
        /// </summary>
        [Fact]
        public void RitenutaTest()
        {
            // TODO unit test for the property 'Ritenuta'
        }

        /// <summary>
        /// Test the property 'Natura'
        /// </summary>
        [Fact]
        public void NaturaTest()
        {
            // TODO unit test for the property 'Natura'
        }

        /// <summary>
        /// Test the property 'RiferimentoAmministrazione'
        /// </summary>
        [Fact]
        public void RiferimentoAmministrazioneTest()
        {
            // TODO unit test for the property 'RiferimentoAmministrazione'
        }
    }
}
