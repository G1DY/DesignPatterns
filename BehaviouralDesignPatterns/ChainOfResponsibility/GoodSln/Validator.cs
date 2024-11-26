using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln
{
    public class Validator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            request.ValidateUsername = username.Trim();
            request.ValidatePassword = password.Trim();

            return request.ValidateUsername == "" || request.ValidatePassword == "";
        }
    }
}