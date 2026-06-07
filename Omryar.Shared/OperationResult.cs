using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Shared
{
    public class OperationResult
    {
        protected OperationResult(bool isSuccess, string message)
        {
            Message = message;
            IsSuccess = isSuccess;
        }
        public string Message { get; private set; }
        public bool IsSuccess { get; private set; }

        public static OperationResult Success(string msg = "")
        {
            return new OperationResult(true, msg);
        }
        public static OperationResult Failed(string msg)
        {
            return new OperationResult(false, msg);
        }
    }


    public class OperationResult<T> : OperationResult
    {
        private OperationResult(bool isSuccess, string message, T data) : base(isSuccess, message)
        {
            Data = data;
        }
        public T Data { get; set; }

        public static OperationResult<T> Success(string message, T data)
        {
            return new OperationResult<T>(true, message, data);
        }
        public static new OperationResult<T> Failed(string message)
        {
            return new OperationResult<T>(false, message,default);
        }
    }
}
