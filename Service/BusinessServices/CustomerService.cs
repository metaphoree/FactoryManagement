using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IUtilService _utilService;
        public CustomerService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._utilService = utilService;
        }

        public async Task<WrapperListCustomerVM> Add(CustomerVM addCustomerViewModel)
        {
            var CustomerDT = _utilService.GetMapper().Map<CustomerVM, Customer>(addCustomerViewModel);
         //   var AddressDT = _mapper.Map<AddCustomerViewModel, Address>(addCustomerViewModel);
          //  var PhoneDT = _mapper.Map<AddCustomerViewModel, Phone>(addCustomerViewModel);

            //Task<string> cusUnique = _repositoryWrapper.Customer.GetUniqueId();
            //Task<string> addressUnique = _repositoryWrapper.Address.GetUniqueId();
            //Task<string> phoneUnique = _repositoryWrapper.Phone.GetUniqueId();

            //await Task.WhenAll(cusUnique, addressUnique, phoneUnique);

            //CustomerDT.UniqueId = cusUnique.Result;
            //AddressDT.UniqueId = addressUnique.Result;
            //PhoneDT.UniqueId = phoneUnique.Result;


            CustomerDT = _repositoryWrapper.Customer.Create(CustomerDT);
            //AddressDT.RelatedId = CustomerDT.Id;
            //AddressDT = _repositoryWrapper.Address.Create(AddressDT);
            //PhoneDT.RelatedId = CustomerDT.Id;
            //PhoneDT = _repositoryWrapper.Phone.Create(PhoneDT);
            Task<int> t1 = _repositoryWrapper.Customer.SaveChangesAsync();
            //Task<int> t2 = _repositoryWrapper.Address.SaveChangesAsync();
            //Task<int> t3 = _repositoryWrapper.Phone.SaveChangesAsync();
            //// await _repositoryWrapper.SaveAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In saving");
           
            var dataParam = new GetDataListVM()
            {
                FactoryId = addCustomerViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperListCustomerVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperListCustomerVM> Update(string id, CustomerVM updateCustomerViewModel)
        {
            if (id != updateCustomerViewModel.CustomerId)
            {
                new WrapperListCustomerVM();
            }

            Task<IEnumerable<Customer>> CustomersDB = _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);
            //Task<IEnumerable<Address>> AddressesDB = _repositoryWrapper.Address.FindByConditionAsync(x => x.RelatedId == id && x.FactoryId == updateCustomerViewModel.FactoryId);
            //Task<IEnumerable<Phone>> PhonesDB = _repositoryWrapper.Phone.FindByConditionAsync(x => x.RelatedId == id && x.FactoryId == updateCustomerViewModel.FactoryId);

            await Task.WhenAll(CustomersDB);

            var CustomerUpdated = _utilService.GetMapper().Map<CustomerVM, Customer>(updateCustomerViewModel, CustomersDB.Result.ToList().FirstOrDefault());
            //var AddressUpdated = _mapper.Map<UpdateCustomerViewModel, Address>(updateCustomerViewModel, AddressesDB.Result.ToList().FirstOrDefault());
            //var PhoneUpdated = _mapper.Map<UpdateCustomerViewModel, Phone>(updateCustomerViewModel, PhonesDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Customer.Update(CustomerUpdated);
            //_repositoryWrapper.Address.Update(AddressUpdated);
            //_repositoryWrapper.Phone.Update(PhoneUpdated);


            Task<int> t1 = _repositoryWrapper.Customer.SaveChangesAsync();
            //Task<int> t2 = _repositoryWrapper.Address.SaveChangesAsync();
            //Task<int> t3 = _repositoryWrapper.Phone.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In saving");



            var dataParam = new GetDataListVM()
            {
                FactoryId = updateCustomerViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperListCustomerVM data = await GetListPaged(dataParam);
            return data;
        }      
        public async Task<WrapperListCustomerVM> GetListPaged(GetDataListVM dataListVM)
        {
            IEnumerable<Customer> custListTask = await _repositoryWrapper.Customer.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            //Task<IEnumerable<Address>> addressListTask = _repositoryWrapper.Address.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            //Task<IEnumerable<Phone>> phoneListTask = _repositoryWrapper.Phone.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            long noOfRecordTask = await _repositoryWrapper.Customer.NumOfRecord();
           // await Task.WhenAll(custListTask);
           // await Task.WhenAll(noOfRecordTask);

            List<Customer> custList = custListTask.ToList().OrderByDescending(x => x.UpdatedDateTime).ToList();//.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).OrderByDescending(x => x.CreatedDateTime).ToList();
            //List<Address> addressList = addressListTask.Result.ToList();
            //List<Phone> phoneList = phoneListTask.Result.ToList();

            List<CustomerVM> outputList = new List<CustomerVM>();

            outputList = _utilService.GetMapper().Map<List<Customer>, List<CustomerVM>>(custList);
            if (!string.IsNullOrEmpty(dataListVM.GlobalFilter) && !string.IsNullOrWhiteSpace(dataListVM.GlobalFilter)) {
                outputList = outputList.Where(output =>
                output.AlternateCellNo != null ? output.AlternateCellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.CellNo != null ? output.CellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.Email != null ? output.Email.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.Name != null ? output.Name.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                             || output.PermanentAddress != null ? output.PermanentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                              || output.PresentAddress != null ? output.PresentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false).ToList();
            }
                //for (int i = 0; i < custList.Count(); i++)
            //{
            //    var tempCustomer = custList.ElementAt(i);
            //    //var tempAddress = addressList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
            //    //var tempPhone = phoneList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
            //    var output = new ListCustomerVM();
            //    output = _mapper.Map<Customer, ListCustomerVM>(tempCustomer, output);
            //    //output = _mapper.Map<Address, ListCustomerVM>(tempAddress, output);
            //    //output = _mapper.Map<Phone, ListCustomerVM>(tempPhone, output);
            //    if (dataListVM.GlobalFilter != null)
            //    {
            //        if (output.AlternateCellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase)
            //            || output.CellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase)
            //            || output.Email.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase)
            //            || output.Name.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase)
            //             || output.PermanentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase)
            //              || output.PresentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase))
            //        {
            //            outputList.Add(output);
            //        }
            //    }
            //    else
            //    {
            //        outputList.Add(output);
            //    }

            //}
            outputList = outputList.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).ToList();
            var data = new WrapperListCustomerVM();
            data.ListOfData = outputList;
            data.TotalRecoreds = noOfRecordTask;

            return data;
        }
        public async Task<WrapperListCustomerVM> Delete(CustomerVM customerTemp)
        {
            var customerTask = await _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == customerTemp.CustomerId && x.FactoryId == customerTemp.FactoryId);
            var customer = customerTask.ToList().FirstOrDefault();
            if (customer == null)
            {
                return new WrapperListCustomerVM();
            }
            _repositoryWrapper.Customer.Delete(customer);
            await _repositoryWrapper.Customer.SaveChangesAsync();
            var dataParam = new GetDataListVM()
            {
                FactoryId = customerTemp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperListCustomerVM data = await GetListPaged(dataParam);
            return data;
        }












        //public async Task<List<CustomerVM>> GetList(string FactoryId)
        //{

        //    Task<IEnumerable<Customer>> custListTask = _repositoryWrapper.Customer.FindByConditionAsync(x => x.FactoryId == FactoryId);
        //    ////Task<IEnumerable<Address>> addressListTask = _repositoryWrapper.Address.FindByConditionAsync(x => x.FactoryId == FactoryId);
        //    ////Task<IEnumerable<Phone>> phoneListTask = _repositoryWrapper.Phone.FindByConditionAsync(x => x.FactoryId == FactoryId);

        //    await Task.WhenAll(custListTask);

        //    List<Customer> custList = custListTask.Result.ToList();
        //    //List<Address> addressList = addressListTask.Result.ToList();
        //    //List<Phone> phoneList = phoneListTask.Result.ToList();
        //    List<ListCustomerVM> outputList = new List<ListCustomerVM>();

        //    for (int i = 0; i < custList.Count(); i++)
        //    {
        //        var tempCustomer = custList.ElementAt(i);
        //        //var tempAddress = addressList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
        //        //var tempPhone = phoneList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
        //        var output = new ListCustomerVM();
        //        output = _mapper.Map<Customer, ListCustomerVM>(tempCustomer, output);
        //        //output = _mapper.Map<Address, ListCustomerVM>(tempAddress, output);
        //        //output = _mapper.Map<Phone, ListCustomerVM>(tempPhone, output);
        //        outputList.Add(output);
        //    }

        //    return outputList;
        //}
        //public async Task<CustomerVM> GetSingle(string cusId, string FactoryId)
        //{
        //    Task<IEnumerable<Customer>> CustomersDB = _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);
        //    //Task<IEnumerable<Address>> AddressesDB = _repositoryWrapper.Address.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);
        //    //Task<IEnumerable<Phone>> PhonesDB = _repositoryWrapper.Phone.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);

        //    await Task.WhenAll(CustomersDB);

        //    Customer cust = CustomersDB.Result.ToList().FirstOrDefault();
        //    //Address address = AddressesDB.Result.ToList().FirstOrDefault();
        //    //Phone phone = PhonesDB.Result.ToList().FirstOrDefault();



        //    ListCustomerVM output = new ListCustomerVM();
        //    output = _mapper.Map<Customer, ListCustomerVM>(cust, output);
        //    //output = _mapper.Map<Address, ListCustomerVM>(address, output);
        //    //output = _mapper.Map<Phone, ListCustomerVM>(phone, output);
        //    return _mapper.Map<ListCustomerVM, UpdateCustomerViewModel>(output);

        //}

    }
}
