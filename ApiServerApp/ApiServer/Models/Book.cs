using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServer.Models
{
    public class Book
    {
    }
}

public class Rootobject
{
    public int page { get; set; }
    public Reading_Log_Entries[] reading_log_entries { get; set; }
}

public class Reading_Log_Entries
{
    public Work work { get; set; }
    public string logged_edition { get; set; }
    public string logged_date { get; set; }
}

public class Work
{
    public string title { get; set; }
    public string key { get; set; }
    public string[] author_keys { get; set; }
    public string[] author_names { get; set; }
    public int? first_publish_year { get; set; }
    public string lending_edition_s { get; set; }
    public string[] edition_key { get; set; }
    public int? cover_id { get; set; }
    public string cover_edition_key { get; set; }
}
