﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanHangSieuThi_Entity
{
    public class EC_tblKhachHang
    {
        private string _MaKH;
 
        public string MaKH
        {
            get { return _MaKH; }
            set { MaKH = value; }
        }

        private string _TenKH;
 
        public string TenKH
        {
            get { return _TenKH; }
            set { TenKH = value; }
        }

        private string _GT;

        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _LoaiKH;

        public string LoaiKH
        {
            get { return _LoaiKH; }
            set { _LoaiKH = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
