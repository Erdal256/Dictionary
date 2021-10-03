﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public Message GetByID(int id)
        {
            return _messagedal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _messagedal.List(x => x.RecieverMail == "admin@gmail.com"); //alıcı mail
        }

        public List<Message> GetListSendbox()
        {
            return _messagedal.List(x => x.SenderMail == "admin@gmail.com"); //gönderen mail
        }

        public void MessageAdd(Message message)
        {
            _messagedal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}