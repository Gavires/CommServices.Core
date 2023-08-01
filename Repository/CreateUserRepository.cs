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
        private readonly IUserRegistrationHistoryRepository userRegistrationHistoryRepository;

        public CreateUserRepository(     
            IUserInputValidation _userInputValidation,
            IUserRepository _userRepository,
            IUserRegistrationHistoryRepository _userRegistrationHistoryRepository)
        {
            userInputValidation = _userInputValidation;
            userRepository = _userRepository;
            userRegistrationHistoryRepository = _userRegistrationHistoryRepository;
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
                        userRegistrationHistoryRepository.AddHistoryRegistrationUser(user);
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
