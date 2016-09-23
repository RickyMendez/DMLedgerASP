using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DMLedgerASP.Models;
using DMLedgerASP.Dtos;

namespace DMLedgerASP.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CreditCard, CreditCardsDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<CreditCardsDto, CreditCard>());

            Mapper.Initialize(cfg => cfg.CreateMap<Bill, BillsDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<BillsDto, Bill>());

            Mapper.Initialize(cfg => cfg.CreateMap<BankAccount, BankAccountsDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<BankAccountsDto, BankAccount>());

            Mapper.Initialize(cfg => cfg.CreateMap<UserData, UsersDataDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<UsersDataDto, UserData>());
        }
    }
}