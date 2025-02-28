using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Lutfen oda numarasini giriniz")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lutfen fiyat bilgisi giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lutfen oda basligi bilgisi giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lutfen yatak sayisi bilgisi giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lutfen banyo sayisi bilgisi giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
