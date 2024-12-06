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
    ///  Class for testing DatiTrasporto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DatiTrasportoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DatiTrasporto
        //private DatiTrasporto instance;

        public DatiTrasportoTests()
        {
            // TODO uncomment below to create an instance of DatiTrasporto
            //instance = new DatiTrasporto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatiTrasporto
        /// </summary>
        [Fact]
        public void DatiTrasportoInstanceTest()
        {
            // TODO uncomment below to test "IsType" DatiTrasporto
            //Assert.IsType<DatiTrasporto>(instance);
        }

        /// <summary>
        /// Test the property 'DatiAnagraficiVettore'
        /// </summary>
        [Fact]
        public void DatiAnagraficiVettoreTest()
        {
            // TODO unit test for the property 'DatiAnagraficiVettore'
        }

        /// <summary>
        /// Test the property 'MezzoTrasporto'
        /// </summary>
        [Fact]
        public void MezzoTrasportoTest()
        {
            // TODO unit test for the property 'MezzoTrasporto'
        }

        /// <summary>
        /// Test the property 'CausaleTrasporto'
        /// </summary>
        [Fact]
        public void CausaleTrasportoTest()
        {
            // TODO unit test for the property 'CausaleTrasporto'
        }

        /// <summary>
        /// Test the property 'NumeroColli'
        /// </summary>
        [Fact]
        public void NumeroColliTest()
        {
            // TODO unit test for the property 'NumeroColli'
        }

        /// <summary>
        /// Test the property 'Descrizione'
        /// </summary>
        [Fact]
        public void DescrizioneTest()
        {
            // TODO unit test for the property 'Descrizione'
        }

        /// <summary>
        /// Test the property 'UnitaMisuraPeso'
        /// </summary>
        [Fact]
        public void UnitaMisuraPesoTest()
        {
            // TODO unit test for the property 'UnitaMisuraPeso'
        }

        /// <summary>
        /// Test the property 'PesoLordo'
        /// </summary>
        [Fact]
        public void PesoLordoTest()
        {
            // TODO unit test for the property 'PesoLordo'
        }

        /// <summary>
        /// Test the property 'PesoNetto'
        /// </summary>
        [Fact]
        public void PesoNettoTest()
        {
            // TODO unit test for the property 'PesoNetto'
        }

        /// <summary>
        /// Test the property 'DataOraRitiro'
        /// </summary>
        [Fact]
        public void DataOraRitiroTest()
        {
            // TODO unit test for the property 'DataOraRitiro'
        }

        /// <summary>
        /// Test the property 'DataInizioTrasporto'
        /// </summary>
        [Fact]
        public void DataInizioTrasportoTest()
        {
            // TODO unit test for the property 'DataInizioTrasporto'
        }

        /// <summary>
        /// Test the property 'TipoResa'
        /// </summary>
        [Fact]
        public void TipoResaTest()
        {
            // TODO unit test for the property 'TipoResa'
        }

        /// <summary>
        /// Test the property 'IndirizzoResa'
        /// </summary>
        [Fact]
        public void IndirizzoResaTest()
        {
            // TODO unit test for the property 'IndirizzoResa'
        }

        /// <summary>
        /// Test the property 'DataOraConsegna'
        /// </summary>
        [Fact]
        public void DataOraConsegnaTest()
        {
            // TODO unit test for the property 'DataOraConsegna'
        }
    }
}
