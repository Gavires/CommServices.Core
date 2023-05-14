using CommServices.Core.Abstract.EntityCore;
using CommServices.Core.Abstract.Validations;
using CommServices.Core.Entity;
using System.Windows.Forms;

namespace CommServices.Core.Validations
{
    public class UserInputValidation : IUserInputValidation
    {
        public bool UserInputDataReg(User user)
        {
            if (user != null)
            {
                if (string.IsNullOrEmpty(user.Name))
                {
                    MessageBox.Show("Неоходимо ввести Имя пользователя!");
                    return false;
                }
                if (string.IsNullOrEmpty(user.UserName))
                {
                    MessageBox.Show("Неоходимо ввести Логин!");
                    return false;
                }
                if (string.IsNullOrEmpty(user.Password))
                {
                    MessageBox.Show("Неоходимо ввести Пароль!");
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
