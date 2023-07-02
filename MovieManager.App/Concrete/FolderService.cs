using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManager.App.Common;
using MovieManager.Domain.Entity;

namespace MovieManager.App.Concrete
{
    public class FolderService : BaseService<Folder>
    {
        public List<Folder> folders = new List<Folder>();
        //public List<Folder> folders;
    }
}
