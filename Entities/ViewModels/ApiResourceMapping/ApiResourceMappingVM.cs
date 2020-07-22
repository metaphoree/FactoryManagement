using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.ApiResourceMapping
{
    public class ApiResourceMappingVM
    {
        public string Controller { get; set; }
        public string Resource { get; set; }
        public string Action { get; set; }

        public string Id { get; set; }
    }
}
