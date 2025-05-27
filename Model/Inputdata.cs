using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUDTXD_HUCE_2_VuQuangMinh_0066567_67TH3.Model
{
    public class InputData
    {
        public Taitrong Taitrong { get; set; }
        public Vatlieu Vatlieu { get; set; } 
        public Vatlieu2 Vatlieu2 { get; set; } 


        // Có thể thêm nhóm dữ liệu khác nếu cần sau này

        public InputData()
        {
            Taitrong = new Taitrong();
            Vatlieu = new Vatlieu();
            Vatlieu2 = new Vatlieu2();
        }
    }
}
