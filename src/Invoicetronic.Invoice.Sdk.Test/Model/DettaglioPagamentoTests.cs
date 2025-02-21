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
    ///  Class for testing DettaglioPagamento
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DettaglioPagamentoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DettaglioPagamento
        //private DettaglioPagamento instance;

        public DettaglioPagamentoTests()
        {
            // TODO uncomment below to create an instance of DettaglioPagamento
            //instance = new DettaglioPagamento();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DettaglioPagamento
        /// </summary>
        [Fact]
        public void DettaglioPagamentoInstanceTest()
        {
            // TODO uncomment below to test "IsType" DettaglioPagamento
            //Assert.IsType<DettaglioPagamento>(instance);
        }

        /// <summary>
        /// Test the property 'Beneficiario'
        /// </summary>
        [Fact]
        public void BeneficiarioTest()
        {
            // TODO unit test for the property 'Beneficiario'
        }

        /// <summary>
        /// Test the property 'ModalitaPagamento'
        /// </summary>
        [Fact]
        public void ModalitaPagamentoTest()
        {
            // TODO unit test for the property 'ModalitaPagamento'
        }

        /// <summary>
        /// Test the property 'DataRiferimentoTerminiPagamento'
        /// </summary>
        [Fact]
        public void DataRiferimentoTerminiPagamentoTest()
        {
            // TODO unit test for the property 'DataRiferimentoTerminiPagamento'
        }

        /// <summary>
        /// Test the property 'GiorniTerminiPagamento'
        /// </summary>
        [Fact]
        public void GiorniTerminiPagamentoTest()
        {
            // TODO unit test for the property 'GiorniTerminiPagamento'
        }

        /// <summary>
        /// Test the property 'DataScadenzaPagamento'
        /// </summary>
        [Fact]
        public void DataScadenzaPagamentoTest()
        {
            // TODO unit test for the property 'DataScadenzaPagamento'
        }

        /// <summary>
        /// Test the property 'ImportoPagamento'
        /// </summary>
        [Fact]
        public void ImportoPagamentoTest()
        {
            // TODO unit test for the property 'ImportoPagamento'
        }

        /// <summary>
        /// Test the property 'CodUfficioPostale'
        /// </summary>
        [Fact]
        public void CodUfficioPostaleTest()
        {
            // TODO unit test for the property 'CodUfficioPostale'
        }

        /// <summary>
        /// Test the property 'CognomeQuietanzante'
        /// </summary>
        [Fact]
        public void CognomeQuietanzanteTest()
        {
            // TODO unit test for the property 'CognomeQuietanzante'
        }

        /// <summary>
        /// Test the property 'NomeQuietanzante'
        /// </summary>
        [Fact]
        public void NomeQuietanzanteTest()
        {
            // TODO unit test for the property 'NomeQuietanzante'
        }

        /// <summary>
        /// Test the property 'CfQuietanzante'
        /// </summary>
        [Fact]
        public void CfQuietanzanteTest()
        {
            // TODO unit test for the property 'CfQuietanzante'
        }

        /// <summary>
        /// Test the property 'TitoloQuietanzante'
        /// </summary>
        [Fact]
        public void TitoloQuietanzanteTest()
        {
            // TODO unit test for the property 'TitoloQuietanzante'
        }

        /// <summary>
        /// Test the property 'IstitutoFinanziario'
        /// </summary>
        [Fact]
        public void IstitutoFinanziarioTest()
        {
            // TODO unit test for the property 'IstitutoFinanziario'
        }

        /// <summary>
        /// Test the property 'Iban'
        /// </summary>
        [Fact]
        public void IbanTest()
        {
            // TODO unit test for the property 'Iban'
        }

        /// <summary>
        /// Test the property 'Abi'
        /// </summary>
        [Fact]
        public void AbiTest()
        {
            // TODO unit test for the property 'Abi'
        }

        /// <summary>
        /// Test the property 'Cab'
        /// </summary>
        [Fact]
        public void CabTest()
        {
            // TODO unit test for the property 'Cab'
        }

        /// <summary>
        /// Test the property 'Bic'
        /// </summary>
        [Fact]
        public void BicTest()
        {
            // TODO unit test for the property 'Bic'
        }

        /// <summary>
        /// Test the property 'ScontoPagamentoAnticipato'
        /// </summary>
        [Fact]
        public void ScontoPagamentoAnticipatoTest()
        {
            // TODO unit test for the property 'ScontoPagamentoAnticipato'
        }

        /// <summary>
        /// Test the property 'DataLimitePagamentoAnticipato'
        /// </summary>
        [Fact]
        public void DataLimitePagamentoAnticipatoTest()
        {
            // TODO unit test for the property 'DataLimitePagamentoAnticipato'
        }

        /// <summary>
        /// Test the property 'PenalitaPagamentiRitardati'
        /// </summary>
        [Fact]
        public void PenalitaPagamentiRitardatiTest()
        {
            // TODO unit test for the property 'PenalitaPagamentiRitardati'
        }

        /// <summary>
        /// Test the property 'DataDecorrenzaPenale'
        /// </summary>
        [Fact]
        public void DataDecorrenzaPenaleTest()
        {
            // TODO unit test for the property 'DataDecorrenzaPenale'
        }

        /// <summary>
        /// Test the property 'CodicePagamento'
        /// </summary>
        [Fact]
        public void CodicePagamentoTest()
        {
            // TODO unit test for the property 'CodicePagamento'
        }
    }
}
