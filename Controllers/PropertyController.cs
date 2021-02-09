using DataViewModel;
using Services.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCMSWebAPI.Controllers
{
    [RoutePrefix("api/property")]
    public class PropertyController : ApiController
    {
        IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        [Route("GetUserByRole")]
        public SuccessRoleMessage GetRoleUserById(int id)
        {
            try
            {
                return _propertyService.GetRoleUserById(id);
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        [HttpGet]
        [Route("GetProperties")]
        public List<PropertyModel> GetProperties()
        {
            try
            {
                return _propertyService.GetProperties();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        [HttpPost]
        [Route("InsertProperty")]
        public SuccessPropertyMessage InsertProperty(PropertyModel data)
        {
            SuccessPropertyMessage objuser = new SuccessPropertyMessage();
            try
            {
                return _propertyService.InsertProperty(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("UpdateProperty")]
        public SuccessPropertyMessage UpdateProperty(PropertyModel data)
        {
            SuccessPropertyMessage objuser = new SuccessPropertyMessage();
            try
            {
                return _propertyService.UpdateProperty(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("GetPropertyById")]
        public SuccessPropertyMessage GetPropertyById(int id)
        {
            SuccessPropertyMessage objuser = new SuccessPropertyMessage();
            try
            {
                return _propertyService.GetPropertyById(id);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("DeletePropertyById")]
        public SuccessPropertyMessage DeletePropertyById(int id)
        {
            SuccessPropertyMessage objuser = new SuccessPropertyMessage();
            try
            {
                return _propertyService.DeletePropertyById(id);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpGet]
        [Route("GetDepartments")]
        public List<DepartmentModel> GetDepartments()
        {
            try
            {
                return _propertyService.GetDepartments();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        [HttpPost]
        [Route("InsertDepartment")]
        public SuccessDepartmentMessage InsertDepartment(DepartmentModel data)
        {
            SuccessDepartmentMessage objuser = new SuccessDepartmentMessage();
            try
            {
                return _propertyService.InsertDepartment(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("UpdateDepartment")]
        public SuccessDepartmentMessage UpdateDepartment(DepartmentModel data)
        {
            SuccessDepartmentMessage objuser = new SuccessDepartmentMessage();
            try
            {
                return _propertyService.UpdateDepartment(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("GetDepartmentById")]
        public SuccessDepartmentMessage GetDepartmentById(int id)
        {
            SuccessDepartmentMessage objuser = new SuccessDepartmentMessage();
            try
            {
                return _propertyService.GetDepartmentById(id);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("DeleteDepartmentById")]
        public SuccessDepartmentMessage DeleteDepartmentById(int id)
        {
            SuccessDepartmentMessage objuser = new SuccessDepartmentMessage();
            try
            {
                return _propertyService.DeleteDepartmentById(id);
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
