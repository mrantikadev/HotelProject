﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Lutfen oda numarasini giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lutfen oda resmin giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lutfen fiyat bilgisi giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lutfen oda basligi bilgisi giriniz")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter girilebilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lutfen yatak sayisi bilgisi giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lutfen banyo sayisi bilgisi giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lutfen oda aciklamasi giriniz")]
        public string Description { get; set; }
    }
}
