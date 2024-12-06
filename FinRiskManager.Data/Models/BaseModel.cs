using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceRiskManagement.Data.Models
{
    public class BaseModel
    {
        public string Id { get; set; }  // GUID as string

        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
