﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BeyazEsyaOtomasyon
{
    class sqlbaglantisi
    {
        

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-ACPBBEV\SQLEXPRESS;Initial Catalog=DboBeyazOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        } 
    }
}
