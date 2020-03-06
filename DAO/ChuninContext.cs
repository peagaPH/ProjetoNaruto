using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ChuninContext : DbContext
    {
        public ChuninContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\900180\Documents\SSNeco.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

    }
}
