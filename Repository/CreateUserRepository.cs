using CommServices.Core.Abstract.EntityCore;
using CommServices.Core.Abstract.Repository;
using CommServices.Core.Abstract.Validations;
using CommServices.Core.Entity;
using System;
using System.Windows.Forms;

namespace CommServices.Core.Repository
{
    public class CreateUserRepository : ICreateUserRepository
    {
        private readonly IUserInputValidation userInputValidation;
        private readonly IUserRepository userRepository;

        public CreateUserRepository(
            IUserInputValidation _userInputValidation, 
            IUserRepository _userRepository)
        {
            userInputValidation = _userInputValidation;
            userRepository = _userRepository;
        }

        public bool RegisteringNewUser(User user)
        {
            if (userInputValidation.UserInputDataReg(user))
            {
                if (userRepository.AuthorizationUser(user))
                {
                    MessageBox.Show($"Пользователь с логином {user.UserName} существует!");
                    return false;
                }
                else
                {
                    try
                    {
                        MessageBox.Show($"Будет записан такой пользователь: {user.Name}");
                        userRepository.AddNewUser(user);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
