using System;
namespace xmlReadNodeByNode
{
    public class PropertiesNew
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Attention
        {
            public Attentiontbl attentiontbl { get; set; }
        }

        public class AttentionBody
        {
            public string attention_mark { get; set; }
            public AttentionPara attention_para { get; set; }
        }

        public class AttentionPara
        {
            public object p { get; set; }
            public object title { get; set; }
            public AttList1 att_list1 { get; set; }
            public AttFig att_fig { get; set; }
        }

        public class Attentiontbl
        {
            public AttentiontblBody attentiontbl_body { get; set; }
        }

        public class AttentiontblBody
        {
            public List<AttentiontblBodyRow> attentiontbl_body_row { get; set; }
        }

        public class AttentiontblBodyRow
        {
            public AttentionBody attention_body { get; set; }
        }

        public class AttFig
        {
            public string image { get; set; }
        }

        public class AttList1
        {
            public AttList1Item att_list1_item { get; set; }
        }

        public class AttList1Item
        {
            public object itemtxt { get; set; }
        }

        public class Book
        {
            public Chapter chapter { get; set; }
        }

        public class Chapter
        {
            public string title { get; set; }
            public List<Section> section { get; set; }
        }

        public class Root
        {
            public ToyotaOmVhGeEn toyota_om_vh_ge_en { get; set; }
        }

        public class Section
        {
            public string title { get; set; }
            public List<SubsectionAttention> subsection_attention { get; set; }
        }

        public class SubsectionAttention
        {
            public Titlegroup titlegroup { get; set; }
            public object overview { get; set; }
            public object topic { get; set; }
            public Attention attention { get; set; }
        }

        public class Titlegroup
        {
            public Titlegroupbody titlegroupbody { get; set; }
        }

        public class Titlegroupbody
        {
            public Titlegrouprow titlegrouprow { get; set; }
        }

        public class Titlegroupcell
        {
            public object title { get; set; }
        }

        public class Titlegrouprow
        {
            public Titlegroupcell titlegroupcell { get; set; }
        }

        public class ToyotaOmVhGeEn
        {
            public Book book { get; set; }
        }


    }
}

