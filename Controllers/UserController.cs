using DataViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Case;
using Services.UserData;
using Services.Property;

namespace RCMSWebAPI.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        ICaseService _caseService;
        IUserDataService _userService;
        public UserController(ICaseService caseService, IUserDataService userService)
        {
            _caseService = caseService;
            _userService = userService;
        }
        [HttpGet]
        [Route("GetSecurityQuestion")]
        public List<SecurityQuestionModel> GetSecurityQuestion()
        {
            try
            {
                return _userService.GetSecurityQuestion();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        [HttpPost]
        [Route("SaveUserSecurityAnswers")]
        public SuccessUserMessage UserRegistration(SecurityQuestionResponseModel data)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _userService.InsertSecurityQuestionResponse(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("UserRegistration")]
        public SuccessUserMessage UserRegistration(UserRegistration data)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.InsertUser(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpGet]
        [Route("VerifyUser")]
        public SuccessUserMessage VerifyUser(string username, string token)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.VerifyUser(username, token);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpPost]
        [Route("UpdateUserPassword")]
        public SuccessUserMessage UpdateUserPassword(string username, string password)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.UpdateUserPassword(username, password);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpGet]
        [Route("CheckUser")]
        public SuccessUserMessage CheckUser(string username)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.CheckUser(username);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpPost]
        [Route("UpdateUser")]
        public SuccessUserMessage UpdateUser(Employee data)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.UpdateEmployee(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpPost]
        [Route("GetUser")]
        public SuccessUserMessage GetUser(SignInUserModel obj)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.GetUser(obj.UserName, obj.Password);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpPost]
        [Route("GetUsers")]
        public List<Employee> GetUsers()
        {
            try
            {
                return _caseService.GetUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [Route("GetUserById")]
        public SuccessEmployeeMessage GetUserById(int Id)
        {
            SuccessEmployeeMessage objuser = new SuccessEmployeeMessage();
            try
            {
                return _caseService.GetUserById(Id);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpPost]
        [Route("DeleteUser")]
        public SuccessUserMessage DeleteUserById(int Id)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.DeleteUserById(Id);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }
        [HttpPost]
        [Route("ForgetPassword")]
        public SuccessUserMessage ForgetPassword(string username)
        {
            SuccessUserMessage objuser = new SuccessUserMessage();
            try
            {
                return _caseService.SendEmail(username);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }



    }
}
