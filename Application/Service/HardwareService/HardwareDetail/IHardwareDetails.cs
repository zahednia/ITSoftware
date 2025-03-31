using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationIT.Service.HardwareService.HardwareDetail
{
    public interface IHardwareDetails
    {
        List<string> GetDetail(int HardwareTypeId);
    }
}
