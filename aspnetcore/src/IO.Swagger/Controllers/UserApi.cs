/*
 * Active Directory API Of HSBC
 *
 * 名称：活动目录API。   工具：[swagger](http://swagger.io)   规范：[openapi v3.0.0](https://www.openapis.org/)   
 *
 * OpenAPI spec version: 1.8.0
 * Contact: cloudy.w.h.luo@hsbc.com.cn
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UserApiController : ControllerBase
    { 
        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="adaccount">The name that needs to be deleted</param>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpDelete]
        [Route("/C-Dream/Active-Directory-API/1.8.0/api/ad/delete/{adaccount}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteUser")]
        public virtual IActionResult DeleteUser([FromRoute][Required]string adaccount)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取某个用户的详细信息
        /// </summary>
        /// <param name="adaccount">AD 账号.</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/C-Dream/Active-Directory-API/1.8.0/api/ad/query/{adaccount}")]
        [ValidateModelState]
        [SwaggerOperation("GetUserDetailByAdId")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "successful operation")]
        public virtual IActionResult GetUserDetailByAdId([FromRoute][Required]string adaccount)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"msg\" : \"msg\",\n  \"code\" : 0,\n  \"groups\" : \"groups\",\n  \"fullname\" : \"fullname\",\n  \"email\" : \"email\",\n  \"token\" : \"token\",\n  \"timestamp\" : \"timestamp\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<User>(exampleJson)
                        : default(User);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AD验证，成功则返回用户信息
        /// </summary>
        /// <param name="appid">APP 的 ID.</param>
        /// <param name="adaccount">AD 账号.</param>
        /// <param name="adpassword">AD 密码.</param>
        /// <response code="200">AD验证成功</response>
        /// <response code="400">参数错误</response>
        /// <response code="401">无权限（APP）</response>
        /// <response code="403">无权限（AD用户）</response>
        /// <response code="404">账号或密码错误</response>
        [HttpGet]
        [Route("/C-Dream/Active-Directory-API/1.8.0/api/ad/getinfo")]
        [ValidateModelState]
        [SwaggerOperation("Getinfo")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "AD验证成功")]
        public virtual IActionResult Getinfo([FromRoute][Required]string appid, [FromRoute][Required]string adaccount, [FromRoute][Required]string adpassword)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"msg\" : \"msg\",\n  \"code\" : 0,\n  \"groups\" : \"groups\",\n  \"fullname\" : \"fullname\",\n  \"email\" : \"email\",\n  \"token\" : \"token\",\n  \"timestamp\" : \"timestamp\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<User>(exampleJson)
                        : default(User);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 修改某个用户的信息
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="body">Updated user object</param>
        /// <param name="adaccount">name that need to be updated</param>
        /// <response code="400">Invalid user supplied</response>
        /// <response code="404">User not found</response>
        [HttpPut]
        [Route("/C-Dream/Active-Directory-API/1.8.0/api/ad/update/{adaccount}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateUser")]
        public virtual IActionResult UpdateUser([FromBody]User body, [FromRoute][Required]string adaccount)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }
    }
}
