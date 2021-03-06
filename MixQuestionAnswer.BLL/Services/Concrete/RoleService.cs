﻿using AutoMapper;
using MixQuestionAnswer.BLL.DTOs;
using MixQuestionAnswer.BLL.Services.Abstract;
using MixQuestionAnswer.DAL.Repositories.Abstract;
using MixQuestionAnswer.DAL.Repositories.Concrete;
using MixQuestionAnswer.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace MixQuestionAnswer.BLL.Services.Concrete
{
    public class RoleService : Service<RoleDTO,Role,IRoleRepository>,IRoleService
    {
        public RoleService(IRoleRepository repository, IMapper mapper) : base(repository, mapper, "RoleService")
        {
        }
    }
}
