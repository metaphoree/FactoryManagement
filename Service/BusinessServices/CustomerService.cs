using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
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
        public CustomerService(IRepositoryWrapper repositoryWrapper,IMapper mapper) {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
        }

        public async Task AddCustomer(AddCustomerViewModel addCustomerViewModel)
        {
            var CustomerDT = _mapper.Map<AddCustomerViewModel, Customer>(addCustomerViewModel);
            var AddressDT  = _mapper.Map<AddCustomerViewModel, Address>(addCustomerViewModel);
            var PhoneDT = _mapper.Map<AddCustomerViewModel, Phone>(addCustomerViewModel);
            CustomerDT = _repositoryWrapper.Customer.Create(CustomerDT);
            AddressDT.RelatedId = CustomerDT.Id;
            AddressDT =  _repositoryWrapper.Address.Create(AddressDT);
            PhoneDT.RelatedId = CustomerDT.Id;
            PhoneDT = _repositoryWrapper.Phone.Create(PhoneDT);
            await _repositoryWrapper.SaveAsync();
        }
        public async Task UpdateCustomer(string id, UpdateCustomerViewModel updateCustomerViewModel)
        {
            Task<IEnumerable<Customer>> CustomersDB =  _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);
            Task<IEnumerable<Address>> AddressesDB =  _repositoryWrapper.Address.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);
            Task<IEnumerable<Phone>> PhonesDB =  _repositoryWrapper.Phone.FindByConditionAsync(x => x.Id == id && x.FactoryId == updateCustomerViewModel.FactoryId);        
            var CustomerUpdated = _mapper.Map<UpdateCustomerViewModel, Customer>(updateCustomerViewModel, CustomersDB.Result.ToList().FirstOrDefault());
            var AddressUpdated = _mapper.Map<UpdateCustomerViewModel, Address>(updateCustomerViewModel, AddressesDB.Result.ToList().FirstOrDefault());
            var PhoneUpdated = _mapper.Map<UpdateCustomerViewModel, Phone>(updateCustomerViewModel, PhonesDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Customer.Update(CustomerUpdated);
            _repositoryWrapper.Address.Update(AddressUpdated);
            _repositoryWrapper.Phone.Update(PhoneUpdated);
            await _repositoryWrapper.SaveAsync();
        }
        public async Task<List<ListCustomerVM>> GetCustomerList(string FactoryId) {
            IEnumerable<Customer> CustomersDB =await _repositoryWrapper.Customer.FindByConditionAsync(x =>  x.FactoryId == FactoryId);
            IEnumerable<Address> AddressesDB = await _repositoryWrapper.Address.FindByConditionAsync(x =>  x.FactoryId == FactoryId);
            IEnumerable<Phone> PhonesDB = await _repositoryWrapper.Phone.FindByConditionAsync(x => x.FactoryId == FactoryId);

            List<Customer> custList =  CustomersDB.ToList();
            List<Address> addressList = AddressesDB.ToList();
            List<Phone> phoneList = PhonesDB.ToList();
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

        public async Task<UpdateCustomerViewModel> GetCustomer(string cusId,string FactoryId) {
            IEnumerable<Customer> CustomersDB = await _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);
            IEnumerable<Address> AddressesDB = await _repositoryWrapper.Address.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);
            IEnumerable<Phone> PhonesDB = await _repositoryWrapper.Phone.FindByConditionAsync(x => x.Id == cusId && x.FactoryId == FactoryId);

          Customer cust = CustomersDB.ToList().FirstOrDefault();
            Address address = AddressesDB.ToList().FirstOrDefault();
            Phone phone = PhonesDB.ToList().FirstOrDefault();
            ListCustomerVM output= new ListCustomerVM();
           
            
            output = _mapper.Map<Customer, ListCustomerVM>(cust, output);
            output = _mapper.Map<Address, ListCustomerVM>(address, output);
            output = _mapper.Map<Phone, ListCustomerVM>(phone, output);

            return _mapper.Map<ListCustomerVM, UpdateCustomerViewModel>(output);

        }


    }
}
