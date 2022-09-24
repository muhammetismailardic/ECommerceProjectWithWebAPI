﻿using Core.Utilities.Responses;
using Entities.Dtos.AppUser;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebAPIWithCoreMvc.ApiServices.Interfaces;

namespace WebAPIWithCoreMvc.ApiServices
{
    public class AppUserApiService : IAppUserApiService
    {
        private readonly IHttpClientService _httpClientService;

        public AppUserApiService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }

        public async Task<ApiDataResponse<List<AppUserDto>>> GetListAsync()
        {
            return await _httpClientService.GetListAsync<AppUserDto>("AppUsers/GetList");
        }
    }
}