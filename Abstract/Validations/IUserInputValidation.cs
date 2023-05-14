using CommServices.Core.Entity;

namespace CommServices.Core.Abstract.Validations
{
    public interface IUserInputValidation
    {
        bool UserInputDataReg(User user);
    }
}
