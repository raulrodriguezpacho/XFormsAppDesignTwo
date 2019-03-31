using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFormsAppDesignTwo.Services
{
    public interface IHttpRequestService<T, D> : IDisposable
    {
        Task<D> MakeRequest(T item);
    }
}
