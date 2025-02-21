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
    ///  Class for testing Allegati
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AllegatiTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Allegati
        //private Allegati instance;

        public AllegatiTests()
        {
            // TODO uncomment below to create an instance of Allegati
            //instance = new Allegati();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Allegati
        /// </summary>
        [Fact]
        public void AllegatiInstanceTest()
        {
            // TODO uncomment below to test "IsType" Allegati
            //Assert.IsType<Allegati>(instance);
        }

        /// <summary>
        /// Test the property 'NomeAttachment'
        /// </summary>
        [Fact]
        public void NomeAttachmentTest()
        {
            // TODO unit test for the property 'NomeAttachment'
        }

        /// <summary>
        /// Test the property 'AlgoritmoCompressione'
        /// </summary>
        [Fact]
        public void AlgoritmoCompressioneTest()
        {
            // TODO unit test for the property 'AlgoritmoCompressione'
        }

        /// <summary>
        /// Test the property 'FormatoAttachment'
        /// </summary>
        [Fact]
        public void FormatoAttachmentTest()
        {
            // TODO unit test for the property 'FormatoAttachment'
        }

        /// <summary>
        /// Test the property 'DescrizioneAttachment'
        /// </summary>
        [Fact]
        public void DescrizioneAttachmentTest()
        {
            // TODO unit test for the property 'DescrizioneAttachment'
        }

        /// <summary>
        /// Test the property 'Attachment'
        /// </summary>
        [Fact]
        public void AttachmentTest()
        {
            // TODO unit test for the property 'Attachment'
        }
    }
}
