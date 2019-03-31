using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.DTOs;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.ViewModels
{
    class OtherViewModel
    {
        private readonly IHttpRequestService<OtherDTORequest, OtherDTOResponse> _httpRequestService;

        public OtherViewModel(IHttpRequestService<OtherDTORequest, OtherDTOResponse> httpRequestService)
        {
            _httpRequestService = httpRequestService;
        }

        private async Task RequestData(string id)
        {
            OtherDTOResponse response = null;
            using (var request = new HttpRequestService<OtherDTORequest, OtherDTOResponse>())
            {
                response = await Task.Run(() => _httpRequestService.MakeRequest(new OtherDTORequest(id)));
            }
        }
    }
}
