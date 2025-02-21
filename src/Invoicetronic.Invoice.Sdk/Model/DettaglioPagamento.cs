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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Invoicetronic.Invoice.Sdk.Client.OpenAPIDateConverter;

namespace Invoicetronic.Invoice.Sdk.Model
{
    /// <summary>
    /// DettaglioPagamento
    /// </summary>
    [DataContract(Name = "DettaglioPagamento")]
    public partial class DettaglioPagamento : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DettaglioPagamento" /> class.
        /// </summary>
        /// <param name="beneficiario">beneficiario.</param>
        /// <param name="modalitaPagamento">modalitaPagamento.</param>
        /// <param name="dataRiferimentoTerminiPagamento">dataRiferimentoTerminiPagamento.</param>
        /// <param name="giorniTerminiPagamento">giorniTerminiPagamento.</param>
        /// <param name="dataScadenzaPagamento">dataScadenzaPagamento.</param>
        /// <param name="importoPagamento">importoPagamento.</param>
        /// <param name="codUfficioPostale">codUfficioPostale.</param>
        /// <param name="cognomeQuietanzante">cognomeQuietanzante.</param>
        /// <param name="nomeQuietanzante">nomeQuietanzante.</param>
        /// <param name="cfQuietanzante">cfQuietanzante.</param>
        /// <param name="titoloQuietanzante">titoloQuietanzante.</param>
        /// <param name="istitutoFinanziario">istitutoFinanziario.</param>
        /// <param name="iban">iban.</param>
        /// <param name="abi">abi.</param>
        /// <param name="cab">cab.</param>
        /// <param name="bic">bic.</param>
        /// <param name="scontoPagamentoAnticipato">scontoPagamentoAnticipato.</param>
        /// <param name="dataLimitePagamentoAnticipato">dataLimitePagamentoAnticipato.</param>
        /// <param name="penalitaPagamentiRitardati">penalitaPagamentiRitardati.</param>
        /// <param name="dataDecorrenzaPenale">dataDecorrenzaPenale.</param>
        /// <param name="codicePagamento">codicePagamento.</param>
        public DettaglioPagamento(string beneficiario = default(string), string modalitaPagamento = default(string), DateTime? dataRiferimentoTerminiPagamento = default(DateTime?), int? giorniTerminiPagamento = default(int?), DateTime? dataScadenzaPagamento = default(DateTime?), double importoPagamento = default(double), string codUfficioPostale = default(string), string cognomeQuietanzante = default(string), string nomeQuietanzante = default(string), string cfQuietanzante = default(string), string titoloQuietanzante = default(string), string istitutoFinanziario = default(string), string iban = default(string), string abi = default(string), string cab = default(string), string bic = default(string), double? scontoPagamentoAnticipato = default(double?), DateTime? dataLimitePagamentoAnticipato = default(DateTime?), double? penalitaPagamentiRitardati = default(double?), DateTime? dataDecorrenzaPenale = default(DateTime?), string codicePagamento = default(string))
        {
            this.Beneficiario = beneficiario;
            this.ModalitaPagamento = modalitaPagamento;
            this.DataRiferimentoTerminiPagamento = dataRiferimentoTerminiPagamento;
            this.GiorniTerminiPagamento = giorniTerminiPagamento;
            this.DataScadenzaPagamento = dataScadenzaPagamento;
            this.ImportoPagamento = importoPagamento;
            this.CodUfficioPostale = codUfficioPostale;
            this.CognomeQuietanzante = cognomeQuietanzante;
            this.NomeQuietanzante = nomeQuietanzante;
            this.CfQuietanzante = cfQuietanzante;
            this.TitoloQuietanzante = titoloQuietanzante;
            this.IstitutoFinanziario = istitutoFinanziario;
            this.Iban = iban;
            this.Abi = abi;
            this.Cab = cab;
            this.Bic = bic;
            this.ScontoPagamentoAnticipato = scontoPagamentoAnticipato;
            this.DataLimitePagamentoAnticipato = dataLimitePagamentoAnticipato;
            this.PenalitaPagamentiRitardati = penalitaPagamentiRitardati;
            this.DataDecorrenzaPenale = dataDecorrenzaPenale;
            this.CodicePagamento = codicePagamento;
        }

        /// <summary>
        /// Gets or Sets Beneficiario
        /// </summary>
        [DataMember(Name = "beneficiario", EmitDefaultValue = true)]
        public string Beneficiario { get; set; }

        /// <summary>
        /// Gets or Sets ModalitaPagamento
        /// </summary>
        [DataMember(Name = "modalita_pagamento", EmitDefaultValue = true)]
        public string ModalitaPagamento { get; set; }

        /// <summary>
        /// Gets or Sets DataRiferimentoTerminiPagamento
        /// </summary>
        [DataMember(Name = "data_riferimento_termini_pagamento", EmitDefaultValue = true)]
        public DateTime? DataRiferimentoTerminiPagamento { get; set; }

        /// <summary>
        /// Gets or Sets GiorniTerminiPagamento
        /// </summary>
        [DataMember(Name = "giorni_termini_pagamento", EmitDefaultValue = true)]
        public int? GiorniTerminiPagamento { get; set; }

        /// <summary>
        /// Gets or Sets DataScadenzaPagamento
        /// </summary>
        [DataMember(Name = "data_scadenza_pagamento", EmitDefaultValue = true)]
        public DateTime? DataScadenzaPagamento { get; set; }

        /// <summary>
        /// Gets or Sets ImportoPagamento
        /// </summary>
        [DataMember(Name = "importo_pagamento", EmitDefaultValue = false)]
        public double ImportoPagamento { get; set; }

        /// <summary>
        /// Gets or Sets CodUfficioPostale
        /// </summary>
        [DataMember(Name = "cod_ufficio_postale", EmitDefaultValue = true)]
        public string CodUfficioPostale { get; set; }

        /// <summary>
        /// Gets or Sets CognomeQuietanzante
        /// </summary>
        [DataMember(Name = "cognome_quietanzante", EmitDefaultValue = true)]
        public string CognomeQuietanzante { get; set; }

        /// <summary>
        /// Gets or Sets NomeQuietanzante
        /// </summary>
        [DataMember(Name = "nome_quietanzante", EmitDefaultValue = true)]
        public string NomeQuietanzante { get; set; }

        /// <summary>
        /// Gets or Sets CfQuietanzante
        /// </summary>
        [DataMember(Name = "cf_quietanzante", EmitDefaultValue = true)]
        public string CfQuietanzante { get; set; }

        /// <summary>
        /// Gets or Sets TitoloQuietanzante
        /// </summary>
        [DataMember(Name = "titolo_quietanzante", EmitDefaultValue = true)]
        public string TitoloQuietanzante { get; set; }

        /// <summary>
        /// Gets or Sets IstitutoFinanziario
        /// </summary>
        [DataMember(Name = "istituto_finanziario", EmitDefaultValue = true)]
        public string IstitutoFinanziario { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = true)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Abi
        /// </summary>
        [DataMember(Name = "abi", EmitDefaultValue = true)]
        public string Abi { get; set; }

        /// <summary>
        /// Gets or Sets Cab
        /// </summary>
        [DataMember(Name = "cab", EmitDefaultValue = true)]
        public string Cab { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        [DataMember(Name = "bic", EmitDefaultValue = true)]
        public string Bic { get; set; }

        /// <summary>
        /// Gets or Sets ScontoPagamentoAnticipato
        /// </summary>
        [DataMember(Name = "sconto_pagamento_anticipato", EmitDefaultValue = true)]
        public double? ScontoPagamentoAnticipato { get; set; }

        /// <summary>
        /// Gets or Sets DataLimitePagamentoAnticipato
        /// </summary>
        [DataMember(Name = "data_limite_pagamento_anticipato", EmitDefaultValue = true)]
        public DateTime? DataLimitePagamentoAnticipato { get; set; }

        /// <summary>
        /// Gets or Sets PenalitaPagamentiRitardati
        /// </summary>
        [DataMember(Name = "penalita_pagamenti_ritardati", EmitDefaultValue = true)]
        public double? PenalitaPagamentiRitardati { get; set; }

        /// <summary>
        /// Gets or Sets DataDecorrenzaPenale
        /// </summary>
        [DataMember(Name = "data_decorrenza_penale", EmitDefaultValue = true)]
        public DateTime? DataDecorrenzaPenale { get; set; }

        /// <summary>
        /// Gets or Sets CodicePagamento
        /// </summary>
        [DataMember(Name = "codice_pagamento", EmitDefaultValue = true)]
        public string CodicePagamento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DettaglioPagamento {\n");
            sb.Append("  Beneficiario: ").Append(Beneficiario).Append("\n");
            sb.Append("  ModalitaPagamento: ").Append(ModalitaPagamento).Append("\n");
            sb.Append("  DataRiferimentoTerminiPagamento: ").Append(DataRiferimentoTerminiPagamento).Append("\n");
            sb.Append("  GiorniTerminiPagamento: ").Append(GiorniTerminiPagamento).Append("\n");
            sb.Append("  DataScadenzaPagamento: ").Append(DataScadenzaPagamento).Append("\n");
            sb.Append("  ImportoPagamento: ").Append(ImportoPagamento).Append("\n");
            sb.Append("  CodUfficioPostale: ").Append(CodUfficioPostale).Append("\n");
            sb.Append("  CognomeQuietanzante: ").Append(CognomeQuietanzante).Append("\n");
            sb.Append("  NomeQuietanzante: ").Append(NomeQuietanzante).Append("\n");
            sb.Append("  CfQuietanzante: ").Append(CfQuietanzante).Append("\n");
            sb.Append("  TitoloQuietanzante: ").Append(TitoloQuietanzante).Append("\n");
            sb.Append("  IstitutoFinanziario: ").Append(IstitutoFinanziario).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Abi: ").Append(Abi).Append("\n");
            sb.Append("  Cab: ").Append(Cab).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  ScontoPagamentoAnticipato: ").Append(ScontoPagamentoAnticipato).Append("\n");
            sb.Append("  DataLimitePagamentoAnticipato: ").Append(DataLimitePagamentoAnticipato).Append("\n");
            sb.Append("  PenalitaPagamentiRitardati: ").Append(PenalitaPagamentiRitardati).Append("\n");
            sb.Append("  DataDecorrenzaPenale: ").Append(DataDecorrenzaPenale).Append("\n");
            sb.Append("  CodicePagamento: ").Append(CodicePagamento).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
