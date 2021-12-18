using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public string Message { get; }
        public bool Success { get; }
        public Result(string message, bool success):this(success)
        {
            this.Message = message;
        }
        public Result(bool success)
        {
            this.Success = success;
        }

        
    }
}
