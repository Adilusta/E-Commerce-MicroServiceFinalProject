﻿using BtkAkademi.Services.ShoppingCartAPI.Models.Dto;
using Newtonsoft.Json;

namespace BtkAkademi.Services.ShoppingCartAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly HttpClient client;

        public CouponRepository(HttpClient client)
        {
            this.client = client;
        }

        public async Task<CouponDto> GetCoupon(string couponName)
        {
            var response = await client.GetAsync($"/api/coupon/{couponName}");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
            if (resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(resp.Result));
            }
            return new CouponDto();
        }
    }
}
