using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void AboutDelete(About about)
        {
            _aboutdal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutdal.Update(about);
        }

        public void AboutAdd(About about)
        {
            _aboutdal.Insert(about);
        }

        public About GetByID(int id)
        {
            return _aboutdal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _aboutdal.List();
        }
    }
}
