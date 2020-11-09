﻿using Acme.BookStore.Books;
using MongoDB.Bson;
using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class DatasDto : EntityDto
    {
        public double datas { get; set; }
    }
}
