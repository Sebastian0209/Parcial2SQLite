using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;
using System.Linq;
using System.Threading.Tasks;


namespace SERios2
{
    public interface IConfig

    {
        string DirectorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
