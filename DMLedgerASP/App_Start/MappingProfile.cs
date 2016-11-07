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
            CreateMap<BankAccount, BankAccountsDto>();
            CreateMap<BankAccountsDto, BankAccount>();

            CreateMap<Bill, BillsDto>();
            CreateMap<BillsDto, Bill>();

            CreateMap<CreditCard, CreditCardsDto>();
            CreateMap<CreditCardsDto, CreditCard>();
        }
    }
}