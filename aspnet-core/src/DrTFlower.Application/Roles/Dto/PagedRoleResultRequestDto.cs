﻿using Abp.Application.Services.Dto;

namespace DrTFlower.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

