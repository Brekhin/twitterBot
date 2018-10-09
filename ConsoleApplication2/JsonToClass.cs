using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{

        public class PaymentDocuments
        {
            public object attachment { get; set; }
        }

        public class ReceiptDocuments
        {
            public object attachment { get; set; }
        }

        public class Country
        {
            public string countryCode { get; set; }
            public string countryFullName { get; set; }
        }

        public class OKPD
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class OKPD2
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class ProductsCountry
        {
            public Country country { get; set; }
            public OKPD OKPD { get; set; }
            public string productName { get; set; }
            public OKPD2 OKPD2 { get; set; }
            public string sid { get; set; }
        }

        public class ProductsCountries
        {
            public ProductsCountry productsCountry { get; set; }
        }

        public class OldStage
        {
            public string month { get; set; }
            public string year { get; set; }
        }

        public class Stage
        {
            public DateTime endDate { get; set; }
            public string month { get; set; }
            public string year { get; set; }
            public OldStage oldStage { get; set; }
        }

        public class Executions
        {
            public object execution { get; set; }
            public ProductsCountries productsCountries { get; set; }
            public string ordinalNumber { get; set; }
            public Stage stage { get; set; }
            public string finalStageExecution { get; set; }
        }

        public class PrintForm
        {
            public string url { get; set; }
            public string docRegNumber { get; set; }
        }

        public class Reason
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class DocTermination
        {
            public string code { get; set; }
            public string documentDate { get; set; }
            public string name { get; set; }
            public string documentNum { get; set; }
        }

        public class Termination
        {
            public string paid { get; set; }
            public string terminationDate { get; set; }
            public string reasonInfo { get; set; }
            public Reason reason { get; set; }
            public DocTermination docTermination { get; set; }
            public DateTime? decisionDate { get; set; }
        }

        public class Attachment
        {
            public string publishedContentId { get; set; }
            public string url { get; set; }
            public string docRegNumber { get; set; }
            public string docDescription { get; set; }
            public string fileName { get; set; }
        }

        public class TerminationDocuments
        {
            public Attachment attachment { get; set; }
        }

        public class Attachment2
        {
            public string publishedContentId { get; set; }
            public string url { get; set; }
            public string docRegNumber { get; set; }
            public string docDescription { get; set; }
            public string fileName { get; set; }
        }

        public class ProductOriginDocuments
        {
            public Attachment2 attachment { get; set; }
        }

        public class ContractProcedure
        {
            public PaymentDocuments paymentDocuments { get; set; }
            public ReceiptDocuments receiptDocuments { get; set; }
            public DateTime publishDate { get; set; }
            public Executions executions { get; set; }
            public int versionNumber { get; set; }
            public PrintForm printForm { get; set; }
            public string id { get; set; }
            public string schemeVersion { get; set; }
        public string okpd2okved2 { get; set; }
        public Termination termination { get; set; }
        public TerminationDocuments terminationDocuments { get; set; }
        public string modificationReason { get; set; }
        public ProductOriginDocuments productOriginDocuments { get; set; }
    }

    public class Attachment3
    {
        public string url { get; set; }
        public string docDescription { get; set; }
        public string fileName { get; set; }
        public string guid { get; set; }
    }

    public class Attachments
    {
        public List<Attachment3> attachment { get; set; }
    }

    public class Scan
    {
        public string url { get; set; }
        public string docDescription { get; set; }
        public string fileName { get; set; }
        public string sid { get; set; }
    }

    public class SingleCustomerReason
    {
        public string code { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class OosOrder
    {
        public string notificationNumber { get; set; }
        public string lotNumber { get; set; }
        public string placing { get; set; }
    }

    public class FcsOrder
    {
        public string notificationNumber { get; set; }
        public string purchaseCode { get; set; }
        public string placing { get; set; }
        public string lotNumber { get; set; }
    }

    public class Other
    {
        public string notificationNumber { get; set; }
        public string placing { get; set; }
    }

    public class Foundation
    {
        public OosOrder oosOrder { get; set; }
        public string singleCustomer { get; set; }
        public FcsOrder fcsOrder { get; set; }
        public Other other { get; set; }
    }

    public class Execution
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string month { get; set; }
        public string year { get; set; }
    }

    public class Customer
    {
        public string kpp { get; set; }
        public string regNum { get; set; }
        public string fullName { get; set; }
        public string inn { get; set; }
        public string postalAddress { get; set; }
        public string tofk { get; set; }
        public string shortName { get; set; }
        public string OKATO { get; set; }
        public string OGRN { get; set; }
        public string legalAddress { get; set; }
        public string iko { get; set; }
    }

    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string digitalCode { get; set; }
    }

    public class LegalForm
    {
        public string code { get; set; }
        public string singularName { get; set; }
    }

    public class ContactInfo
    {
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
    }

    public class Country2
    {
        public string countryCode { get; set; }
        public string countryFullName { get; set; }
    }

    public class Supplier
    {
        public string kpp { get; set; }
        public string factualAddress { get; set; }
        public string organizationName { get; set; }
        public LegalForm legalForm { get; set; }
        public string inn { get; set; }
        public string participantType { get; set; }
        public ContactInfo contactInfo { get; set; }
        public Country2 country { get; set; }
        public bool? isIP { get; set; }
        public string postAddress { get; set; }
        public string organizationForm { get; set; }
        public string contactFax { get; set; }
        public string type { get; set; }
        public string ogrn { get; set; }
    }

    public class BudgetLevel
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Payments
    {
        public string KBK { get; set; }
        public string paymentYear { get; set; }
        public string paymentMonth { get; set; }
        public string paymentSum { get; set; }
        public string paymentSumRUR { get; set; }
    }

    public class Stage2
    {
        public DateTime endDate { get; set; }
        public Payments payments { get; set; }
    }

    public class BudgetFunds
    {
        public List<Stage2> stages { get; set; }
        public string fundsBudgetLevel { get; set; }
    }

    public class Payments2
    {
        public string paymentSum { get; set; }
        public string paymentYear { get; set; }
        public string paymentMonth { get; set; }
        public string KOSGU { get; set; }
    }

    public class Stage3
    {
        public DateTime endDate { get; set; }
        public Payments2 payments { get; set; }
    }

    public class ExtrabudgetFunds
    {
        public List<Stage3> stages { get; set; }
    }

    public class Budget
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Budgetary
    {
        public string KBK { get; set; }
        public double price { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string substageYear { get; set; }
        public string substageMonth { get; set; }
    }

    public class Extrabudget
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Extrabudgetary
    {
        public double price { get; set; }
        public string month { get; set; }
        public string KOSGU { get; set; }
        public string year { get; set; }
    }

    public class Finances
    {
        public BudgetLevel budgetLevel { get; set; }
        public BudgetFunds budgetFunds { get; set; }
        public ExtrabudgetFunds extrabudgetFunds { get; set; }
        public Budget budget { get; set; }
        public string financeSource { get; set; }
        public List<Budgetary> budgetary { get; set; }
        public Extrabudget extrabudget { get; set; }
        public List<Extrabudgetary> extrabudgetary { get; set; }
    }

    public class OKPD3
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class OKEI
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class OKDP
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class OKPD22
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class DeliveryPlace
    {
        public string region { get; set; }
        public string state { get; set; }
        public string address { get; set; }
    }

    public class Product
    {
        public string name { get; set; }
        public OKPD3 OKPD { get; set; }
        public OKEI OKEI { get; set; }
        public double sum { get; set; }
        public string sid { get; set; }
        public double price { get; set; }
        public string quantity { get; set; }
        public OKDP OKDP { get; set; }
        public OKPD22 OKPD2 { get; set; }
        public DeliveryPlace deliveryPlace { get; set; }
        public string ordinalNumber { get; set; }
    }

    public class EconomicSector
    {
        public string code { get; set; }
        public string name { get; set; }
        public string title { get; set; }
    }

    public class Lot
    {
        public string guid { get; set; }
        public string subject { get; set; }
    }

    public class PurchaseInfo
    {
        public string purchaseNoticeNumber { get; set; }
        public string purchaseCodeName { get; set; }
        public string name { get; set; }
        public string purchaseMethodCode { get; set; }
    }

    public class MainInfo
    {
        public string kpp { get; set; }
        public string shortName { get; set; }
        public string okato { get; set; }
        public string ogrn { get; set; }
        public string okpo { get; set; }
        public string phone { get; set; }
        public string inn { get; set; }
        public string postalAddress { get; set; }
        public string legalAddress { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
    }

    public class Placer
    {
        public MainInfo mainInfo { get; set; }
    }

    public class Modification
    {
        public string @base { get; set; }
        public string type { get; set; }
        public string description { get; set; }
    }

    public class PriceChangeReason
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Datum
    {
        public ContractProcedure contractProcedure { get; set; }
        public string documentBase { get; set; }
        public Attachments attachments { get; set; }
        public List<Scan> scan { get; set; }
        public string number { get; set; }
        public string currentContractStage { get; set; }
        public string id { get; set; }
        public string fileVersion { get; set; }
        public string placing { get; set; }
        public string schemaVersion { get; set; }
        public string regionCode { get; set; }
        public string contractUrl { get; set; }
        public SingleCustomerReason singleCustomerReason { get; set; }
        public DateTime signDate { get; set; }
        public double price { get; set; }
        public string placingWayCode { get; set; }
        public Foundation foundation { get; set; }
        public string fz { get; set; }
        public string protocolDate { get; set; }
        public DateTime publishDate { get; set; }
        public string regNum { get; set; }
        public int versionNumber { get; set; }
        public string currentContractStage_raw { get; set; }
        public Execution execution { get; set; }
        public Customer customer { get; set; }
        public Currency currency { get; set; }
        public List<Supplier> suppliers { get; set; }
        public double loadId { get; set; }
        public Finances finances { get; set; }
        public string mongo_id { get; set; }
        public List<Product> products { get; set; }
        public string printFormUrl { get; set; }
        public List<EconomicSector> economic_sectors { get; set; }
        public List<string> misuses { get; set; }
        public string deliveryPlaceIndication { get; set; }
        public string contractCreateDate { get; set; }
        public string fulfillmentDate { get; set; }
        public Lot lot { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public PurchaseInfo purchaseInfo { get; set; }
        public string name { get; set; }
        public Placer placer { get; set; }
        public DateTime createDateTime { get; set; }
        public Modification modification { get; set; }
        public PriceChangeReason priceChangeReason { get; set; }
    }

    public class Contracts
    {
        public int total { get; set; }
        public List<Datum> data { get; set; }
        public int page { get; set; }
        public int perpage { get; set; }
    }

    public class RootObject
    {
        public Contracts contracts { get; set; }
    }

}