using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace Kiosk_PetaPoco.Models
{
    [TableName("Exhibits")]
    [PrimaryKey("Exhibit_id")]
    public class Exhibit
    {
        public long Exhibit_id { get; set; }
        public string Name { get; set; }
        public bool IsMedal { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
    }
}