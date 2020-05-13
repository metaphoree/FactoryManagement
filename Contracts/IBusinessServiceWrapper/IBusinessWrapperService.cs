﻿using CommonUtils;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Expense;
using Entities.ViewModels.Income;
using Entities.ViewModels.Payable;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Production;
using Entities.ViewModels.Recievable;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IBusinessServiceWrapper
{
    public interface IBusinessWrapperService
    {
        //Task<WrapperPaymentListVM> PayToSupplier(PaymentVM paymentVM);
        //Task<WrapperPaymentListVM> PayToStaff(PaymentVM paymentVM);
        //Task<WrapperPaymentListVM> RecieveFromCustomer(PaymentVM paymentVM);
        //Task<WrapperCustomerHistory> GetCustomerHistory(GetDataListHistory customerVM);
        //Task<WrapperSupplierHistory> GetSupplierHistory(GetDataListHistory supplierVM);
        //Task<WrapperStaffHistory> GetStaffHistory(GetDataListHistory staffVM); 
        //Task<WrapperPaymentListVM> GetSupplierPaymentList(GetPaymentDataListVM vm);
        //Task<WrapperPaymentListVM> DeleteSupplierPayment(PaymentVM vm);
        //Task<WrapperPaymentListVM> GetStaffPaymentList(GetPaymentDataListVM vm);
        //Task<WrapperPaymentListVM> DeleteStaffPayment(PaymentVM vm);
        //Task<WrapperPaymentListVM> GetCustomerPaymentList(GetPaymentDataListVM vm);
        //Task<WrapperPaymentListVM> DeleteCustomerPayment(PaymentVM vm);
        Task<WrapperMonthExpenseVM> MonthlyExpense(MonthlyReport vm);
        Task<WrapperMonthIncomeVM> MonthlyIncome(MonthlyReport vm);
        Task<WrapperMonthPayableListVM> MonthlyPayable(MonthlyReport vm);
        Task<WrapperMonthProductionListVM> MonthlyProduction(MonthlyReport vm);
        Task<WrapperMonthRecievableVM> MonthlyRecievable(MonthlyReport vm);
        Task<Entities.ViewModels.Transaction.WrapperMonthTransactionVM> MonthlyTransaction(MonthlyReport vm);
    }
}
