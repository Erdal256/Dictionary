﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingID(int id);
        void ContentyAdd(Content content);
        Content GetByID(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}