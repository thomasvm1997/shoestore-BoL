using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Services.ResultModels
{
    public class ResultModel<T> : BaseResultModel
    {
        public T Data { get; set; }
    }
}
