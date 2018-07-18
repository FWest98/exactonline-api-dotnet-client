using System.Collections.Generic;

using ExactOnline.Client.Models;
using ExactOnline.Client.Models.Accountancy;
using ExactOnline.Client.Models.Activities;
using ExactOnline.Client.Models.Assets;
using ExactOnline.Client.Models.Budget;
using ExactOnline.Client.Models.Cashflow;
using ExactOnline.Client.Models.CRM;
using ExactOnline.Client.Models.Current;
using ExactOnline.Client.Models.Documents;
using ExactOnline.Client.Models.Financial;
using ExactOnline.Client.Models.FinancialTransaction;
using ExactOnline.Client.Models.General;
using ExactOnline.Client.Models.GeneralJournalEntry;
using ExactOnline.Client.Models.HRM;
using ExactOnline.Client.Models.Inventory;
using ExactOnline.Client.Models.Logistics;
using ExactOnline.Client.Models.Mailbox;
using ExactOnline.Client.Models.Manufacturing;
using ExactOnline.Client.Models.OpeningBalance;
using ExactOnline.Client.Models.Payroll;
using ExactOnline.Client.Models.Project;
using ExactOnline.Client.Models.Purchase;
using ExactOnline.Client.Models.PurchaseEntry;
using ExactOnline.Client.Models.PurchaseOrder;
using ExactOnline.Client.Models.Sales;
using ExactOnline.Client.Models.SalesEntry;
using ExactOnline.Client.Models.SalesInvoice;
using ExactOnline.Client.Models.SalesOrder;
using ExactOnline.Client.Models.Subscription;
using ExactOnline.Client.Models.SystemBase;
using ExactOnline.Client.Models.Users;
using ExactOnline.Client.Models.VAT;
using ExactOnline.Client.Models.Webhooks;
using ExactOnline.Client.Models.Workflow;

using Newtonsoft.Json;

using Division = ExactOnline.Client.Models.HRM.Division;
using Document = ExactOnline.Client.Models.CRM.Document;
using TimeTransaction = ExactOnline.Client.Models.Project.TimeTransaction;

public class Services
{
    [JsonProperty(PropertyName = "services")]
    public Dictionary<string, string> ServicesDictionary = new Dictionary<string, string>();

    public Services()
    {
        this.ServicesDictionary.Add(typeof(AccountInvolvedAccount).FullName, "Accountancy/AccountInvolvedAccounts");
        this.ServicesDictionary.Add(typeof(AccountOwner).FullName, "Accountancy/AccountOwners");
        this.ServicesDictionary.Add(typeof(InvolvedUser).FullName, "Accountancy/InvolvedUsers");
        this.ServicesDictionary.Add(typeof(InvolvedUserRole).FullName, "Accountancy/InvolvedUserRoles");
        this.ServicesDictionary.Add(typeof(SolutionLink).FullName, "Accountancy/SolutionLinks");
        this.ServicesDictionary.Add(typeof(TaskType).FullName, "Accountancy/TaskTypes");
        this.ServicesDictionary.Add(typeof(CommunicationNote).FullName, "Activities/CommunicationNotes");
        this.ServicesDictionary.Add(typeof(Complaint).FullName, "Activities/Complaints");
        this.ServicesDictionary.Add(typeof(Event).FullName, "Activities/Events");
        this.ServicesDictionary.Add(typeof(ServiceRequest).FullName, "Activities/ServiceRequests");
        this.ServicesDictionary.Add(typeof(Task).FullName, "Activities/Tasks");
        this.ServicesDictionary.Add(typeof(Asset).FullName, "Assets/Assets");
        this.ServicesDictionary.Add(typeof(AssetGroup).FullName, "Assets/AssetGroups");
        this.ServicesDictionary.Add(typeof(DepreciationMethod).FullName, "Assets/DepreciationMethods");
        this.ServicesDictionary.Add(typeof(Budget).FullName, "Budget/Budgets");
        this.ServicesDictionary.Add(typeof(ExactOnline.Client.Models.Bulk.Document).FullName, "Bulk/Documents/Documents");
        this.ServicesDictionary.Add(typeof(ExactOnline.Client.Models.Bulk.DocumentAttachment).FullName, "Bulk/Documents/DocumentAttachments");
        this.ServicesDictionary.Add(typeof(ExactOnline.Client.Models.Bulk.FinancialTransactionLine).FullName, "Bulk/Financial/TransactionLines");
        this.ServicesDictionary.Add(typeof(Bank).FullName, "Cashflow/Banks");
        this.ServicesDictionary.Add(typeof(DirectDebitMandate).FullName, "Cashflow/DirectDebitMandates");
        this.ServicesDictionary.Add(typeof(Payment).FullName, "Cashflow/Payments");
        this.ServicesDictionary.Add(typeof(PaymentCondition).FullName, "Cashflow/PaymentConditions");
        this.ServicesDictionary.Add(typeof(PaymentID).FullName, "Cashflow/PaymentIDs");
        this.ServicesDictionary.Add(typeof(ProcessPayment).FullName, "Cashflow/ProcessPayments");
        this.ServicesDictionary.Add(typeof(Receivable).FullName, "Cashflow/Receivables");
        this.ServicesDictionary.Add(typeof(AcceptQuotation).FullName, "CRM/AcceptQuotation");
        this.ServicesDictionary.Add(typeof(Account).FullName, "CRM/Accounts");
        this.ServicesDictionary.Add(typeof(AccountClass).FullName, "CRM/AccountClasses");
        this.ServicesDictionary.Add(typeof(AccountClassification).FullName, "CRM/AccountClassifications");
        this.ServicesDictionary.Add(typeof(AccountClassificationName).FullName, "CRM/AccountClassificationNames");
        this.ServicesDictionary.Add(typeof(Address).FullName, "CRM/Addresses");
        this.ServicesDictionary.Add(typeof(AddressState).FullName, "CRM/AddressStates");
        this.ServicesDictionary.Add(typeof(BankAccount).FullName, "CRM/BankAccounts");
        this.ServicesDictionary.Add(typeof(Contact).FullName, "CRM/Contacts");
        this.ServicesDictionary.Add(typeof(Document).FullName, "Read/CRM/Documents");
        this.ServicesDictionary.Add(typeof(DocumentsAttachment).FullName, "Read/CRM/DocumentsAttachments");
        this.ServicesDictionary.Add(typeof(Opportunity).FullName, "CRM/Opportunities");
        this.ServicesDictionary.Add(typeof(OpportunityContact).FullName, "Read/CRM/OpportunityContacts");
        this.ServicesDictionary.Add(typeof(PrintQuotation).FullName, "CRM/PrintQuotation");
        this.ServicesDictionary.Add(typeof(Quotation).FullName, "CRM/Quotations");
        this.ServicesDictionary.Add(typeof(QuotationLine).FullName, "CRM/QuotationLines");
        this.ServicesDictionary.Add(typeof(ReasonCode).FullName, "CRM/ReasonCodes");
        this.ServicesDictionary.Add(typeof(RejectQuotation).FullName, "CRM/RejectQuotation");
        this.ServicesDictionary.Add(typeof(ReopenQuotation).FullName, "CRM/ReopenQuotation");
        this.ServicesDictionary.Add(typeof(ReviewQuotation).FullName, "CRM/ReviewQuotation");
        this.ServicesDictionary.Add(typeof(Me).FullName, "Current/Me");
        this.ServicesDictionary.Add(typeof(Document).FullName, "Documents/Documents");
        this.ServicesDictionary.Add(typeof(DocumentAttachment).FullName, "Documents/DocumentAttachments");
        this.ServicesDictionary.Add(typeof(DocumentCategory).FullName, "Documents/DocumentCategories");
        this.ServicesDictionary.Add(typeof(DocumentFolder).FullName, "Documents/DocumentFolders");
        this.ServicesDictionary.Add(typeof(DocumentType).FullName, "Documents/DocumentTypes");
        this.ServicesDictionary.Add(typeof(DocumentTypeCategory).FullName, "Documents/DocumentTypeCategories");
        this.ServicesDictionary.Add(typeof(DocumentTypeFolder).FullName, "Documents/DocumentTypeFolders");
        this.ServicesDictionary.Add(typeof(AgingOverview).FullName, "Read/Financial/AgingOverview");
        this.ServicesDictionary.Add(typeof(AgingPayablesList).FullName, "Read/Financial/AgingPayablesList");
        this.ServicesDictionary.Add(typeof(AgingReceivablesList).FullName, "Read/Financial/AgingReceivablesList");
        this.ServicesDictionary.Add(typeof(ExchangeRate).FullName, "Financial/ExchangeRates");
        this.ServicesDictionary.Add(typeof(FinancialPeriod).FullName, "Financial/FinancialPeriods");
        this.ServicesDictionary.Add(typeof(GLAccount).FullName, "Financial/GLAccounts");
        this.ServicesDictionary.Add(typeof(GLClassification).FullName, "Financial/GLClassifications");
        this.ServicesDictionary.Add(typeof(GLScheme).FullName, "Financial/GLSchemes");
        this.ServicesDictionary.Add(typeof(GLTransactionType).FullName, "Financial/GLTransactionTypes");
        this.ServicesDictionary.Add(typeof(Journal).FullName, "Financial/Journals");
        this.ServicesDictionary.Add(typeof(JournalStatusList).FullName, "Read/Financial/JournalStatusList");
        this.ServicesDictionary.Add(typeof(OutstandingInvoicesOverview).FullName, "Read/Financial/OutstandingInvoicesOverview");
        this.ServicesDictionary.Add(typeof(PayablesList).FullName, "Read/Financial/PayablesList");
        this.ServicesDictionary.Add(typeof(ProfitLossOverview).FullName, "Read/Financial/ProfitLossOverview");
        this.ServicesDictionary.Add(typeof(ReceivablesList).FullName, "Read/Financial/ReceivablesList");
        this.ServicesDictionary.Add(typeof(ReportingBalance).FullName, "Financial/ReportingBalance");
        this.ServicesDictionary.Add(typeof(Return).FullName, "Read/Financial/Returns");
        this.ServicesDictionary.Add(typeof(RevenueList).FullName, "Read/Financial/RevenueList");
        this.ServicesDictionary.Add(typeof(BankEntry).FullName, "FinancialTransaction/BankEntries");
        this.ServicesDictionary.Add(typeof(BankEntryLine).FullName, "FinancialTransaction/BankEntryLines");
        this.ServicesDictionary.Add(typeof(CashEntry).FullName, "FinancialTransaction/CashEntries");
        this.ServicesDictionary.Add(typeof(CashEntryLine).FullName, "FinancialTransaction/CashEntryLines");
        this.ServicesDictionary.Add(typeof(Transaction).FullName, "FinancialTransaction/Transactions");
        this.ServicesDictionary.Add(typeof(TransactionLine).FullName, "FinancialTransaction/TransactionLines");
        this.ServicesDictionary.Add(typeof(Currency).FullName, "General/Currencies");
        this.ServicesDictionary.Add(typeof(GeneralJournalEntry).FullName, "GeneralJournalEntry/GeneralJournalEntries");
        this.ServicesDictionary.Add(typeof(GeneralJournalEntryLine).FullName, "GeneralJournalEntry/GeneralJournalEntryLines");
        this.ServicesDictionary.Add(typeof(AbsenceRegistration).FullName, "HRM/AbsenceRegistrations");
        this.ServicesDictionary.Add(typeof(AbsenceRegistrationTransaction).FullName, "HRM/AbsenceRegistrationTransactions");
        this.ServicesDictionary.Add(typeof(Costcenter).FullName, "HRM/Costcenters");
        this.ServicesDictionary.Add(typeof(Costunit).FullName, "HRM/Costunits");
        this.ServicesDictionary.Add(typeof(Department).FullName, "HRM/Departments");
        this.ServicesDictionary.Add(typeof(Division).FullName, "HRM/Divisions");
        this.ServicesDictionary.Add(typeof(DivisionClass).FullName, "HRM/DivisionClasses");
        this.ServicesDictionary.Add(typeof(DivisionClassName).FullName, "HRM/DivisionClassNames");
        this.ServicesDictionary.Add(typeof(DivisionClassValue).FullName, "HRM/DivisionClassValues");
        this.ServicesDictionary.Add(typeof(JobGroup).FullName, "HRM/JobGroups");
        this.ServicesDictionary.Add(typeof(JobTitle).FullName, "HRM/JobTitles");
        this.ServicesDictionary.Add(typeof(LeaveBuildUpRegistration).FullName, "HRM/LeaveBuildUpRegistrations");
        this.ServicesDictionary.Add(typeof(LeaveRegistration).FullName, "HRM/LeaveRegistrations");
        this.ServicesDictionary.Add(typeof(Schedule).FullName, "HRM/Schedules");
        this.ServicesDictionary.Add(typeof(AssemblyOrder).FullName, "Inventory/AssemblyOrders");
        this.ServicesDictionary.Add(typeof(BatchNumber).FullName, "Inventory/BatchNumbers");
        this.ServicesDictionary.Add(typeof(BatchQuantitiesPerLocation).FullName, "");
        this.ServicesDictionary.Add(typeof(BatchQuantitiesPerWarehouse).FullName, "");
        this.ServicesDictionary.Add(typeof(ItemWarehous).FullName, "Inventory/ItemWarehouses");
        this.ServicesDictionary.Add(typeof(ItemWarehousePlanningDetail).FullName, "Inventory/ItemWarehousePlanningDetails");
        this.ServicesDictionary.Add(typeof(ItemWarehouseStorageLocation).FullName, "Inventory/ItemWarehouseStorageLocations");
        this.ServicesDictionary.Add(typeof(ProcessStockCount).FullName, "Inventory/ProcessStockCount");
        this.ServicesDictionary.Add(typeof(SerialNumber).FullName, "Inventory/SerialNumbers");
        this.ServicesDictionary.Add(typeof(StockBatchNumber).FullName, "Inventory/StockBatchNumbers");
        this.ServicesDictionary.Add(typeof(StockCount).FullName, "Inventory/StockCounts");
        this.ServicesDictionary.Add(typeof(StockCountLine).FullName, "Inventory/StockCountLines");
        this.ServicesDictionary.Add(typeof(StockSerialNumber).FullName, "Inventory/StockSerialNumbers");
        this.ServicesDictionary.Add(typeof(StorageLocation).FullName, "Inventory/StorageLocations");
        this.ServicesDictionary.Add(typeof(Warehouse).FullName, "Inventory/Warehouses");
        this.ServicesDictionary.Add(typeof(Item).FullName, "Logistics/Items");
        this.ServicesDictionary.Add(typeof(ItemGroup).FullName, "Logistics/ItemGroups");
        this.ServicesDictionary.Add(typeof(ItemVersion).FullName, "Logistics/ItemVersions");
        this.ServicesDictionary.Add(typeof(SalesItemPrice).FullName, "Logistics/SalesItemPrices");
        this.ServicesDictionary.Add(typeof(SupplierItem).FullName, "Logistics/SupplierItem");
        this.ServicesDictionary.Add(typeof(Unit).FullName, "Logistics/Units");
        this.ServicesDictionary.Add(typeof(DefaultMailbox).FullName, "Read/Mailbox/DefaultMailbox");
        this.ServicesDictionary.Add(typeof(Mailbox).FullName, "Mailbox/Mailboxes");
        this.ServicesDictionary.Add(typeof(MailMessageAttachment).FullName, "Mailbox/MailMessageAttachments");
        this.ServicesDictionary.Add(typeof(MailMessagesReceived).FullName, "Mailbox/MailMessagesReceived");
        this.ServicesDictionary.Add(typeof(MailMessagesSent).FullName, "Mailbox/MailMessagesSent");
        this.ServicesDictionary.Add(typeof(PreferredMailbox).FullName, "Read/Mailbox/PreferredMailbox");
        this.ServicesDictionary.Add(typeof(BillOfMaterialMaterial).FullName, "Manufacturing/BillOfMaterialMaterials");
        this.ServicesDictionary.Add(typeof(BillOfMaterialVersion).FullName, "Manufacturing/BillOfMaterialVersions");
        this.ServicesDictionary.Add(typeof(ByProductReceipt).FullName, "Manufacturing/ByProductReceipts");
        this.ServicesDictionary.Add(typeof(ByProductReversal).FullName, "Manufacturing/ByProductReversals");
        this.ServicesDictionary.Add(typeof(MaterialIssue).FullName, "Manufacturing/MaterialIssues");
        this.ServicesDictionary.Add(typeof(MaterialReversal).FullName, "Manufacturing/MaterialReversals");
        this.ServicesDictionary.Add(typeof(Operation).FullName, "Manufacturing/Operations");
        this.ServicesDictionary.Add(typeof(OperationResource).FullName, "Manufacturing/OperationResources");
        this.ServicesDictionary.Add(typeof(ProductionArea).FullName, "Manufacturing/ProductionAreas");
        this.ServicesDictionary.Add(typeof(ShopOrder).FullName, "Manufacturing/ShopOrders");
        this.ServicesDictionary.Add(typeof(ShopOrderMaterialPlan).FullName, "Manufacturing/ShopOrderMaterialPlans");
        this.ServicesDictionary.Add(typeof(ShopOrderReceipt).FullName, "Manufacturing/ShopOrderReceipts");
        this.ServicesDictionary.Add(typeof(ShopOrderReversal).FullName, "Manufacturing/ShopOrderReversals");
        this.ServicesDictionary.Add(typeof(ShopOrderRoutingStepPlan).FullName, "Manufacturing/ShopOrderRoutingStepPlans");
        this.ServicesDictionary.Add(typeof(StageForDeliveryReceipt).FullName, "Manufacturing/StageForDeliveryReceipts");
        this.ServicesDictionary.Add(typeof(StageForDeliveryReversal).FullName, "Manufacturing/StageForDeliveryReversals");
        this.ServicesDictionary.Add(typeof(SubOrderReceipt).FullName, "Manufacturing/SubOrderReceipts");
        this.ServicesDictionary.Add(typeof(SubOrderReversal).FullName, "Manufacturing/SubOrderReversals");
        this.ServicesDictionary.Add(typeof(TimeTransaction).FullName, "Manufacturing/TimeTransactions");
        this.ServicesDictionary.Add(typeof(Workcenter).FullName, "Manufacturing/Workcenters");
        this.ServicesDictionary.Add(typeof(OpeningBalanceAfterEntry).FullName, "OpeningBalance/CurrentYear/AfterEntry");
        this.ServicesDictionary.Add(typeof(OpeningBalancePreviousYearAfterEntry).FullName, "OpeningBalance/PreviousYear/AfterEntry");
        this.ServicesDictionary.Add(typeof(OpeningBalancePreviousYearProcessed).FullName, "OpeningBalance/PreviousYear/Processed");
        this.ServicesDictionary.Add(typeof(OpeningBalanceProcessed).FullName, "OpeningBalance/CurrentYear/Processed");
        this.ServicesDictionary.Add(typeof(ActiveEmployment).FullName, "Payroll/ActiveEmployments");
        this.ServicesDictionary.Add(typeof(Employee).FullName, "Payroll/Employees");
        this.ServicesDictionary.Add(typeof(Employment).FullName, "Payroll/Employments");
        this.ServicesDictionary.Add(typeof(EmploymentContract).FullName, "Payroll/EmploymentContracts");
        this.ServicesDictionary.Add(typeof(EmploymentContractFlexPhas).FullName, "Payroll/EmploymentContractFlexPhases");
        this.ServicesDictionary.Add(typeof(EmploymentEndReason).FullName, "Payroll/EmploymentEndReasons");
        this.ServicesDictionary.Add(typeof(EmploymentOrganization).FullName, "Payroll/EmploymentOrganizations");
        this.ServicesDictionary.Add(typeof(EmploymentSalary).FullName, "Payroll/EmploymentSalaries");
        this.ServicesDictionary.Add(typeof(TaxEmploymentEndFlexCode).FullName, "Payroll/TaxEmploymentEndFlexCodes");
        this.ServicesDictionary.Add(typeof(CostTransaction).FullName, "Project/CostTransactions");
        this.ServicesDictionary.Add(typeof(HourCostType).FullName, "Read/Project/HourCostTypes");
        this.ServicesDictionary.Add(typeof(InvoiceTerm).FullName, "Project/InvoiceTerms");
        this.ServicesDictionary.Add(typeof(Project).FullName, "Project/Projects");
        this.ServicesDictionary.Add(typeof(ProjectBudgetType).FullName, "Project/ProjectBudgetTypes");
        this.ServicesDictionary.Add(typeof(ProjectHourBudget).FullName, "Project/ProjectHourBudgets");
        this.ServicesDictionary.Add(typeof(ProjectPlanning).FullName, "Project/ProjectPlanning");
        this.ServicesDictionary.Add(typeof(ProjectPlanningRecurring).FullName, "Project/ProjectPlanningRecurring");
        this.ServicesDictionary.Add(typeof(ProjectRestrictionEmployee).FullName, "Project/ProjectRestrictionEmployees");
        this.ServicesDictionary.Add(typeof(ProjectRestrictionItem).FullName, "Project/ProjectRestrictionItems");
        this.ServicesDictionary.Add(typeof(ProjectRestrictionRebilling).FullName, "Project/ProjectRestrictionRebillings");
        this.ServicesDictionary.Add(typeof(RecentCost).FullName, "Read/Project/RecentCosts");
        this.ServicesDictionary.Add(typeof(RecentHour).FullName, "Read/Project/RecentHours");
        this.ServicesDictionary.Add(typeof(TimeAndBillingAccountDetail).FullName, "Read/Project/TimeAndBillingAccountDetails");
        this.ServicesDictionary.Add(typeof(TimeAndBillingActivitiesAndExpens).FullName, "Read/Project/TimeAndBillingActivitiesAndExpenses");
        this.ServicesDictionary.Add(typeof(TimeAndBillingEntryAccount).FullName, "Read/Project/TimeAndBillingEntryAccounts");
        this.ServicesDictionary.Add(typeof(TimeAndBillingEntryProject).FullName, "Read/Project/TimeAndBillingEntryProjects");
        this.ServicesDictionary.Add(typeof(TimeAndBillingEntryRecentAccount).FullName, "Read/Project/TimeAndBillingEntryRecentAccounts");
        this.ServicesDictionary.Add(typeof(TimeAndBillingEntryRecentActivitiesAndExpens).FullName, "Read/Project/TimeAndBillingEntryRecentActivitiesAndExpenses");
        this.ServicesDictionary.Add(typeof(TimeAndBillingEntryRecentHourCostType).FullName, "Read/Project/TimeAndBillingEntryRecentHourCostTypes");
        this.ServicesDictionary.Add(typeof(TimeAndBillingEntryRecentProject).FullName, "Read/Project/TimeAndBillingEntryRecentProjects");
        this.ServicesDictionary.Add(typeof(TimeAndBillingItemDetail).FullName, "Read/Project/TimeAndBillingItemDetails");
        this.ServicesDictionary.Add(typeof(TimeAndBillingProjectDetail).FullName, "Read/Project/TimeAndBillingProjectDetails");
        this.ServicesDictionary.Add(typeof(TimeCorrection).FullName, "Project/TimeCorrections");
        this.ServicesDictionary.Add(typeof(TimeTransaction).FullName, "Project/TimeTransactions");
        this.ServicesDictionary.Add(typeof(PurchaseInvoice).FullName, "Purchase/PurchaseInvoices");
        this.ServicesDictionary.Add(typeof(PurchaseInvoiceLine).FullName, "Purchase/PurchaseInvoiceLines");
        this.ServicesDictionary.Add(typeof(PurchaseEntry).FullName, "PurchaseEntry/PurchaseEntries");
        this.ServicesDictionary.Add(typeof(PurchaseEntryLine).FullName, "PurchaseEntry/PurchaseEntryLines");
        this.ServicesDictionary.Add(typeof(GoodsReceipt).FullName, "PurchaseOrder/GoodsReceipts");
        this.ServicesDictionary.Add(typeof(GoodsReceiptLine).FullName, "PurchaseOrder/GoodsReceiptLines");
        this.ServicesDictionary.Add(typeof(PurchaseOrder).FullName, "PurchaseOrder/PurchaseOrders");
        this.ServicesDictionary.Add(typeof(PurchaseOrderLine).FullName, "PurchaseOrder/PurchaseOrderLines");
        this.ServicesDictionary.Add(typeof(PriceList).FullName, "Sales/PriceLists");
        this.ServicesDictionary.Add(typeof(SalesPriceListDetail).FullName, "Sales/SalesPriceListDetails");
        this.ServicesDictionary.Add(typeof(ShippingMethod).FullName, "Sales/ShippingMethods");
        this.ServicesDictionary.Add(typeof(SalesEntry).FullName, "SalesEntry/SalesEntries");
        this.ServicesDictionary.Add(typeof(SalesEntryLine).FullName, "SalesEntry/SalesEntryLines");
        this.ServicesDictionary.Add(typeof(InvoiceSalesOrder).FullName, "SalesInvoice/InvoiceSalesOrders");
        this.ServicesDictionary.Add(typeof(Layout).FullName, "SalesInvoice/Layouts");
        this.ServicesDictionary.Add(typeof(PrintedSalesInvoice).FullName, "SalesInvoice/PrintedSalesInvoices");
        this.ServicesDictionary.Add(typeof(SalesInvoice).FullName, "SalesInvoice/SalesInvoices");
        this.ServicesDictionary.Add(typeof(SalesInvoiceLine).FullName, "SalesInvoice/SalesInvoiceLines");
        this.ServicesDictionary.Add(typeof(SalesOrderID).FullName, "SalesInvoice/SalesOrderID");
        this.ServicesDictionary.Add(typeof(GoodsDelivery).FullName, "SalesOrder/GoodsDeliveries");
        this.ServicesDictionary.Add(typeof(GoodsDeliveryLine).FullName, "SalesOrder/GoodsDeliveryLines");
        this.ServicesDictionary.Add(typeof(PrintedSalesOrder).FullName, "SalesOrder/PrintedSalesOrders");
        this.ServicesDictionary.Add(typeof(SalesOrder).FullName, "SalesOrder/SalesOrders");
        this.ServicesDictionary.Add(typeof(SalesOrderLine).FullName, "SalesOrder/SalesOrderLines");
        this.ServicesDictionary.Add(typeof(Subscription).FullName, "Subscription/Subscriptions");
        this.ServicesDictionary.Add(typeof(SubscriptionLine).FullName, "Subscription/SubscriptionLines");
        this.ServicesDictionary.Add(typeof(SubscriptionLineType).FullName, "Subscription/SubscriptionLineTypes");
        this.ServicesDictionary.Add(typeof(SubscriptionReasonCode).FullName, "Subscription/SubscriptionReasonCodes");
        this.ServicesDictionary.Add(typeof(SubscriptionRestrictionEmployee).FullName, "Subscription/SubscriptionRestrictionEmployees");
        this.ServicesDictionary.Add(typeof(SubscriptionRestrictionItem).FullName, "Subscription/SubscriptionRestrictionItems");
        this.ServicesDictionary.Add(typeof(SubscriptionType).FullName, "Subscription/SubscriptionTypes");
        this.ServicesDictionary.Add(typeof(AccountantInfo).FullName, "System/AccountantInfo");
        this.ServicesDictionary.Add(typeof(AvailableFeature).FullName, "System/AvailableFeatures");
        this.ServicesDictionary.Add(typeof(Division).FullName, "System/Divisions");
        this.ServicesDictionary.Add(typeof(User).FullName, "Users/Users");
        this.ServicesDictionary.Add(typeof(UserRole).FullName, "Users/UserRoles");
        this.ServicesDictionary.Add(typeof(UserRolesPerDivision).FullName, "Users/UserRolesPerDivision");
        this.ServicesDictionary.Add(typeof(VATCode).FullName, "VAT/VATCodes");
        this.ServicesDictionary.Add(typeof(VatPercentage).FullName, "VAT/VatPercentages");
        this.ServicesDictionary.Add(typeof(WebhookSubscription).FullName, "Webhooks/WebhookSubscriptions");
        this.ServicesDictionary.Add(typeof(RequestAttachment).FullName, "Workflow/RequestAttachments");
    }
}

