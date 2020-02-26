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
  public  class CustomerService : ICustomerService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly IUtilService _utilService;
        public CustomerService(IRepositoryWrapper repositoryWrapper,IMapper mapper,ILoggerManager loggerManager,IUtilService utilService) {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
            this._logger = loggerManager;
            this._utilService = utilService;
        }

        public async Task<bool> AddCustomer(AddCustomerViewModel addCustomerViewModel)
        {
            var CustomerDT = _mapper.Map<AddCustomerViewModel, Customer>(addCustomerViewModel);
            var AddressDT  = _mapper.Map<AddCustomerViewModel, Address>(addCustomerViewModel);
            var PhoneDT = _mapper.Map<AddCustomerViewModel, Phone>(addCustomerViewModel);
            Task<string> cusUnique =  _utilService.GetUniqueId("Customer");
            Task<string> addressUnique =  _utilService.GetUniqueId("Address");
            Task<string> phoneUnique =  _utilService.GetUniqueId("Phone");

            await Task.WhenAll(cusUnique, addressUnique, phoneUnique);

            CustomerDT.UniqueId = cusUnique.Result;
            AddressDT.UniqueId = addressUnique.Result;
            PhoneDT.UniqueId = phoneUnique.Result;


            CustomerDT = _repositoryWrapper.Customer.Create(CustomerDT);
            AddressDT.RelatedId = CustomerDT.Id;
            AddressDT =  _repositoryWrapper.Address.Create(AddressDT);
            PhoneDT.RelatedId = CustomerDT.Id;
            PhoneDT = _repositoryWrapper.Phone.Create(PhoneDT);
            try
            {
            await _repositoryWrapper.SaveAsync();
                this._logger.LogInfo("Successful In saving");
            }
            catch (Exception ex) {
                this._logger.LogInfo(ex.ToString());
                return false;
            }
            return true;
        }
        public async Task UpdateCustomer(string id, UpdateCustomerViewModel updateCustomerViewModel)
        {
            Task<IEnumerable<Customer>> CustomersDB =  _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);
            Task<IEnumerable<Address>> AddressesDB =  _repositoryWrapper.Address.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);
            Task<IEnumerable<Phone>> PhonesDB =  _repositoryWrapper.Phone.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);
     
            await Task.WhenAll(CustomersDB, AddressesDB, PhonesDB);
       
            var CustomerUpdated = _mapper.Map<UpdateCustomerViewModel, Customer>(updateCustomerViewModel, CustomersDB.Result.ToList().FirstOrDefault());
            var AddressUpdated = _mapper.Map<UpdateCustomerViewModel, Address>(updateCustomerViewModel, AddressesDB.Result.ToList().FirstOrDefault());
            var PhoneUpdated = _mapper.Map<UpdateCustomerViewModel, Phone>(updateCustomerViewModel, PhonesDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Customer.Update(CustomerUpdated);
            _repositoryWrapper.Address.Update(AddressUpdated);
            _repositoryWrapper.Phone.Update(PhoneUpdated);
            await _repositoryWrapper.SaveAsync();
        }
        public async Task<List<ListCustomerVM>> GetCustomerList(string FactoryId) {

            Task<IEnumerable<Customer>> custListTask =  _repositoryWrapper.Customer.FindByConditionAsync(x => x.FactoryId == FactoryId);
            Task<IEnumerable<Address>> addressListTask =  _repositoryWrapper.Address.FindByConditionAsync(x => x.FactoryId == FactoryId);
            Task<IEnumerable<Phone>> phoneListTask =  _repositoryWrapper.Phone.FindByConditionAsync(x => x.FactoryId == FactoryId);

            await Task.WhenAll(custListTask, addressListTask, phoneListTask);

            List<Customer> custList = custListTask.Result.ToList();
            List<Address> addressList = addressListTask.Result.ToList();
            List<Phone> phoneList = phoneListTask.Result.ToList();
            List<ListCustomerVM> outputList = new List<ListCustomerVM>();

            for (int i = 0; i < custList.Count(); i++)
            {
                var tempCustomer = custList.ElementAt(i);
                var tempAddress = addressList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
                var tempPhone = phoneList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
                var output = new ListCustomerVM();
                output = _mapper.Map<Customer, ListCustomerVM>(tempCustomer, output);
                output = _mapper.Map<Address, ListCustomerVM>(tempAddress, output);
                output = _mapper.Map<Phone, ListCustomerVM>(tempPhone, output);
                outputList.Add(output);
            }

           return  outputList;
        }
        public async Task<List<ListCustomerVM>> GetCustomerListPaged(GetDataListVM dataListVM)
        {
            Task<IEnumerable<Customer>> custListTask =   _repositoryWrapper.Customer.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            Task<IEnumerable<Address>> addressListTask =  _repositoryWrapper.Address.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            Task<IEnumerable<Phone>> phoneListTask  =  _repositoryWrapper.Phone.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);


            await Task.WhenAll(custListTask, addressListTask, phoneListTask);

            List<Customer> custList = custListTask.Result.ToList();
            List<Address> addressList = addressListTask.Result.ToList();
            List<Phone> phoneList = phoneListTask.Result.ToList();

            List<ListCustomerVM> outputList = new List<ListCustomerVM>();

            for (int i = 0; i < custList.Count(); i++)
            {
                var tempCustomer = custList.ElementAt(i);
                var tempAddress = addressList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
                var tempPhone = phoneList.Where(x => x.RelatedId == tempCustomer.Id).FirstOrDefault();
                var output = new ListCustomerVM();
                output = _mapper.Map<Customer, ListCustomerVM>(tempCustomer, output);
                output = _mapper.Map<Address, ListCustomerVM>(tempAddress, output);
                output = _mapper.Map<Phone, ListCustomerVM>(tempPhone, output);
                outputList.Add(output);
            }

            return outputList;
        }
        public async Task<UpdateCustomerViewModel> GetCustomer(string cusId,string FactoryId) {
            Task<IEnumerable<Customer>> CustomersDB =  _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);
            Task <IEnumerable<Address>> AddressesDB =  _repositoryWrapper.Address.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);
            Task <IEnumerable<Phone>> PhonesDB =  _repositoryWrapper.Phone.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);

            await Task.WhenAll(CustomersDB, AddressesDB, PhonesDB);

            Customer cust = CustomersDB.Result.ToList().FirstOrDefault();
            Address address = AddressesDB.Result.ToList().FirstOrDefault();
            Phone phone = PhonesDB.Result.ToList().FirstOrDefault();



            ListCustomerVM output= new ListCustomerVM();                      
            output = _mapper.Map<Customer, ListCustomerVM>(cust, output);
            output = _mapper.Map<Address, ListCustomerVM>(address, output);
            output = _mapper.Map<Phone, ListCustomerVM>(phone, output);
            return _mapper.Map<ListCustomerVM, UpdateCustomerViewModel>(output);

        }

    }
}
