using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestDemo.Pages
{
    public class News
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string description { get; set; }
        public string Link { get; set; }
    }
    public class NewsModel : PageModel
    {
        public List<News> news { get; set; }

        public void OnGet()
        {
            news = new List<News>();
            for (int i = 0; i < 10; i++)
            {
                news.Add(new News
                {
                    Title = "Stora �versv�mningar i G�vle � kraftiga skyfall",
                    Image = "svtstatic.se/image/wide/992/32218159/1629293032?format=auto",
                    description = "Flera viadukter och byggnader har �versv�mmats i G�vleborgs l�n. I G�vle har det kommit 161,6 millimeter regn fr�n klockan �tta i g�r tisdag till klockan �tta i dag, onsdag. Bara under natten har r�ddningstj�nsten tagit emot runt 400 larmsamtal om �versv�mningar i omr�det.",
                    Link = "https://www.svt.se/nyheter/lokalt/gavleborg/stora-oversvamningar-allmanheten-varnas",
                });
            }

        }
    }
}
