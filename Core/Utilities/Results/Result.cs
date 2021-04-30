using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Sadece success constructor'u çalıştırmak gerekirse alttaki çalışacak. İkisi birden çalışması gerekirse 1. çalışıp 2.yi de çalıştıracak.
        public Result(bool success, string message) : this(success)//success constructor'u çalıştırmak için
        {
            Message = message;           
        }
        public Result(bool success)
        {           
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
