using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    public class Validator
    {
        public void Validate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            request.ValidateUsername = username.Trim();
            request.ValidatePassword = password.Trim();
        }
    }
}