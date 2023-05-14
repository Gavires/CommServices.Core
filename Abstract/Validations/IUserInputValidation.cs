using CommServices.Core.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.Abstract.Validations
{
    public interface IUserInputValidation
    {
        bool UserInputDataReg(User user);
    }
}
