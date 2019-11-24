﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Management
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SchoolEntities : DbContext
    {
        public SchoolEntities()
            : base("name=SchoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FeeAssociationTable> FeeAssociationTables { get; set; }
        public virtual DbSet<FeeTable> FeeTables { get; set; }
        public virtual DbSet<InvoiceTable> InvoiceTables { get; set; }
        public virtual DbSet<FamilyMemberTable> FamilyMemberTables { get; set; }
        public virtual DbSet<FamilyTable> FamilyTables { get; set; }
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }
        public virtual DbSet<PaymentTable> PaymentTables { get; set; }
        public virtual DbSet<DiscountTable> DiscountTables { get; set; }
        public virtual DbSet<StudentDiscountTable> StudentDiscountTables { get; set; }
        public virtual DbSet<StudentTable> StudentTables { get; set; }
        public virtual DbSet<SoldStockTable> SoldStockTables { get; set; }
        public virtual DbSet<StockTable> StockTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<MessageTable> MessageTables { get; set; }
        public virtual DbSet<SLCTable> SLCTables { get; set; }
    
        public virtual int AddMembersToFamily(Nullable<int> admissionNumber, Nullable<int> familyID, Nullable<System.DateTime> date)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var familyIDParameter = familyID.HasValue ?
                new ObjectParameter("FamilyID", familyID) :
                new ObjectParameter("FamilyID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddMembersToFamily", admissionNumberParameter, familyIDParameter, dateParameter);
        }
    
        public virtual int AutoDeleteFee(Nullable<int> feeID, string feeMonth)
        {
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoDeleteFee", feeIDParameter, feeMonthParameter);
        }
    
        public virtual int AutoAssignFeeUpdate(Nullable<int> feeID, Nullable<int> feeAmount, Nullable<int> fine, Nullable<System.DateTime> dueDate, Nullable<System.DateTime> appliedON, string feeMonth)
        {
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            var feeAmountParameter = feeAmount.HasValue ?
                new ObjectParameter("FeeAmount", feeAmount) :
                new ObjectParameter("FeeAmount", typeof(int));
    
            var fineParameter = fine.HasValue ?
                new ObjectParameter("Fine", fine) :
                new ObjectParameter("Fine", typeof(int));
    
            var dueDateParameter = dueDate.HasValue ?
                new ObjectParameter("DueDate", dueDate) :
                new ObjectParameter("DueDate", typeof(System.DateTime));
    
            var appliedONParameter = appliedON.HasValue ?
                new ObjectParameter("AppliedON", appliedON) :
                new ObjectParameter("AppliedON", typeof(System.DateTime));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoAssignFeeUpdate", feeIDParameter, feeAmountParameter, fineParameter, dueDateParameter, appliedONParameter, feeMonthParameter);
        }
    
        public virtual ObjectResult<CheckForStudentsWhoDidnotPayResult> CheckForStudentsWhoDidnotPay(string status, string feeMonth)
        {
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CheckForStudentsWhoDidnotPayResult>("CheckForStudentsWhoDidnotPay", statusParameter, feeMonthParameter);
        }
    
        public virtual ObjectResult<byte[]> CheckIfPaid(Nullable<int> admissionNumber, string feeMonth)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("CheckIfPaid", admissionNumberParameter, feeMonthParameter);
        }
    
        public virtual int ClassAssignFeeUpdate(Nullable<int> feeID, Nullable<int> feeAmount, Nullable<int> fine, Nullable<System.DateTime> dueDate, Nullable<System.DateTime> appliedON, string feeMonth, Nullable<int> admissionNumber)
        {
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            var feeAmountParameter = feeAmount.HasValue ?
                new ObjectParameter("FeeAmount", feeAmount) :
                new ObjectParameter("FeeAmount", typeof(int));
    
            var fineParameter = fine.HasValue ?
                new ObjectParameter("Fine", fine) :
                new ObjectParameter("Fine", typeof(int));
    
            var dueDateParameter = dueDate.HasValue ?
                new ObjectParameter("DueDate", dueDate) :
                new ObjectParameter("DueDate", typeof(System.DateTime));
    
            var appliedONParameter = appliedON.HasValue ?
                new ObjectParameter("AppliedON", appliedON) :
                new ObjectParameter("AppliedON", typeof(System.DateTime));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ClassAssignFeeUpdate", feeIDParameter, feeAmountParameter, fineParameter, dueDateParameter, appliedONParameter, feeMonthParameter, admissionNumberParameter);
        }
    
        public virtual int ClassDeleteFee(Nullable<int> feeID, string feeMonth, Nullable<int> admissionNumber)
        {
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ClassDeleteFee", feeIDParameter, feeMonthParameter, admissionNumberParameter);
        }
    
        public virtual ObjectResult<ClassStrengthResult> ClassStrength()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ClassStrengthResult>("ClassStrength");
        }
    
        public virtual ObjectResult<DefaultersListResult> DefaultersList(Nullable<int> dues)
        {
            var duesParameter = dues.HasValue ?
                new ObjectParameter("Dues", dues) :
                new ObjectParameter("Dues", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DefaultersListResult>("DefaultersList", duesParameter);
        }
    
        public virtual int UpdateDiscount(Nullable<int> admissionNumber, Nullable<int> feeID, Nullable<int> discountID)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            var discountIDParameter = discountID.HasValue ?
                new ObjectParameter("DiscountID", discountID) :
                new ObjectParameter("DiscountID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDiscount", admissionNumberParameter, feeIDParameter, discountIDParameter);
        }
    
        public virtual int UndoFeePaid(Nullable<int> admissionNumber, string feeMonth)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UndoFeePaid", admissionNumberParameter, feeMonthParameter);
        }
    
        public virtual ObjectResult<SumOfTodaysTransactionResult> SumOfTodaysTransaction()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SumOfTodaysTransactionResult>("SumOfTodaysTransaction");
        }
    
        public virtual ObjectResult<StudentFeeDataResult> StudentFeeData(Nullable<int> admissionNumber, string feeMonth)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StudentFeeDataResult>("StudentFeeData", admissionNumberParameter, feeMonthParameter);
        }
    
        public virtual ObjectResult<SearchStudentSchoolWiseResult> SearchStudentSchoolWise(string schoolName)
        {
            var schoolNameParameter = schoolName != null ?
                new ObjectParameter("SchoolName", schoolName) :
                new ObjectParameter("SchoolName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentSchoolWiseResult>("SearchStudentSchoolWise", schoolNameParameter);
        }
    
        public virtual int DeleteDiscount(Nullable<int> admissionNumber, Nullable<int> feeID)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDiscount", admissionNumberParameter, feeIDParameter);
        }
    
        public virtual int DeleteFamily(Nullable<int> familyId)
        {
            var familyIdParameter = familyId.HasValue ?
                new ObjectParameter("FamilyId", familyId) :
                new ObjectParameter("FamilyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFamily", familyIdParameter);
        }
    
        public virtual int DeleteMember(Nullable<int> admissionNumber)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMember", admissionNumberParameter);
        }
    
        public virtual ObjectResult<byte[]> DicountExists(Nullable<int> admissionNumber, Nullable<int> feeID)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("DicountExists", admissionNumberParameter, feeIDParameter);
        }
    
        public virtual ObjectResult<FamilyInfoResult> FamilyInfo(Nullable<int> familyId)
        {
            var familyIdParameter = familyId.HasValue ?
                new ObjectParameter("FamilyId", familyId) :
                new ObjectParameter("FamilyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FamilyInfoResult>("FamilyInfo", familyIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> FeeAssignedTo(string feeMonth, Nullable<int> feeID)
        {
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            var feeIDParameter = feeID.HasValue ?
                new ObjectParameter("FeeID", feeID) :
                new ObjectParameter("FeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("FeeAssignedTo", feeMonthParameter, feeIDParameter);
        }
    
        public virtual ObjectResult<InvoicesByYearResult> InvoicesByYear(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InvoicesByYearResult>("InvoicesByYear", yearParameter);
        }
    
        public virtual ObjectResult<GetFeeTableResult> GetFeeTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFeeTableResult>("GetFeeTable");
        }
    
        public virtual ObjectResult<GetFamilyTableResult> GetFamilyTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFamilyTableResult>("GetFamilyTable");
        }
    
        public virtual ObjectResult<GetEmployeeTableResult> GetEmployeeTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeTableResult>("GetEmployeeTable");
        }
    
        public virtual ObjectResult<GetDiscountTableResult> GetDiscountTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDiscountTableResult>("GetDiscountTable");
        }
    
        public virtual int FeePaid(Nullable<int> admissionNumber, string feeMonth)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var feeMonthParameter = feeMonth != null ?
                new ObjectParameter("FeeMonth", feeMonth) :
                new ObjectParameter("FeeMonth", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FeePaid", admissionNumberParameter, feeMonthParameter);
        }
    
        public virtual ObjectResult<SearchStudentInfoByGradeResult> SearchStudentInfoByGrade(string active, string grade)
        {
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            var gradeParameter = grade != null ?
                new ObjectParameter("Grade", grade) :
                new ObjectParameter("Grade", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoByGradeResult>("SearchStudentInfoByGrade", activeParameter, gradeParameter);
        }
    
        public virtual ObjectResult<SearchStudentInfoAllByPrimaryResult> SearchStudentInfoAllByPrimary(string emergency, string active)
        {
            var emergencyParameter = emergency != null ?
                new ObjectParameter("Emergency", emergency) :
                new ObjectParameter("Emergency", typeof(string));
    
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoAllByPrimaryResult>("SearchStudentInfoAllByPrimary", emergencyParameter, activeParameter);
        }
    
        public virtual ObjectResult<SearchStudentInfoAllByNameResult> SearchStudentInfoAllByName(string name, string active)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoAllByNameResult>("SearchStudentInfoAllByName", nameParameter, activeParameter);
        }
    
        public virtual ObjectResult<SearchStudentInfoAllByIdResult> SearchStudentInfoAllById(Nullable<int> admissionNumber, string active)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoAllByIdResult>("SearchStudentInfoAllById", admissionNumberParameter, activeParameter);
        }
    
        public virtual ObjectResult<SearchStudentInfoAllByFatherNameResult> SearchStudentInfoAllByFatherName(string fatherName, string active)
        {
            var fatherNameParameter = fatherName != null ?
                new ObjectParameter("FatherName", fatherName) :
                new ObjectParameter("FatherName", typeof(string));
    
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoAllByFatherNameResult>("SearchStudentInfoAllByFatherName", fatherNameParameter, activeParameter);
        }
    
        public virtual ObjectResult<SearchStudentInfoAllResult> SearchStudentInfoAll(string active)
        {
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoAllResult>("SearchStudentInfoAll", activeParameter);
        }
    
        public virtual int RemoveOrRestore(Nullable<int> admissionNumber, string active, Nullable<System.DateTime> date)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var activeParameter = active != null ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RemoveOrRestore", admissionNumberParameter, activeParameter, dateParameter);
        }
    
        public virtual int PromoteStudents(Nullable<int> admissionNumber, string grade)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var gradeParameter = grade != null ?
                new ObjectParameter("Grade", grade) :
                new ObjectParameter("Grade", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PromoteStudents", admissionNumberParameter, gradeParameter);
        }
    
        public virtual ObjectResult<PrintFeeSlipResult> PrintFeeSlip(Nullable<int> admissionNumber)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PrintFeeSlipResult>("PrintFeeSlip", admissionNumberParameter);
        }
    
        public virtual ObjectResult<GetStockTableResult> GetStockTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStockTableResult>("GetStockTable");
        }
    
        public virtual ObjectResult<GetSlipDataByYMResult> GetSlipDataByYM(Nullable<int> year, Nullable<int> month)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSlipDataByYMResult>("GetSlipDataByYM", yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<GetSlipDataByYearResult> GetSlipDataByYear(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSlipDataByYearResult>("GetSlipDataByYear", yearParameter);
        }
    
        public virtual int PrintDepositSlip(Nullable<int> admissionNumber, string month, string status)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            var monthParameter = month != null ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PrintDepositSlip", admissionNumberParameter, monthParameter, statusParameter);
        }
    
        public virtual ObjectResult<PaymentHistoryMYResult> PaymentHistoryMY(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaymentHistoryMYResult>("PaymentHistoryMY", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<PaymentHistoryByYearResult> PaymentHistoryByYear(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaymentHistoryByYearResult>("PaymentHistoryByYear", yearParameter);
        }
    
        public virtual ObjectResult<PayementHistoryResult> PayementHistory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PayementHistoryResult>("PayementHistory");
        }
    
        public virtual ObjectResult<InvoicesMYResult> InvoicesMY(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InvoicesMYResult>("InvoicesMY", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<GetSlipDataResult> GetSlipData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSlipDataResult>("GetSlipData");
        }
    
        public virtual ObjectResult<GenderCountResult> GenderCount()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GenderCountResult>("GenderCount");
        }
    
        public virtual ObjectResult<SalesRecordMonthlyResult> SalesRecordMonthly(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalesRecordMonthlyResult>("SalesRecordMonthly", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<SalesRecordYearlyResult> SalesRecordYearly(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalesRecordYearlyResult>("SalesRecordYearly", yearParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdateMessage(Nullable<int> id, string body, string title)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var bodyParameter = body != null ?
                new ObjectParameter("Body", body) :
                new ObjectParameter("Body", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMessage", idParameter, bodyParameter, titleParameter);
        }
    
        public virtual ObjectResult<GetMessageTable_Result> GetMessageTable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMessageTable_Result>("GetMessageTable");
        }
    
        public virtual ObjectResult<Nullable<int>> ListOfStudentsWhoDidnotPay(string status)
        {
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ListOfStudentsWhoDidnotPay", statusParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CalculateDues(Nullable<int> admissionNumber)
        {
            var admissionNumberParameter = admissionNumber.HasValue ?
                new ObjectParameter("AdmissionNumber", admissionNumber) :
                new ObjectParameter("AdmissionNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CalculateDues", admissionNumberParameter);
        }
    
        public virtual ObjectResult<Experiment_Result> Experiment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Experiment_Result>("Experiment");
        }
    
        public virtual ObjectResult<FeeSlipViewData_Result> FeeSlipViewData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FeeSlipViewData_Result>("FeeSlipViewData");
        }
    
        public virtual ObjectResult<FeeSlipViewDataByGrade_Result> FeeSlipViewDataByGrade(string grade)
        {
            var gradeParameter = grade != null ?
                new ObjectParameter("grade", grade) :
                new ObjectParameter("grade", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FeeSlipViewDataByGrade_Result>("FeeSlipViewDataByGrade", gradeParameter);
        }
    
        public virtual ObjectResult<StudentDiscountAll_Result> StudentDiscountAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StudentDiscountAll_Result>("StudentDiscountAll");
        }
    
        public virtual ObjectResult<SearchStudentInfoByCNIC_Result> SearchStudentInfoByCNIC(string cNIC)
        {
            var cNICParameter = cNIC != null ?
                new ObjectParameter("CNIC", cNIC) :
                new ObjectParameter("CNIC", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchStudentInfoByCNIC_Result>("SearchStudentInfoByCNIC", cNICParameter);
        }
    
        public virtual ObjectResult<StudentDiscountByFee_Result> StudentDiscountByFee(Nullable<int> feeId)
        {
            var feeIdParameter = feeId.HasValue ?
                new ObjectParameter("feeId", feeId) :
                new ObjectParameter("feeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StudentDiscountByFee_Result>("StudentDiscountByFee", feeIdParameter);
        }
    }
}
