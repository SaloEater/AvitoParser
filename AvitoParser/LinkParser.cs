using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace AvitoParser
{
    public class LinkParser
    {

        

        public Dictionary<String, List<Link>> GetProducts(List<string> links)
        {
            Dictionary<String, List<Link>> Products = new Dictionary<String, List<Link>>();
            foreach (String link in links)
            {
                if (link == "") continue;
                List<Link> bufferP = new List<Link>();
                try
                {
                    bufferP = GetHTML(link);
                }
                catch(Exception)
                {
                    if (Products.Count == 0) throw new Exception();
                    else return Products;
                }
                Products.Add(link, bufferP);
            }
            return Products;
        }

        private static List<Link> GetHTML(String url)
        {       
            var httpClient = new HttpClient();
            string html = httpClient.GetStringAsync(url).Result; 
            
            
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);
            
            List<HtmlNode> ProductsHtml = new List<HtmlNode>();
            
            ProductsHtml.Add(htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("js-catalog_before-ads")).ToList().FirstOrDefault());
            
            ProductsHtml.Add(htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("js-catalog_after-ads")).ToList().FirstOrDefault());
            
            if(ProductsHtml[0] == null && ProductsHtml[1]== null)
            {
                MessageBox.Show("Бан на авито, нужно ждать пока пройдет");
                throw new Exception();
            }

            List<HtmlNode> ProductsList = new List<HtmlNode>();
            
            foreach (HtmlNode ProductHtml in ProductsHtml)
            {
                var bufferProductsList = ProductHtml.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Contains("js-catalog-item-enum")).ToList();
                
                foreach (HtmlNode bufferProductList in bufferProductsList)
                {
                    ProductsList.Add(bufferProductList);
                }
            }
            
            List<Link> Products = new List<Link>();
            
            foreach (HtmlNode Product in ProductsList)
            {
                Link productInfo = new Link();
                HtmlNode aLink = Product.Descendants("a")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("item-description-title-link")).FirstOrDefault();
                productInfo.title = Clear(aLink.InnerText);
                productInfo.price = Clear(Product.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "")
                    .Equals("about about_bold-price")).FirstOrDefault().InnerText);
                productInfo.link = "\n https://www.avito.ru" + Clear(aLink.GetAttributeValue("href", ""));
                Products.Add(productInfo);
                //Console.WriteLine(aLink.InnerText.Trim('\n', '\r', '\t'));
                
            }
            
            return Products;
        }

        private static string Clear(string innerText)
        {
            return innerText.Replace("\n", "").Replace("\t", "").Replace("\r", "");
        }
    }
}
