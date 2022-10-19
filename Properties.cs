using System;

namespace xmlReadNodeByNode
{
    public static class Properties
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class AttCallout
        {
            public string type { get; set; }
            public string startnumber { get; set; }
            public List<Calloutitem> calloutitem { get; set; }
        }

        public class Attention
        {
            public string id { get; set; }
            public string type { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Attentiontbl> attentiontbl { get; set; }
        }

        public class AttentionBody
        {
            public AttentionBody attention_body { get; set; }
            public List<AttentionMark> attention_mark { get; set; }
            public List<AttentionPara> attention_para { get; set; }
        }

        public class AttentionMark
        {
            public AttentionMark attention_mark { get; set; }
        }

        public class AttentionPara
        {
            public AttentionPara attention_para { get; set; }
            public string id { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Title> title { get; set; }
            public List<AttList1> att_list1 { get; set; }
            public List<P> p { get; set; }
            public List<AttFig> att_fig { get; set; }
        }

        public class Attentiontbl
        {
            public Attentiontbl attentiontbl { get; set; }
            public string tabletype { get; set; }
            public string width { get; set; }
            public List<AttentiontblBody> attentiontbl_body { get; set; }
        }

        public class AttentiontblBody
        {
            public AttentiontblBody attentiontbl_body { get; set; }
            public List<AttentiontblBodyRow> attentiontbl_body_row { get; set; }
        }

        public class AttentiontblBodyRow
        {
            public AttentiontblBodyRow attentiontbl_body_row { get; set; }
            public List<AttentionBody> attention_body { get; set; }
        }

        public class AttFig
        {
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Image> image { get; set; }
            public AttFig att_fig { get; set; }
        }

        public class AttList1
        {
            public string type { get; set; }
            public string column { get; set; }
            public List<AttList1Item> att_list1_item { get; set; }
            public AttList1 att_list1 { get; set; }
        }

        public class AttList1Item
        {
            public AttList1Item att_list1_item { get; set; }
            public List<Itemtxt> itemtxt { get; set; }
        }

        public class AttList2
        {
            public string type { get; set; }
            public List<AttList2Item> att_list2_item { get; set; }
        }

        public class AttList2Item
        {
            public AttList2Item att_list2_item { get; set; }
            public List<Itemtxt> itemtxt { get; set; }
        }

        public  class Book
        {
            public string dev_code { get; set; }
            public string pubname { get; set; }
            public string drive_train { get; set; }
            public string brand { get; set; }
            public string scale { get; set; }
            public string pubno { get; set; }
            public string period_from { get; set; }
            public string body_type { get; set; }
            public string model { get; set; }
            public string lang { get; set; }
            public string revision { get; set; }
            public string vehicle_code { get; set; }
            public string om_style { get; set; }
            public string lo_date { get; set; }
            public string identify_code { get; set; }
            public string id { get; set; }
            public string manualtype { get; set; }
            public string period_to { get; set; }
            public string publish_date { get; set; }
            public string production { get; set; }
            public string vehicle_type { get; set; }
            public string destination { get; set; }
            public List<Chapter> chapter { get; set; }
        }

        public class Break
        {
            public string type { get; set; }
            public string @break { get; set; }
        }

        public class Callout
        {
            public string type { get; set; }
            public string startnumber { get; set; }
            public List<Calloutitem> calloutitem { get; set; }
        }

        public class Calloutgroup
        {
            public string type { get; set; }
            public string titletype { get; set; }
            public string startnumber { get; set; }
            public List<Title> title { get; set; }
        }

        public class Calloutitem
        {
            public Calloutitem calloutitem { get; set; }
            public List<Callouttxt> callouttxt { get; set; }
        }

        public class Callouttxt
        {
            public Callouttxt callouttxt { get; set; }
            public CallouttxtSub callouttxt_sub { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public List<Symbol> symbol { get; set; }
            public List<Child> Child { get; set; }
        }

        public class CallouttxtSub
        {
            public string column { get; set; }
            public string page { get; set; }
            public string callouttxt_sub { get; set; }
        }

        public class Chapter
        {
            public Chapter chapter { get; set; }
            public string id { get; set; }
            public string chaptype { get; set; }
            public string chapnum { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Title> title { get; set; }
        }

        public class Child
        {
            public Break @break { get; set; }
            public Sup sup { get; set; }
            public Xref xref { get; set; }
            public Symbol symbol { get; set; }
        }

        public class Colspec
        {
            public Colspec colspec { get; set; }
            public Thead thead { get; set; }
            public Tbody tbody { get; set; }
            public string colnum { get; set; }
            public string colname { get; set; }
            public string colwidth { get; set; }
            public string colsep { get; set; }
        }

        public class Entry
        {
            public Entry entry { get; set; }
            public string namest { get; set; }
            public string nameend { get; set; }
            public string fontwidth { get; set; }
            public string colname { get; set; }
            public List<P> p { get; set; }
            public List<TblFig> tbl_fig { get; set; }
            public string align { get; set; }
            public string valign { get; set; }
            public string morerows { get; set; }
        }

        public class Fig
        {
            public string column { get; set; }
            public string page { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Image> image { get; set; }
            public Fig fig { get; set; }
            public List1 list1 { get; set; }
            public Paraselect paraselect { get; set; }
        }

        public class Footnote
        {
            public Footnote footnote { get; set; }
            public Para para { get; set; }
            public string type { get; set; }
            public List<P> p { get; set; }
            public string id { get; set; }
            public List1 list1 { get; set; }
            public Fig fig { get; set; }
            public PSub p_sub { get; set; }
            public string num { get; set; }
        }

        public class Image
        {
            public Image image { get; set; }
            public P p { get; set; }
            public string href { get; set; }
            public string height { get; set; }
            public string width { get; set; }
            public string id { get; set; }
            public string border { get; set; }
            public Calloutgroup calloutgroup { get; set; }
            public Callout callout { get; set; }
            public string xoffset { get; set; }
            public string yoffset { get; set; }
            public string align { get; set; }
            public AttCallout att_callout { get; set; }
        }

        public class Indexmarker
        {
            public Indexmarker indexmarker { get; set; }
            public Sup sup { get; set; }
            public string marker { get; set; }
            public string markerid { get; set; }
        }

        public class Itemtxt
        {
            public Itemtxt itemtxt { get; set; }
            public string page { get; set; }
            public ItemtxtSub itemtxt_sub { get; set; }
            public Fig fig { get; set; }
            public AttFig att_fig { get; set; }
            public AttList2 att_list2 { get; set; }
            public List<Child> Child { get; set; }
        }

        public class ItemtxtSub
        {
            public string page { get; set; }
            public string itemtxt_sub { get; set; }
        }

        public class List1
        {
            public string type { get; set; }
            public string column { get; set; }
            public List<List1Item> list1_item { get; set; }
            public List1 list1 { get; set; }
        }

        public class List1Item
        {
            public List1Item list1_item { get; set; }
            public List<Itemtxt> itemtxt { get; set; }
        }

        public class Note
        {
            public string id { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<NoteBody> note_body { get; set; }
        }

        public class NoteBody
        {
            public NoteBody note_body { get; set; }
            public List<NotePara> note_para { get; set; }
        }

        public class NotePara
        {
            public NotePara note_para { get; set; }
            public string id { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Title> title { get; set; }
        }

        public class OmBody
        {
            public string id { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<P> p { get; set; }
            public List<Fig> fig { get; set; }
            public List<Footnote> footnote { get; set; }
            public List<Title> title { get; set; }
            public List<List1> list1 { get; set; }
        }

        public class Overview
        {
            public string id { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Para> para { get; set; }
            public List<Footnote> footnote { get; set; }
        }

        public class P
        {
            public P p { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public List<Child> Child { get; set; }
            public List<Sup> sup { get; set; }
            public List<Symbol> symbol { get; set; }
            public Step step { get; set; }
            public PSub p_sub { get; set; }
            public Fig fig { get; set; }
            public List1 list1 { get; set; }
            public Table table { get; set; }
            public Footnote footnote { get; set; }
            public TblFig tbl_fig { get; set; }
            public List<Xref> xref { get; set; }
        }

        public class Para
        {
            public Para para { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public List<Paratable> paratable { get; set; }
        }

        public class ParaList
        {
            public string type { get; set; }
            public List<ParaListItem> para_list_item { get; set; }
        }

        public class ParaListItem
        {
            public ParaListItem para_list_item { get; set; }
            public List<Itemtxt> itemtxt { get; set; }
        }

        public class Paraselect
        {
            public List<Paraselectitem> paraselectitem { get; set; }
        }

        public class Paraselectitem
        {
            public Paraselectitem paraselectitem { get; set; }
            public List<Title> title { get; set; }
        }

        public class Paratable
        {
            public Paratable paratable { get; set; }
            public List<Paratablebody> paratablebody { get; set; }
            public string width { get; set; }
            public string tabletype { get; set; }
        }

        public class Paratablebody
        {
            public Paratablebody paratablebody { get; set; }
            public List<Paratablerow> paratablerow { get; set; }
        }

        public class Paratablecell
        {
            public Paratablecell paratablecell { get; set; }
            public List<Paratabletxt> paratabletxt { get; set; }
        }

        public class Paratablerow
        {
            public Paratablerow paratablerow { get; set; }
            public List<Paratablecell> paratablecell { get; set; }
        }

        public class Paratabletxt
        {
            public Paratabletxt paratabletxt { get; set; }
            public ParaList para_list { get; set; }
            public string type { get; set; }
            public List<Child> Child { get; set; }
        }

        public class PSub
        {
            public string column { get; set; }
            public string page { get; set; }
            public string p_sub { get; set; }
        }

        public class Root
        {
            public Book book { get; set; }
        }

        public class Row
        {
            public Row row { get; set; }
            public List<Entry> entry { get; set; }
        }

        public class Section
        {
            public string id { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Title> title { get; set; }
        }

        public class Step
        {
            public string column { get; set; }
            public string startnumber { get; set; }
            public List<Stepitem> stepitem { get; set; }
        }

        public class Stepitem
        {
            public Stepitem stepitem { get; set; }
            public string column { get; set; }
            public List<Steptxt> steptxt { get; set; }
        }

        public class Steptxt
        {
            public Steptxt steptxt { get; set; }
            public Fig fig { get; set; }
            public string num { get; set; }
            public string page { get; set; }
            public List1 list1 { get; set; }
            public SteptxtSub steptxt_sub { get; set; }
            public List<Child> Child { get; set; }
            public string number { get; set; }
        }

        public class SteptxtSub
        {
            public string page { get; set; }
            public string steptxt_sub { get; set; }
            public List<Child> Child { get; set; }
        }

        public class SubsectionAttention
        {
            public string id { get; set; }
            public string column { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Titlegroup> titlegroup { get; set; }
        }

        public class Sup
        {
            public string sup { get; set; }
        }

        public class Symbol
        {
            public string href { get; set; }
            public string width { get; set; }
            public string height { get; set; }
            public string symbol { get; set; }
            public Break @break { get; set; }
            public Sup sup { get; set; }
            public Xref xref { get; set; }
        }

        public class Table
        {
            public string frame { get; set; }
            public string fontsize { get; set; }
            public string column { get; set; }
            public string colsep { get; set; }
            public string rowsep { get; set; }
            public string page { get; set; }
            public List<Tgroup> tgroup { get; set; }
        }

        public class TblFig
        {
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Image> image { get; set; }
            public TblFig tbl_fig { get; set; }
            public P p { get; set; }
        }

        public class Tbody
        {
            public List<Row> row { get; set; }
        }

        public class Tgroup
        {
            public Tgroup tgroup { get; set; }
            public string cols { get; set; }
            public string tabletype { get; set; }
            public string colsep { get; set; }
            public string rowsep { get; set; }
            public List<Colspec> colspec { get; set; }
        }

        public class Thead
        {
            public List<Row> row { get; set; }
        }

        public class Title
        {
            public Title title { get; set; }
            public Section section { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public Paraselect paraselect { get; set; }
            public Fig fig { get; set; }
            public P p { get; set; }
            public List1 list1 { get; set; }
            public Step step { get; set; }
            public Footnote footnote { get; set; }
            public Table table { get; set; }
            public PSub p_sub { get; set; }
            public Note note { get; set; }
            public Attention attention { get; set; }
            public List<Indexmarker> indexmarker { get; set; }
            public List<Child> Child { get; set; }
            public Calloutitem calloutitem { get; set; }
            public AttList1 att_list1 { get; set; }
            public AttFig att_fig { get; set; }
            public SubsectionAttention subsection_attention { get; set; }
        }

        public class Titlegroup
        {
            public Titlegroup titlegroup { get; set; }
            public Overview overview { get; set; }
            public Topic topic { get; set; }
            public Attention attention { get; set; }
            public List<Titlegroupbody> titlegroupbody { get; set; }
            public string width { get; set; }
            public OmBody om_body { get; set; }
            public Note note { get; set; }
            public string tabletype { get; set; }
        }

        public class Titlegroupbody
        {
            public Titlegroupbody titlegroupbody { get; set; }
            public List<Titlegrouprow> titlegrouprow { get; set; }
        }

        public class Titlegroupcell
        {
            public Titlegroupcell titlegroupcell { get; set; }
            public List<Title> title { get; set; }
        }

        public class Titlegrouprow
        {
            public Titlegrouprow titlegrouprow { get; set; }
            public List<Titlegroupcell> titlegroupcell { get; set; }
        }

        public class Topic
        {
            public string id { get; set; }
            public string column { get; set; }
            public string page { get; set; }
            public string publish_em { get; set; }
            public string publish_pm { get; set; }
            public string publish_fullpm { get; set; }
            public List<Titlegroup> titlegroup { get; set; }
        }

        public class Xref
        {
            public string refid { get; set; }
            public string srcfile { get; set; }
            public string ref_em { get; set; }
            public string ref_pm { get; set; }
            public string ref_fullpm { get; set; }
            public string xref { get; set; }
            public string type { get; set; }
        }


    }
}

