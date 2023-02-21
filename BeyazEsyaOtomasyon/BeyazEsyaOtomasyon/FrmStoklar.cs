﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeyazEsyaOtomasyon
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
           // chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
           // chartControl1.Series["Series 1"].Points.AddPoint("İzmmir", 8);
           // chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 6);
           // chartControl1.Series["Series 1"].Points.AddPoint("Adana", 5);

            SqlDataAdapter da = new SqlDataAdapter("Select UrunAd,Sum(Adet) as 'Miktar' from TBL_URUNLER GROUP BY URUNAD",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //Charta Stok miktarı listeleme

            SqlCommand komut = new SqlCommand("Select UrunAd,Sum(Adet) as 'Miktar' from TBL_URUNLER GROUP BY URUNAD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse (dr[1].ToString()));
            }
            bgl.baglanti().Close();

            // CHARTA FİRMA -ŞEHİR SAYISI EKLEME

            SqlCommand komut2 = new SqlCommand("Select IL,Count(*) from TBL_FIRMALAR GROUP BY IL", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl.baglanti().Close();


        }
    }
}
