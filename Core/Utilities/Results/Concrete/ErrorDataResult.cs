using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(string message,bool success,T data):base(message,false,data)
        {

        }
        public ErrorDataResult(T data,bool success):base(data,false)
        {

        }
        public ErrorDataResult(string message) : base(message, false, default)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
