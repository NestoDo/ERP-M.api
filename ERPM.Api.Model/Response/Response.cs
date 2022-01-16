using ERPM.Api.Model.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPM.Api.Model.Response
{
    public class ResponseCall<T>
    {
        public T? response { get; set; }
        public bool IsSuccess { get; set; } = true;
        public ResponseCode ResponseCode { get; set; } = ResponseCode.Success;
        public string Message { get; set; } = string.Empty;
    }
}
