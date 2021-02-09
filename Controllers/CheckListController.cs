using DataViewModel;
using Services.CheckList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RCMSWebAPI.Controllers
{
    [RoutePrefix("api/checklist")]
    public class CheckListController : ApiController
    {
        ICheckListService _checkListService;
        public CheckListController(ICheckListService checkListService)
        {
            _checkListService = checkListService;
        }
        [HttpGet]
        [Route("GetCheckList")]
        public List<CheckListModal> GetCheckList()
        {
            try
            {
                return _checkListService.GetCheckList();
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        [HttpPost]
        [Route("InsertCheckList")]
        public SuccessCheckListMessage InsertCheckList(CheckListModal data)
        {
            SuccessCheckListMessage objuser = new SuccessCheckListMessage();
            try
            {
                return _checkListService.InsertCheckList(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("UpdateCheckList")]
        public SuccessCheckListMessage UpdateCheckList(CheckListModal data)
        {
            SuccessCheckListMessage objuser = new SuccessCheckListMessage();
            try
            {
                return _checkListService.UpdateCheckList(data);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("GetCheckListById")]
        public SuccessCheckListMessage GetCheckListById(int id)
        {
            SuccessCheckListMessage objuser = new SuccessCheckListMessage();
            try
            {
                return _checkListService.GetCheckListById(id);
            }
            catch (Exception ex)
            {
                objuser.Status = false;
                objuser.Message = ex.Message.ToString();
                return objuser;
            }

        }

        [HttpPost]
        [Route("DeleteCheckListById")]
        public SuccessCheckListMessage DeleteCheckListById(int id)
        {
            SuccessCheckListMessage objuser = new SuccessCheckListMessage();
            try
            {
                return _checkListService.DeleteCheckListById(id);
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
