using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Models;

namespace App.IDAL
{
    public interface IHomeRepository
    {
        List<SysModule> GetMenuByPersonId(string personId, string moduleId);
    }
}